namespace AlarmAndAuditMonitor
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabAlarms;
        private System.Windows.Forms.TabPage tabAudit;

        private System.Windows.Forms.Panel panelAlarmHost;
        private System.Windows.Forms.Panel panelAuditHost;

        private System.Windows.Forms.FlowLayoutPanel barAlarms;
        private System.Windows.Forms.Button btnRefreshAlarms;
        private System.Windows.Forms.CheckBox chkAuto;
        private System.Windows.Forms.NumericUpDown numSecs;
        private System.Windows.Forms.Label lblSec;

        private System.Windows.Forms.FlowLayoutPanel barAudit;
        private System.Windows.Forms.Button btnRefreshAudit;

        private System.Windows.Forms.DataGridView dgvAlarmServer;
        private System.Windows.Forms.DataGridView dgvAuditLog;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabAlarms = new System.Windows.Forms.TabPage();
            this.panelAlarmHost = new System.Windows.Forms.Panel();
            this.dgvAlarmServer = new System.Windows.Forms.DataGridView();
            this.barAlarms = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRefreshAlarms = new System.Windows.Forms.Button();
            this.chkAuto = new System.Windows.Forms.CheckBox();
            this.numSecs = new System.Windows.Forms.NumericUpDown();
            this.lblSec = new System.Windows.Forms.Label();
            this.tabAudit = new System.Windows.Forms.TabPage();
            this.panelAuditHost = new System.Windows.Forms.Panel();
            this.dgvAuditLog = new System.Windows.Forms.DataGridView();
            this.barAudit = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRefreshAudit = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabAlarms.SuspendLayout();
            this.panelAlarmHost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlarmServer)).BeginInit();
            this.barAlarms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSecs)).BeginInit();
            this.tabAudit.SuspendLayout();
            this.panelAuditHost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditLog)).BeginInit();
            this.barAudit.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabAlarms);
            this.tabControl1.Controls.Add(this.tabAudit);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1200, 650);
            this.tabControl1.TabIndex = 0;
            // 
            // tabAlarms
            // 
            this.tabAlarms.Controls.Add(this.panelAlarmHost);
            this.tabAlarms.Location = new System.Drawing.Point(4, 25);
            this.tabAlarms.Name = "tabAlarms";
            this.tabAlarms.Size = new System.Drawing.Size(1192, 621);
            this.tabAlarms.TabIndex = 0;
            this.tabAlarms.Text = "AlarmLog";
            // 
            // panelAlarmHost
            // 
            this.panelAlarmHost.Controls.Add(this.dgvAlarmServer);
            this.panelAlarmHost.Controls.Add(this.barAlarms);
            this.panelAlarmHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAlarmHost.Location = new System.Drawing.Point(0, 0);
            this.panelAlarmHost.Name = "panelAlarmHost";
            this.panelAlarmHost.Size = new System.Drawing.Size(1192, 621);
            this.panelAlarmHost.TabIndex = 0;
            // 
            // dgvAlarmServer
            // 
            this.dgvAlarmServer.ColumnHeadersHeight = 29;
            this.dgvAlarmServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAlarmServer.Location = new System.Drawing.Point(0, 36);
            this.dgvAlarmServer.Name = "dgvAlarmServer";
            this.dgvAlarmServer.RowHeadersWidth = 51;
            this.dgvAlarmServer.Size = new System.Drawing.Size(1192, 585);
            this.dgvAlarmServer.TabIndex = 0;
            // 
            // barAlarms
            // 
            this.barAlarms.Controls.Add(this.btnRefreshAlarms);
            this.barAlarms.Controls.Add(this.chkAuto);
            this.barAlarms.Controls.Add(this.numSecs);
            this.barAlarms.Controls.Add(this.lblSec);
            this.barAlarms.Dock = System.Windows.Forms.DockStyle.Top;
            this.barAlarms.Location = new System.Drawing.Point(0, 0);
            this.barAlarms.Name = "barAlarms";
            this.barAlarms.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.barAlarms.Size = new System.Drawing.Size(1192, 36);
            this.barAlarms.TabIndex = 1;
            // 
            // btnRefreshAlarms
            // 
            this.btnRefreshAlarms.AutoSize = true;
            this.btnRefreshAlarms.Location = new System.Drawing.Point(11, 9);
            this.btnRefreshAlarms.Name = "btnRefreshAlarms";
            this.btnRefreshAlarms.Size = new System.Drawing.Size(109, 26);
            this.btnRefreshAlarms.TabIndex = 0;
            this.btnRefreshAlarms.Text = "Refresh Alarms";
            this.btnRefreshAlarms.Click += new System.EventHandler(this.btnRefreshAlarms_Click);
            // 
            // chkAuto
            // 
            this.chkAuto.AutoSize = true;
            this.chkAuto.Location = new System.Drawing.Point(135, 12);
            this.chkAuto.Margin = new System.Windows.Forms.Padding(12, 6, 6, 6);
            this.chkAuto.Name = "chkAuto";
            this.chkAuto.Size = new System.Drawing.Size(101, 20);
            this.chkAuto.TabIndex = 1;
            this.chkAuto.Text = "Auto-refresh";
            this.chkAuto.CheckedChanged += new System.EventHandler(this.chkAuto_CheckedChanged);
            // 
            // numSecs
            // 
            this.numSecs.Location = new System.Drawing.Point(248, 9);
            this.numSecs.Margin = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.numSecs.Maximum = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            this.numSecs.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSecs.Name = "numSecs";
            this.numSecs.Size = new System.Drawing.Size(60, 22);
            this.numSecs.TabIndex = 2;
            this.numSecs.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numSecs.ValueChanged += new System.EventHandler(this.numSecs_ValueChanged);
            // 
            // lblSec
            // 
            this.lblSec.AutoSize = true;
            this.lblSec.Location = new System.Drawing.Point(314, 14);
            this.lblSec.Margin = new System.Windows.Forms.Padding(6, 8, 0, 0);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(29, 16);
            this.lblSec.TabIndex = 3;
            this.lblSec.Text = "sec";
            // 
            // tabAudit
            // 
            this.tabAudit.Controls.Add(this.panelAuditHost);
            this.tabAudit.Location = new System.Drawing.Point(4, 25);
            this.tabAudit.Name = "tabAudit";
            this.tabAudit.Size = new System.Drawing.Size(1192, 621);
            this.tabAudit.TabIndex = 1;
            this.tabAudit.Text = "AuditLog";
            // 
            // panelAuditHost
            // 
            this.panelAuditHost.Controls.Add(this.dgvAuditLog);
            this.panelAuditHost.Controls.Add(this.barAudit);
            this.panelAuditHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAuditHost.Location = new System.Drawing.Point(0, 0);
            this.panelAuditHost.Name = "panelAuditHost";
            this.panelAuditHost.Size = new System.Drawing.Size(1192, 621);
            this.panelAuditHost.TabIndex = 0;
            // 
            // dgvAuditLog
            // 
            this.dgvAuditLog.ColumnHeadersHeight = 29;
            this.dgvAuditLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAuditLog.Location = new System.Drawing.Point(0, 36);
            this.dgvAuditLog.Name = "dgvAuditLog";
            this.dgvAuditLog.RowHeadersWidth = 51;
            this.dgvAuditLog.Size = new System.Drawing.Size(1192, 585);
            this.dgvAuditLog.TabIndex = 0;
            // 
            // barAudit
            // 
            this.barAudit.Controls.Add(this.btnRefreshAudit);
            this.barAudit.Dock = System.Windows.Forms.DockStyle.Top;
            this.barAudit.Location = new System.Drawing.Point(0, 0);
            this.barAudit.Name = "barAudit";
            this.barAudit.Padding = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.barAudit.Size = new System.Drawing.Size(1192, 36);
            this.barAudit.TabIndex = 1;
            // 
            // btnRefreshAudit
            // 
            this.btnRefreshAudit.AutoSize = true;
            this.btnRefreshAudit.Location = new System.Drawing.Point(11, 9);
            this.btnRefreshAudit.Name = "btnRefreshAudit";
            this.btnRefreshAudit.Size = new System.Drawing.Size(97, 26);
            this.btnRefreshAudit.TabIndex = 0;
            this.btnRefreshAudit.Text = "Refresh Audit";
            this.btnRefreshAudit.Click += new System.EventHandler(this.btnRefreshAudit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Alarm / Audit Monitor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabAlarms.ResumeLayout(false);
            this.panelAlarmHost.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlarmServer)).EndInit();
            this.barAlarms.ResumeLayout(false);
            this.barAlarms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSecs)).EndInit();
            this.tabAudit.ResumeLayout(false);
            this.panelAuditHost.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditLog)).EndInit();
            this.barAudit.ResumeLayout(false);
            this.barAudit.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
