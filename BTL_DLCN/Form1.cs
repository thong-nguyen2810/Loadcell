using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

namespace BTL_DLCN
{
    public partial class Form1 : Form
    {
        SerialPort serialPort;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbPort.Items.AddRange(
                SerialPort.GetPortNames());

            cbBaud.Items.Add("115200");

            cbBaud.SelectedIndex = 0;

            cbLength.Items.Add("8");
            cbLength.SelectedIndex = 0;

            cbParity.Items.Add("None");
            cbParity.SelectedIndex = 0;

            cbStop.Items.Add("1");
            cbStop.SelectedIndex = 0;
        }

        private void btnConnect_Click(object sender,
                                      EventArgs e)
        {
            try
            {
                if (serialPort == null
                    || !serialPort.IsOpen)
                {
                    serialPort = new SerialPort(
                        cbPort.Text,
                        115200,
                        Parity.None,
                        8,
                        StopBits.One);

                    serialPort.DataReceived +=
                        SerialPort_DataReceived;

                    serialPort.Open();

                    btnConnect.Text =
                        "Disconnect";

                    btnConnect.BackColor =
                        Color.Red;

                    txtLog.AppendText(
                        "Connected\r\n");
                }
                else
                {
                    serialPort.Close();

                    btnConnect.Text =
                        "Connect";

                    btnConnect.BackColor =
                        Color.Lime;

                    txtLog.AppendText(
                        "Disconnected\r\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SerialPort_DataReceived(
            object sender,
            SerialDataReceivedEventArgs e)
        {
            try
            {
                string data =
                    serialPort.ReadExisting();

                this.Invoke(new Action(() =>
                {
                    txtLog.AppendText(
                        "[" +
                        DateTime.Now.ToString("HH:mm:ss")
                        + "] "
                        + data);

                    txtLog.SelectionStart =
                        txtLog.Text.Length;

                    txtLog.ScrollToCaret();

                    ParseWeight(data);
                }));
            }
            catch
            {

            }
        }

        private void ParseWeight(string data)
        {
            try
            {
                if (data.Contains("W:"))
                {
                    int start =
                        data.IndexOf("W:") + 2;

                    int end =
                        data.IndexOf("|");

                    if (end > start)
                    {
                        string w =
                            data.Substring(
                                start,
                                end - start);

                        txtWeight.Text =
                            w + " g";
                    }
                }
            }
            catch
            {

            }
        }

        private void btnCalib_Click(object sender,
                                    EventArgs e)
        {
            if (serialPort != null
                && serialPort.IsOpen)
            {
                byte[] cmd =
                {
                    (byte)'C'
                };

                serialPort.Write(cmd, 0, 1);

                txtLog.AppendText(
                    "Command: Start Calibrate Sequence...\r\n");
            }
        }

        private void btnTare_Click(object sender,
                                   EventArgs e)
        {
            if (serialPort != null
                && serialPort.IsOpen)
            {
                byte[] cmd =
                {
                    (byte)'T'
                };

                serialPort.Write(cmd, 0, 1);

                txtLog.AppendText(
                    "Send TARE\r\n");
            }
        }

        private void btnSetCalib_Click(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                string weightVal = string.IsNullOrEmpty(txtCalibInput.Text) ? "439" : txtCalibInput.Text;

                // Gửi định dạng: S + giá trị + \n (Ví dụ: "S500.0\n")
                // Chữ 'S' giúp STM32 phân biệt đây là lệnh SET BIẾN, không phải lệnh CALIB
                string cmd = "S" + weightVal + "\n";

                serialPort.Write(cmd);
                txtLog.AppendText("Update Variable Calib Weight: " + weightVal + " g\r\n");
            }
        }
    }
}