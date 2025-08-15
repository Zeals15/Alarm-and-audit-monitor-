using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlarmAndAuditMonitor
{
    public partial class Form1 : Form
    {
        private readonly string _cs =
            ConfigurationManager.ConnectionStrings["Default"].ConnectionString;

        private Timer _alarmTimer;

        public Form1()
        {
            InitializeComponent();

            _alarmTimer = new Timer();
            _alarmTimer.Interval = 5000;
            _alarmTimer.Tick += async (s, e) => await LoadAlarmServerAsync();

            PrepareGrid(dgvAlarmServer, true);
            PrepareGrid(dgvAuditLog, true);
        }

        // ---------- grid look & header guarantees ----------
        private void PrepareGrid(DataGridView g, bool readOnly)
        {
            g.ReadOnly = readOnly;
            g.AllowUserToAddRows = false;
            g.AllowUserToDeleteRows = false;
            g.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            g.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            g.RowHeadersVisible = false;

            g.ColumnHeadersVisible = true;
            g.EnableHeadersVisualStyles = false;
            g.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            g.ColumnHeadersHeight = 36;
            g.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            g.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            g.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            g.ColumnHeadersDefaultCellStyle.Font = new Font(g.Font, FontStyle.Bold);

            g.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 248, 255);
        }

        // ---------- form load ----------
        private async void Form1_Load(object sender, EventArgs e)
        {
            await LoadAlarmServerAsync();
            await LoadAuditLogAsync();
        }

        // ---------- UI events ----------
        private async void btnRefreshAlarms_Click(object sender, EventArgs e)
        {
            await LoadAlarmServerAsync();
        }

        private async void btnRefreshAudit_Click(object sender, EventArgs e)
        {
            await LoadAuditLogAsync();
        }

        private void chkAuto_CheckedChanged(object sender, EventArgs e)
        {
            _alarmTimer.Enabled = chkAuto.Checked;
        }

        private void numSecs_ValueChanged(object sender, EventArgs e)
        {
            _alarmTimer.Interval = (int)numSecs.Value * 1000;
        }

        // ---------- build columns (explicit) ----------
        private void BuildAlarmColumns()
        {
            var g = dgvAlarmServer;
            g.AutoGenerateColumns = false;
            g.Columns.Clear();

            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colA",
                HeaderText = "Active Time",
                DataPropertyName = "Active Time",
                FillWeight = 25
            });
            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colAck",
                HeaderText = "Acknowledge Time",
                DataPropertyName = "Acknowledge Time",
                FillWeight = 25
            });
            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colI",
                HeaderText = "Inactive Time",
                DataPropertyName = "Inactive Time",
                FillWeight = 25
            });
            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colText",
                HeaderText = "Text",
                DataPropertyName = "Text",
                FillWeight = 25
            });

            g.Columns["colA"].DefaultCellStyle.Format   = "yyyy-MM-dd HH:mm:ss";
            g.Columns["colAck"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";
            g.Columns["colI"].DefaultCellStyle.Format   = "yyyy-MM-dd HH:mm:ss";
        }

        private void BuildAuditColumns()
        {
            var g = dgvAuditLog;
            g.AutoGenerateColumns = false;
            g.Columns.Clear();

            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colTime",
                HeaderText = "Time",
                DataPropertyName = "Time",
                FillWeight = 20
            });
            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colDesc",
                HeaderText = "Description",
                DataPropertyName = "Description",
                FillWeight = 40
            });
            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colAfter",
                HeaderText = "Value After",
                DataPropertyName = "Value After",
                FillWeight = 13
            });
            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colBefore",
                HeaderText = "Value Before",
                DataPropertyName = "Value Before",
                FillWeight = 13
            });
            g.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colUser",
                HeaderText = "User Name",
                DataPropertyName = "User Name",
                FillWeight = 14
            });

            g.Columns["colTime"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";
        }

        // ---------- data loaders ----------
        private async Task LoadAlarmServerAsync()
        {
            const string sql = @"
SELECT TOP (1000)
       [ActiveTime]       AS [Active Time],
       [AcknowledgeTime]  AS [Acknowledge Time],
       [InActiveTime]     AS [Inactive Time],
       [Text]
FROM [dbo].[AlarmServer]
ORDER BY [AcknowledgeTime] DESC;";

            try
            {
                using (var con = new SqlConnection(_cs))
                using (var da = new SqlDataAdapter(sql, con))
                {
                    var dt = new DataTable();
                    await con.OpenAsync();
                    da.Fill(dt);

                    BuildAlarmColumns();      // ensure columns exist BEFORE binding
                    dgvAlarmServer.DataSource = dt;

                    // force header visible (defensive)
                    dgvAlarmServer.ColumnHeadersVisible = true;
                    dgvAlarmServer.Invalidate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Alarms Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadAuditLogAsync()
        {
            const string sql = @"
SELECT TOP (1000)
       [TimeStamp]   AS [Time],
       [Description],
       [ValueAfter]  AS [Value After],
       [ValueBefore] AS [Value Before],
       [UserName]    AS [User Name]
FROM [dbo].[AuditLog]
ORDER BY [TimeStamp] DESC;";

            try
            {
                using (var con = new SqlConnection(_cs))
                using (var da = new SqlDataAdapter(sql, con))
                {
                    var dt = new DataTable();
                    await con.OpenAsync();
                    da.Fill(dt);

                    BuildAuditColumns();     
                    dgvAuditLog.DataSource = dt;

                    dgvAuditLog.ColumnHeadersVisible = true;
                    dgvAuditLog.Invalidate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Audit Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
