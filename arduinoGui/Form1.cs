using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

namespace arduinoGui
{
    public partial class Form1 : Form
    {
        string serialDataIn;
        int numFlame = 0;
        double intTemp = 0, outTemp = 0, humidity = 0;
        int iOutTemp;
        int iIntTemp;
        int iHum;
        int iFlame;
        int iEnd;
        bool updateDataFlag = false;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            startButton.Enabled = true;
            stopButton.Enabled = false;

            BaudRateBox.Text = "115200";


            tempHumChart.Series["Humidity"].Points.AddXY(1, 1);
            tempHumChart.Series["Internal Temperature"].Points.AddXY(1, 1);
            tempHumChart.Series["Outside Temperature"].Points.AddXY(1, 1);

            string[] portList = SerialPort.GetPortNames();
            comPortBox.Items.AddRange(portList);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void circularHumidityBar_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = comPortBox.Text;
                serialPort1.BaudRate = Convert.ToInt32(BaudRateBox.Text);
                serialPort1.Open();

                startButton.Enabled = false;
                stopButton.Enabled = true;
                connectionLabel.Text = "CONNECTED";
                connectionLabel.ForeColor = Color.Green;

                tempHumChart.Series["Humidity"].Points.Clear();
                tempHumChart.Series["Internal Temperature"].Points.Clear();
                tempHumChart.Series["Outside Temperature"].Points.Clear();
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Close();

                    startButton.Enabled = true;
                    stopButton.Enabled = false;
             
                    connectionLabel.Text = "DISCONNECTED";
                    connectionLabel.ForeColor = Color.Red;

                    //fireStatusLabel.Text = "NO FIRE";
                    //fireStatusLabel.ForeColor = Color.Green;
                    //numFireDetectLabel.Text = "0 out of 4 Flame sensors detect a fire";


                    //updateDataFlag = false;

                }
                catch(Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                try
                {
                    serialPort1.Close();
                }
                catch(Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            serialDataIn = serialPort1.ReadExisting();
            Data_Parse(serialDataIn);
           
            this.BeginInvoke(new EventHandler(ShowData));
            
        }

        private void Data_Parse(string data)
        {
            iOutTemp = data.IndexOf('!'); // start, thermocouple
            iIntTemp = data.IndexOf('@'); // internal temp
            iHum = data.IndexOf('$');     // humidity
            iFlame = data.IndexOf('&');   // Number of flame sensors
            iEnd = data.IndexOf('*');     // End marker

            if((iOutTemp != -1) && (iIntTemp != -1) && (iHum != -1) && (iFlame != -1) && (iEnd != -1))
            {
                try
                {
                    string str_outtemp = data.Substring(iOutTemp + 1, (iIntTemp - iOutTemp) - 1);
                    string str_inttemp = data.Substring(iIntTemp + 1, (iHum - iIntTemp) - 1);
                    string str_hum = data.Substring(iHum + 1, (iFlame - iHum) - 1);
                    string str_flame = data.Substring(iFlame + 1, (iEnd - iFlame) - 1);

                    outTemp = Convert.ToDouble(str_outtemp);
                    intTemp = Convert.ToDouble(str_inttemp);
                    humidity = Convert.ToDouble(str_hum);
                    numFlame = Convert.ToInt32(str_flame);

                    updateDataFlag = true;
                }
                catch(Exception)
                {

                }
            }
            else
            {
                updateDataFlag = false;
            }
            
         
        }

        private void ShowData(object sender, EventArgs e)
        {
            
            serialTextBox.Text += serialDataIn;
    
            //serialTextBox.Text += iIntTemp;
            //serialTextBox.Text += iHum;
            //serialTextBox.Text += intTemp;

            if (updateDataFlag == true)
            {
            
                if(numFlame > 0)
                {
                    fireStatusLabel.Text = "FIRE DETECTED";
                    fireStatusLabel.ForeColor = Color.Red;
                    numFireDetectLabel.Text = string.Format("{0} out of 4 Flame sensors detect a fire", numFlame.ToString());
                    Application.DoEvents();
                }
                else
                {
                    fireStatusLabel.Text = "NO FIRE";
                    fireStatusLabel.ForeColor = Color.Green;
                    numFireDetectLabel.Text = "0 out of 4 Flame sensors detect a fire";
                    Application.DoEvents();
                }

                circularHumidityBar.Value = Convert.ToInt32(humidity);
                circularHumidityBar.Text = string.Format("{0}%", humidity.ToString());

                Application.DoEvents();

                OutTempNum.Text = string.Format("{0} °C", outTemp.ToString());
                outTempBar.Height = Convert.ToInt32(outTemp) * 182 / 100;
                double otbLoc = outTempBarOutline.Height - (Convert.ToInt32(outTemp) * 182 / 100) + outTempBarOutline.Location.Y;
                outTempBar.Location = new Point(outTempBar.Location.X, Convert.ToInt32(otbLoc));

                Application.DoEvents();

                InTempNum.Text = string.Format("{0} °C", intTemp.ToString());
                inTempBar.Height = Convert.ToInt32(intTemp) * 182 / 100;
                double itbLoc = inTempBarOutline.Height - (Convert.ToInt32(intTemp) * 182 / 100) + inTempBarOutline.Location.Y;
                inTempBar.Location = new Point(inTempBar.Location.X, Convert.ToInt32(itbLoc));

                
                Application.DoEvents();

                tempHumChart.Series["Humidity"].Points.Add(humidity);
                tempHumChart.Series["Internal Temperature"].Points.Add(intTemp);
                tempHumChart.Series["Outside Temperature"].Points.Add(outTemp);

                Application.DoEvents();
            }

            Application.DoEvents();
        }

        private void serialTextBox_TextChanged(object sender, EventArgs e)
        {
            serialTextBox.SelectionStart = serialTextBox.Text.Length;
            serialTextBox.ScrollToCaret();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            TextWriter txt = new StreamWriter("C:\\Users\\joeso\\Desktop\\SDSU\\compe 491A\\rawdata.txt");
            txt.Write(serialTextBox.Text);
            txt.Close();
        }

        private void labelInnerTemp_Click(object sender, EventArgs e)
        {

        }

        
    }
}
