using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace PID_fine_tuining11_5_2019
{
    public partial class PID : Form
    {
        string indata;
        string datapath = @"";
        string finalspeed = "0";
        string rampduration = "100";
        string outdata = "";
        string motor1state = "0";
        string timestamp;
        int sendtime = 0;
        string speed_ref;               // for speedcurve
        string speed_ave;               //for speedcurve
       

        public PID()
        {
            InitializeComponent();

            /*  PID default values of Speedloop, Iq loop and Id loop   */
            skpbox.Text = "3000";
            skibox.Text = "100";
            skdbox.Text = "0";

            iqkpbox.Text = "2700";
            iqkibox.Text = "2049";
            iqkdbox.Text = "0";

            idkpbox.Text = "2700";
            idkibox.Text = "2049";
            idkdbox.Text = "0";

            timer1.Enabled = true;
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);
            serialPort1.Encoding = Encoding.GetEncoding("GB2312");                              
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void speedcurve_Load(object sender, EventArgs e)
        {
            
        }
        private void speeddiff_Load(object sender, EventArgs e)
        {

        }

        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                indata = serialPort1.ReadLine();
                timestamp = DateTime.UtcNow.ToString("ss.fff", System.Globalization.CultureInfo.InvariantCulture);

                string[] sArray = indata.Split(new char[] { ',' });

                for (int i = 1; i < sArray.Length; i++)
                {
                    if (i == 1)
                    {
                        skp.Text = sArray[1];
                    }
                    else if (i == 2)
                    {
                        ski.Text = sArray[2];
                    }
                    else if (i == 3)
                    {
                        skd.Text = sArray[3];
                    }
                    else if (i == 4)
                    {
                        iqkp.Text = sArray[4];
                    }
                    else if (i == 5)
                    {
                        iqki.Text = sArray[5];
                    }
                    else if (i == 6)
                    {
                        iqkd.Text = sArray[6];
                    }
                    else if (i == 7)
                    {
                        idkp.Text = sArray[7];
                    }
                    else if (i == 8)
                    {
                        idki.Text = sArray[8];
                    }
                    else if (i == 9)
                    {
                        idkd.Text = sArray[9];
                    }
                    else if (i == 10)
                    {
                        rampspeedlabel.Text = sArray[10];
                    }
                    else if (i == 11)
                    {
                        durationlabel.Text = sArray[11];
                    }
                    else if (i == 12)
                    {
                        speed_ref = sArray[12];
                    }
                    else if (i == 13)
                    {
                        speed_ave = sArray[13];
                    }
                }
            }
            
            if (serialPort1.IsOpen && datapath != @"")
            {
                /*  save the received data from STM32 to data.txt file, when the serial port is opened   */
                string appendtext = timestamp + "," + indata + Environment.NewLine;
                System.IO.File.AppendAllText(datapath, appendtext, Encoding.UTF8);          //  create a new data.txt to the path,and write data
            }
        }

        private void SearchAndAddSerialToComboBox(SerialPort MyPort, ComboBox MyBox)
        {                                           /*  add avaiable serial port to comboBox    */
            string[] MyString = new string[20];     /*  up to 20 available serialports display on comboBox1,too many ports add to 
                                                        comboBox1 will bring nagative impact to debugging efficiency    */
            string Buffer;
            MyBox.Items.Clear();                    /*  clear ComboBox  */

            for (int i = 1; i < 10; i++)
            {
                try
                {
                    Buffer = "COM" + i.ToString();
                    MyPort.PortName = Buffer;

                    MyPort.Open();                  //if fail to open, the following code will not execute
                    MyString[i - 1] = Buffer;
                    MyBox.Items.Add(Buffer);        //if serialport open succefully, portname will add to the ComboBox

                    MyPort.Close();                 //serial close
                    MyBox.Text = MyString[i - 1];   //display the last successfully opended serialportname
                }
                catch
                {

                }
            }
        }

        private void PID_Load(object sender, EventArgs e)
        {
            SearchAndAddSerialToComboBox(serialPort1, Portbox);         //  port detection automatically
            baudratebox.Text = "115200";                                //  Initialization of baudrate to 115200
        }

        /*  execute the port detection manually   */
        private void portdetect_Click(object sender, EventArgs e)
        {
            SearchAndAddSerialToComboBox(serialPort1, Portbox);
        }

        /*  open serial port    */
        private void portopen_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = Portbox.Text;                            //Name of the Port read from the TextBox1
                serialPort1.BaudRate = Convert.ToInt32(baudratebox.Text, 10);     //Baudrate, transfer to DEC
                serialPort1.Parity = Parity.None;

                serialPort1.Open();             //Open the SerialPort
                portopen.Enabled = false;        //disable the "connect" botton
                portclose.Enabled = true;         // enable the "disconnect" botton
            }
            catch
            {
                MessageBox.Show("Please check your SerialPort", "Error");
            }
        }

        /*  close serial port   */
        private void portclose_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();            // close the SerialPort
                portopen.Enabled = true;        // Enable the "connect" botton
                portclose.Enabled = false;      // Disable the "disconnect" botton
            }
            catch (Exception err)
            {
                MessageBox.Show("Can not close serial port", "Error");
            }
        }

        /*  trackingbar for PID fine tunning   */
        private void skpbar_Scroll(object sender, EventArgs e)
        {
            skpbox.Text = skpbar.Value.ToString();
        }
        private void skibar_Scroll(object sender, EventArgs e)
        {
            skibox.Text = skibar.Value.ToString();
        }
        private void skdbar_Scroll(object sender, EventArgs e)
        {
            skdbox.Text = skdbar.Value.ToString();
        }
        private void iqkpbar_Scroll(object sender, EventArgs e)
        {
            iqkpbox.Text = iqkpbar.Value.ToString();
        }
        private void iqkibar_Scroll(object sender, EventArgs e)
        {
            iqkibox.Text = iqkibar.Value.ToString();
        }
        private void iqkdbar_Scroll(object sender, EventArgs e)
        {
            iqkdbox.Text = iqkdbar.Value.ToString();
        }
        private void idkpbar_Scroll(object sender, EventArgs e)
        {
            idkpbox.Text = idkpbar.Value.ToString();
        }
        private void idkibar_Scroll(object sender, EventArgs e)
        {
            idkibox.Text = idkibar.Value.ToString();
        }
        private void idkdbar_Scroll(object sender, EventArgs e)
        {
            idkdbox.Text = idkdbar.Value.ToString();
        }

        /*  Motor Start */
        private void run_Click(object sender, EventArgs e)
        {
            motor1state = "4";
            run.Enabled = false;
            stop.Enabled = true;

            if (skpbox.Text != "" && skibox.Text != "" && skdbox.Text != "")
            {
                if (serialPort1.IsOpen)
                {
                    /*  Makes sure serial port is open before trying to write   */
                    try
                    {
                        serialPort1.WriteLine(outdata);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error by <Run>", "Error");
                    }
                }
            }

            if ( finalspeed != "0" && finalspeed != "")
            {
                speedcurve.ValueMaxLeft = Convert.ToInt32(finalspeed)*110/100;
                speedcurve.ValueMaxRight = Convert.ToInt32(finalspeed)*110/100;

                speeddiff.ValueMaxLeft = Convert.ToInt32(finalspeed);
                speeddiff.ValueMinLeft = -Convert.ToInt32(finalspeed);

                speedcurve.SetLeftCurve("A", new float[] { }, Color.Blue);         // speed_reference
                speedcurve.SetLeftCurve("B", new float[] { }, Color.Green);        // speed_average

                speeddiff.SetLeftCurve("A", new float[] { }, Color.Blue);         // speed_difference[rpm]
                speeddiff.SetLeftCurve("B", new float[] { }, Color.Green);        // speed_diff[%]

                timer2.Tick += (sender1, e1) =>
                {
                    speedcurve.AddCurveData(
                        new string[] { "A", "B" },
                        new float[] { Convert.ToInt32(speed_ref), Convert.ToInt32(speed_ave) });

                    if (Convert.ToInt32(speed_ref) > 1)                                
                    {
                        speeddiff.AddCurveData(
                        new string[] { "A", "B" },
                        new float[] { Convert.ToInt32(speed_ave) - Convert.ToInt32(speed_ref), (Convert.ToInt32(speed_ave) - Convert.ToInt32(speed_ref)) / Convert.ToInt32(speed_ref) });
                    }
                };
                timer2.Start();
            }
        }

        /*  Motor Stop  */
        private void stop_Click(object sender, EventArgs e)
        {
            motor1state = "8";
            run.Enabled = true;
            stop.Enabled = false;

            if (skpbox.Text != "" && skibox.Text != "" && skdbox.Text != "")
            {
                if (serialPort1.IsOpen)
                {
                    /*  Makes sure serial port is open before trying to write   */
                    try
                    {
                        serialPort1.WriteLine(outdata);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error by Stop", "Error");
                    }
                }
            }
            timer2.Stop();
        }

        /*  Transmit string to Arduino DUE    */
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            outdata = motor1state + "," + skpbox.Text + "," + skibox.Text + "," + skdbox.Text + "," + iqkpbox.Text + "," +
                      iqkibox.Text + "," + iqkdbox.Text + "," + idkpbox.Text + "," + idkibox.Text + "," + idkdbox.Text + "," + finalspeed + "," + rampduration;

            if (serialPort1.IsOpen)
            {
                sendtime++;
                try
                {
                    if (sendtime == 5)                          //every sendtime = 5ms send the data to Arduino Due
                    {
                        serialPort1.WriteLine(outdata);
                        sendtime = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Data sending error", "Error");
                }
            }

        }

        /*  set path to save received data  */
        private void datapath_Click(object sender, EventArgs e)
        {
            if (datapathbox.Text != "")                                         //  if datapathebox is not empty
            {
                datapath = String.Concat(datapathbox.Text, @"\data.txt");       
                System.IO.File.Delete(datapath);                                //  delete the data.txt file on this path first
            }
            else
            {
                MessageBox.Show("Please enter a valid path", "Error");
            }
        }

        /*  set RampFinalSpeed  */
        private void rampfinalspeed_Scroll(object sender, EventArgs e)
        {
            rampspeedbox.Text = rampfinalspeed.Value.ToString();
            finalspeed = rampspeedbox.Text;
        }
        /*  set Ramp Duration(ms)   */
        private void durationyes_Click(object sender, EventArgs e)
        {
            if (durationbox.Text != "")
            {
                rampduration = durationbox.Text;
            }
            else
            {
                MessageBox.Show("Please enter duration time", "Error");
            }
        }


    }
}
