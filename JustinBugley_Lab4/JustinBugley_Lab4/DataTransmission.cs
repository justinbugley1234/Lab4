/*
Name: Justin Bugley
Lab #: 4
Sources:
https://docs.microsoft.com/en-us/dotnet/api/system.io.ports.serialport.read?view=dotnet-plat-ext-6.0
https://docs.microsoft.com/en-us/dotnet/api/system.text.encoding.getstring?view=net-6.0
https://stackoverflow.com/questions/623104/byte-to-hex-string?msclkid=5361db1aabb411ec90700ed06890919f
https://docs.microsoft.com/en-us/dotnet/api/system.byte?msclkid=9ae36957abba11eca2f04edf6179a630&view=net-6.0
https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/types/how-to-convert-between-hexadecimal-strings-and-numeric-types#:~:text=The%20following%20example%20shows%20how%20to%20convert%20a,%3D%20Convert.ToHexString%20%28array%29%3B%20Console.WriteLine%20%28hexValue%29%3B%20%2F%2AOutput%3A%20646F74636574%20%2A%2F.?msclkid=cb382ea9abba11ec87894b3054e6fb96


 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;
using CRC8_Class;

namespace JustinBugley_Lab4
{
    public partial class DataTransmission : Form
    {

        Encoding encoder = Encoding.ASCII;
        public SerialPort serialPort1;
        const int ARRAY_SIZE = 255;
        const byte SOH = 0x01;
        byte LENGTH;
        public DataTransmission()
        {
            InitializeComponent();
            serialPort1.BaudRate = 9600;
            serialPort1.DataBits = 8;
            serialPort1.StopBits = System.IO.Ports.StopBits.One;
            serialPort1.Parity = System.IO.Ports.Parity.None;
            serialPort1.Handshake = System.IO.Ports.Handshake.None;
            serialPort1.ReadTimeout = 10000;
            serialPort1.WriteTimeout = 1000;
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                
                byte[] bytesRead = new byte[ARRAY_SIZE];
                try
                {
                    serialPort1.Read(bytesRead, 0, ARRAY_SIZE);
                    CRC_Class cd = new CRC_Class(bytesRead);
                    //boxDataRead.AppendText(encoder.GetString(bytesRead));
                    int i = 0;
                    foreach (byte b in bytesRead)
                    {
                        if (i == 0)
                        {
                            boxDataRead.AppendText("SOH: " + b + "\r\n");
                        }
                        if (i == 1)
                        {
                            boxDataRead.AppendText("Length: " + (int)b + "\r\n");
                        }
                        if (i == ARRAY_SIZE - 1)
                        {
                            boxDataRead.AppendText("Received CRC: " + b + "\r\n");
                            boxDataRead.AppendText("Calculated CRC: " + (byte)cd.crcCalc() + "\r\n");
                        }
                        i++;
                    }
                }
                catch (System.TimeoutException)
                {
                    MessageBox.Show("Read request timed out");
                }
            }
            else
            {
                MessageBox.Show("The serial port must be opened before data can be written.");
            }
        }

        private void openPortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                serialPort1.Open();
                openPortToolStripMenuItem.Checked = true;
                closePortToolStripMenuItem.Checked = false;
            }
            else
            {
                MessageBox.Show("Serial Port is already open.");
            }
        }

        private void closePortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                openPortToolStripMenuItem.Checked = false;
                closePortToolStripMenuItem.Checked = true;
            }
            else
            {
                MessageBox.Show("The serial port must be open before it can be closed.");
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                
                byte[] byteAry = new byte[ARRAY_SIZE];
                byteAry[0] = SOH;
                LENGTH = (byte)(boxDataOut.Text.Length + 3);
                byteAry[1] = LENGTH;
                CRC_Class cc = new CRC_Class(byteAry);
                byteAry[byteAry.Length - 1] = (byte)cc.crcCalc();
                encoder.GetBytes(boxDataOut.Text, 0, boxDataOut.Text.Length, byteAry, 2);
                serialPort1.Write(byteAry, 0, byteAry.Length);
                while (serialPort1.BytesToWrite > 0){}
                HexText.AppendText("SEND: \r\n");
                foreach(byte b in byteAry){
                    if(b != 0x00)
                    {
                        HexText.AppendText($"{Convert.ToInt32(b):X}");
                        HexText.AppendText(" ");
                    }
                }
                HexText.AppendText("\r\n");
                //boxDataRead.AppendText(BitConverter.ToString(byteAry).Replace("-", " "));

            }
            else
            {
                MessageBox.Show("The serial port must be opened before data can be written.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            HexText.Text = "";
            boxDataRead.Text = "";
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

            //Not really possible for this event to be fired if it's not open, but let's test anyway.
            if (serialPort1.IsOpen)
            {
                boxDataRead.Invoke(new EventHandler(delegate
                {
                    MessageBox.Show("Data Received");
                    string dataRecieved = serialPort1.ReadExisting();
                    boxDataRead.AppendText(dataRecieved);
                }));

            }
            else
            {
                MessageBox.Show("Serial port must be opened before reading data.");
            }
        }

        private void PortButton_Click_1(object sender, EventArgs e)
        {
            PortConfig config = new PortConfig();
            config.og = this;
            config.ShowDialog();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}