using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace EnvironmentMonitor
{
    public partial class frmMain : Form
    {
        private SerialPort m_port = null;
        private ECDataClassesDataContext m_db = new ECDataClassesDataContext();

        public frmMain()
        {
            InitializeComponent();

            this.DoubleBuffered = true;
        }        

        private void frmMain_Load(object sender, EventArgs e)
        {
            InitSerialPortInfo();
            InitChart();
        }

        private static string[] DATATYPE = { "湿度", "温度","火焰值","烟雾值" };

        private void InitChart()
        {
            chtData.DataSource = environmentRecordBindingSource.List;

            //定义表区域
            chtData.ChartAreas.Clear();
            ChartArea chartarea = new ChartArea("数据趋势图");
            chtData.ChartAreas.Add(chartarea);

            //定义存储和显示点的容器
            chtData.Series.Clear();
            for (int i = 0; i < 4; i++)
            {
                Series series = new Series(DATATYPE[i]);
                chtData.Series.Add(series);
                series.ChartArea = "数据趋势图";
                series.ChartType = SeriesChartType.Spline;
                series.MarkerBorderWidth = 2;
                series.MarkerSize = 4;
                series.MarkerStyle = MarkerStyle.Diamond;
                series.ToolTip = DATATYPE[i] + "#VAL \r\n #AXISLABEL";
            }
        }

        private void ResetChartData()
        {
            for (int i = 0; i < chtData.Series.Count; i++)
            {
                chtData.Series[i].Points.Clear();
            }
        }

        private void AddData(EnvironmentRecord er)
        {
            chtData.Series[0].Points.AddY(er.Humidity);
            chtData.Series[1].Points.AddY(er.Temperature);
            chtData.Series[2].Points.AddY(er.FlameValue);
            chtData.Series[3].Points.AddY(er.MQValue);
        }

        private void InitSerialPortInfo()
        {
            string[] ports = SerialPort.GetPortNames();

            if (ports != null && ports.Length > 0)
            {
                foreach (string sp in SerialPort.GetPortNames())
                {
                    comboSerialPort.Items.Add(sp);
                }
            }
        }

        private void OpenPort()
        {
            this.Cursor = Cursors.WaitCursor;

            try
            {
                ClosePort();

                if (string.IsNullOrWhiteSpace(comboSerialPort.Text))
                {
                    MessageBox.Show("当前串口为空，请在窗口中选中可用端口");
                    return;
                }

                m_port = new SerialPort(comboSerialPort.Text, 9600);
                m_port.Parity = Parity.None;
                m_port.StopBits = StopBits.One;
                m_port.DataBits = 8;
                m_port.Handshake = Handshake.None;
                m_port.RtsEnable = true;
                m_port.DataReceived += new SerialDataReceivedEventHandler(SerialDataReceived);

                m_port.Open();                

                this.lblStatus.Text = "串口已打开";

                this.btnClosePort.Enabled = true;
                this.btnOpenPort.Enabled = false;
            }
            catch (Exception ex)
            {
                this.lblStatus.Text = "串口操作失败，错误消息为：" + ex.Message;
                MessageBox.Show(this.lblStatus.Text);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void SerialDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadLine().TrimEnd('\r');
            Console.WriteLine(indata);
            UpdateSerialPortData(indata);
        }

        private delegate void UpdateSerialPortDataHandler(string cnt);
        private const string OK_SIGN = "0";
        private const string FAIL_SIGN = "1";

        private const char SPLIT_CHAR_1 = ',';
        private const char SPLIT_CHAR_2 = ';';

        private void UpdateSerialPortData(string rawData)
        {
            if (this.InvokeRequired)
            {
                this.BeginInvoke(new UpdateSerialPortDataHandler(UpdateSerialPortData), rawData);
            }
            else
            {
                EnvironmentRecord er = new EnvironmentRecord();
                er.CreateTime = DateTime.Now;

                string[] subStrs = rawData.Trim(SPLIT_CHAR_2).Split(SPLIT_CHAR_2);

                if (subStrs.Length != 3)
                {
                    return;
                }

                //解析温湿度
                string[] dhtValues = subStrs[0].Split(SPLIT_CHAR_1);
                
                er.DHTState = dhtValues[0] == OK_SIGN;
                if (er.DHTState)
                {
                    er.Humidity = Convert.ToInt32(dhtValues[1]);
                    er.Temperature = Convert.ToInt32(dhtValues[2]);
                }
                else
                {
                    er.ErrorMsg = dhtValues[1];
                }

                //解析火焰传感器值
                er.FlameValue = Convert.ToInt32(subStrs[1]);
                this.lblFlameWaring.Visible = er.FlameValue < 100;

                //解析烟雾传感器值
                er.MQValue = Convert.ToInt32(subStrs[2]);
                this.lblMQ.Visible = er.MQValue > 500;

                m_db.EnvironmentRecord.InsertOnSubmit(er);
                m_db.SubmitChanges();

                environmentRecordBindingSource.Insert(0,er);

                AddData(er);
            }
        }

        private void ClosePort()
        {
            if (m_port != null && m_port.IsOpen)
            {
                m_port.Close();
                m_port.Dispose();
                m_port = null;

                this.lblStatus.Text = "串口已关闭";

                this.btnOpenPort.Enabled = true;
                this.btnClosePort.Enabled = false;
            }
        }
        private void btnClosePort_Click(object sender, EventArgs e)
        {
            ClosePort();
        }

        private void btnOpenPort_Click(object sender, EventArgs e)
        {
            OpenPort();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClosePort();
        }
    }
}
