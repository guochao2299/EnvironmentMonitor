
namespace EnvironmentMonitor
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnClosePort = new System.Windows.Forms.Button();
            this.btnOpenPort = new System.Windows.Forms.Button();
            this.comboSerialPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvRecords = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dHTStateDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.errorMsgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.humidityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temperatureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flameValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mQValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.environmentRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblFlameWaring = new System.Windows.Forms.Label();
            this.lblMQ = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.environmentRecordBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1063, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 16);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblMQ);
            this.splitContainer1.Panel1.Controls.Add(this.lblFlameWaring);
            this.splitContainer1.Panel1.Controls.Add(this.btnClosePort);
            this.splitContainer1.Panel1.Controls.Add(this.btnOpenPort);
            this.splitContainer1.Panel1.Controls.Add(this.comboSerialPort);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvRecords);
            this.splitContainer1.Size = new System.Drawing.Size(1063, 428);
            this.splitContainer1.SplitterDistance = 46;
            this.splitContainer1.TabIndex = 1;
            // 
            // btnClosePort
            // 
            this.btnClosePort.Enabled = false;
            this.btnClosePort.Location = new System.Drawing.Point(349, 10);
            this.btnClosePort.Name = "btnClosePort";
            this.btnClosePort.Size = new System.Drawing.Size(92, 23);
            this.btnClosePort.TabIndex = 2;
            this.btnClosePort.Text = "关闭串口";
            this.btnClosePort.UseVisualStyleBackColor = true;
            this.btnClosePort.Click += new System.EventHandler(this.btnClosePort_Click);
            // 
            // btnOpenPort
            // 
            this.btnOpenPort.Location = new System.Drawing.Point(251, 10);
            this.btnOpenPort.Name = "btnOpenPort";
            this.btnOpenPort.Size = new System.Drawing.Size(92, 23);
            this.btnOpenPort.TabIndex = 2;
            this.btnOpenPort.Text = "打开串口";
            this.btnOpenPort.UseVisualStyleBackColor = true;
            this.btnOpenPort.Click += new System.EventHandler(this.btnOpenPort_Click);
            // 
            // comboSerialPort
            // 
            this.comboSerialPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSerialPort.FormattingEnabled = true;
            this.comboSerialPort.Location = new System.Drawing.Point(89, 10);
            this.comboSerialPort.Name = "comboSerialPort";
            this.comboSerialPort.Size = new System.Drawing.Size(144, 23);
            this.comboSerialPort.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择串口：";
            // 
            // dgvRecords
            // 
            this.dgvRecords.AllowUserToAddRows = false;
            this.dgvRecords.AllowUserToDeleteRows = false;
            this.dgvRecords.AutoGenerateColumns = false;
            this.dgvRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.createTimeDataGridViewTextBoxColumn,
            this.dHTStateDataGridViewCheckBoxColumn,
            this.errorMsgDataGridViewTextBoxColumn,
            this.humidityDataGridViewTextBoxColumn,
            this.temperatureDataGridViewTextBoxColumn,
            this.flameValueDataGridViewTextBoxColumn,
            this.mQValueDataGridViewTextBoxColumn});
            this.dgvRecords.DataSource = this.environmentRecordBindingSource;
            this.dgvRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecords.Location = new System.Drawing.Point(0, 0);
            this.dgvRecords.Name = "dgvRecords";
            this.dgvRecords.ReadOnly = true;
            this.dgvRecords.RowHeadersWidth = 25;
            this.dgvRecords.RowTemplate.Height = 27;
            this.dgvRecords.Size = new System.Drawing.Size(1063, 378);
            this.dgvRecords.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 60;
            // 
            // createTimeDataGridViewTextBoxColumn
            // 
            this.createTimeDataGridViewTextBoxColumn.DataPropertyName = "CreateTime";
            this.createTimeDataGridViewTextBoxColumn.HeaderText = "接收时间";
            this.createTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.createTimeDataGridViewTextBoxColumn.Name = "createTimeDataGridViewTextBoxColumn";
            this.createTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.createTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // dHTStateDataGridViewCheckBoxColumn
            // 
            this.dHTStateDataGridViewCheckBoxColumn.DataPropertyName = "DHTState";
            this.dHTStateDataGridViewCheckBoxColumn.HeaderText = "温湿度状态";
            this.dHTStateDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.dHTStateDataGridViewCheckBoxColumn.Name = "dHTStateDataGridViewCheckBoxColumn";
            this.dHTStateDataGridViewCheckBoxColumn.ReadOnly = true;
            this.dHTStateDataGridViewCheckBoxColumn.Width = 125;
            // 
            // errorMsgDataGridViewTextBoxColumn
            // 
            this.errorMsgDataGridViewTextBoxColumn.DataPropertyName = "ErrorMsg";
            this.errorMsgDataGridViewTextBoxColumn.HeaderText = "错误消息";
            this.errorMsgDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.errorMsgDataGridViewTextBoxColumn.Name = "errorMsgDataGridViewTextBoxColumn";
            this.errorMsgDataGridViewTextBoxColumn.ReadOnly = true;
            this.errorMsgDataGridViewTextBoxColumn.Width = 125;
            // 
            // humidityDataGridViewTextBoxColumn
            // 
            this.humidityDataGridViewTextBoxColumn.DataPropertyName = "Humidity";
            this.humidityDataGridViewTextBoxColumn.HeaderText = "湿度值";
            this.humidityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.humidityDataGridViewTextBoxColumn.Name = "humidityDataGridViewTextBoxColumn";
            this.humidityDataGridViewTextBoxColumn.ReadOnly = true;
            this.humidityDataGridViewTextBoxColumn.Width = 125;
            // 
            // temperatureDataGridViewTextBoxColumn
            // 
            this.temperatureDataGridViewTextBoxColumn.DataPropertyName = "Temperature";
            this.temperatureDataGridViewTextBoxColumn.HeaderText = "温度值℃";
            this.temperatureDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.temperatureDataGridViewTextBoxColumn.Name = "temperatureDataGridViewTextBoxColumn";
            this.temperatureDataGridViewTextBoxColumn.ReadOnly = true;
            this.temperatureDataGridViewTextBoxColumn.Width = 125;
            // 
            // flameValueDataGridViewTextBoxColumn
            // 
            this.flameValueDataGridViewTextBoxColumn.DataPropertyName = "FlameValue";
            this.flameValueDataGridViewTextBoxColumn.HeaderText = "火焰值";
            this.flameValueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.flameValueDataGridViewTextBoxColumn.Name = "flameValueDataGridViewTextBoxColumn";
            this.flameValueDataGridViewTextBoxColumn.ReadOnly = true;
            this.flameValueDataGridViewTextBoxColumn.Width = 125;
            // 
            // mQValueDataGridViewTextBoxColumn
            // 
            this.mQValueDataGridViewTextBoxColumn.DataPropertyName = "MQValue";
            this.mQValueDataGridViewTextBoxColumn.HeaderText = "烟雾值";
            this.mQValueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mQValueDataGridViewTextBoxColumn.Name = "mQValueDataGridViewTextBoxColumn";
            this.mQValueDataGridViewTextBoxColumn.ReadOnly = true;
            this.mQValueDataGridViewTextBoxColumn.Width = 125;
            // 
            // environmentRecordBindingSource
            // 
            this.environmentRecordBindingSource.DataSource = typeof(EnvironmentMonitor.EnvironmentRecord);
            // 
            // lblFlameWaring
            // 
            this.lblFlameWaring.AutoSize = true;
            this.lblFlameWaring.BackColor = System.Drawing.Color.Red;
            this.lblFlameWaring.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblFlameWaring.Location = new System.Drawing.Point(482, 10);
            this.lblFlameWaring.Name = "lblFlameWaring";
            this.lblFlameWaring.Size = new System.Drawing.Size(235, 24);
            this.lblFlameWaring.TabIndex = 3;
            this.lblFlameWaring.Text = "注意！检测到火焰！";
            this.lblFlameWaring.Visible = false;
            // 
            // lblMQ
            // 
            this.lblMQ.AutoSize = true;
            this.lblMQ.BackColor = System.Drawing.Color.Red;
            this.lblMQ.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMQ.Location = new System.Drawing.Point(739, 10);
            this.lblMQ.Name = "lblMQ";
            this.lblMQ.Size = new System.Drawing.Size(285, 24);
            this.lblMQ.TabIndex = 4;
            this.lblMQ.Text = "注意！检测到可燃气体！";
            this.lblMQ.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "Arduino基本环境监测";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.environmentRecordBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvRecords;
        private System.Windows.Forms.Button btnClosePort;
        private System.Windows.Forms.Button btnOpenPort;
        private System.Windows.Forms.ComboBox comboSerialPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource environmentRecordBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dHTStateDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn errorMsgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn humidityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn temperatureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flameValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mQValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblMQ;
        private System.Windows.Forms.Label lblFlameWaring;
    }
}

