using System;
using System.IO.Ports;
using System.Threading;

namespace ArduinoMaster
{
    public partial class Form1 : Form
    {
        SerialPort serialPort1 = new SerialPort();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Close();
            }
        }

        private void listCOMPorts()
        {
            int qty = 0;
            bool newPorts = false;

            if (cbPorts.Items.Count == SerialPort.GetPortNames().Length)
            {
                foreach (String p in SerialPort.GetPortNames())
                {
                    if (cbPorts.Items[qty++].Equals(p) == false)
                    {
                        newPorts = true;
                    }
                }
            }
            else
            {
                newPorts = true;
            }

            if (newPorts == false)
            {
                return;
            }

            cbPorts.Items.Clear();

            foreach (string s in SerialPort.GetPortNames())
            {
                cbPorts.Items.Add(s);
            }
            cbPorts.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listCOMPorts();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {


            if (serialPort1.IsOpen == false)
            {
                try
                {
                    serialPort1.PortName = cbPorts.Items[cbPorts.SelectedIndex].ToString();
                    serialPort1.Open();
                }
                catch
                {
                    return;
                }
                if (serialPort1.IsOpen == true)
                {
                    btnConnect.Text = "Desconectar";
                    cbPorts.Enabled = false;
                }
            }
            else
            {
                try
                {
                    serialPort1.Close();
                    cbPorts.Enabled = true;
                    btnConnect.Text = "Conectar";
                }
                catch
                {
                    return;
                }
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Write(txtSend.Text);
            }
        }
    }
}