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

namespace ArduinoApp1 
{
    public partial class MainWin : Form
    {
        SerialPort ArduinoP = new SerialPort();
        System.Timers.Timer timerServo = new System.Timers.Timer();
        string[] ports;

        public MainWin()
        {
            InitializeComponent();

            ports = SerialPort.GetPortNames();
            portBox.Items.AddRange(ports);
            portBo.Items.AddRange(ports);

            timerServo.Interval = 5000;
            timerServo.Elapsed += this.timer_Tick;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            this.maskedTextBox1.Text = trackBar1.Value.ToString();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            this.maskedTextBox2.Text = trackBar2.Value.ToString();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            this.maskedTextBox3.Text = trackBar3.Value.ToString();
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            this.maskedTextBox4.Text = trackBar4.Value.ToString();
        }

        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            this.maskedTextBox5.Text = trackBar5.Value.ToString();
        }

        private void trackBar6_Scroll(object sender, EventArgs e)
        {
            this.maskedTextBox6.Text = trackBar6.Value.ToString();
        }

        private void trackBar7_Scroll(object sender, EventArgs e)
        {
            this.maskedTextBox7.Text = trackBar7.Value.ToString();
        }

        private void trackBar8_Scroll(object sender, EventArgs e)
        {
            this.maskedTextBox8.Text = trackBar8.Value.ToString();
        }

        private void trackBar9_Scroll(object sender, EventArgs e)
        {
            this.maskedTextBox9.Text = trackBar9.Value.ToString();
        }

        private void trackBar10_Scroll(object sender, EventArgs e)
        {
            this.maskedTextBox10.Text = trackBar10.Value.ToString();
        }

        private void degBox_1_valchange(object sender, EventArgs e)
        {
            if (int.Parse(maskedTextBox1.Text) <= 180 && int.Parse(maskedTextBox1.Text) >= 0)
            {
                trackBar1.Value = int.Parse(maskedTextBox1.Text);
            }
            else
            {
                status.Text = "Servo degree value should be between 0 and 180!";
                timerServo.Start();
            }
        }

        private void timer_Tick(object sender, System.Timers.ElapsedEventArgs e)
        {
            try
            {
                if (ArduinoP.IsOpen)
                {
                    status.Text = "Connected with Arduno on specified COM port.";
                }
                else
                {
                    status.Text = "Disconnected from Arduino. Press \"Connect to Arduino\" to connect to the Arduino on specified COM port.";
                }
            }
            catch (Exception)
            {
                
            }
            finally
            {
                timerServo.Stop();
            }
        }

        private void degBox_2_valchange(object sender, EventArgs e)
        {
            if (int.Parse(maskedTextBox2.Text) <= 180 && int.Parse(maskedTextBox2.Text) >= 0)
            {
                trackBar2.Value = int.Parse(maskedTextBox2.Text);
            }
            else
            {
                status.Text = "Servo degree value should be between 0 and 180!";
                timerServo.Start();
            }
        }

        private void degBox_3_valchange(object sender, EventArgs e)
        {
            if (int.Parse(maskedTextBox3.Text) <= 180 && int.Parse(maskedTextBox3.Text) >= 0)
            {
                trackBar3.Value = int.Parse(maskedTextBox3.Text);
            }
            else
            {
                status.Text = "Servo degree value should be between 0 and 180!";
                timerServo.Start();
            }
        }

        private void degBox_4_valchange(object sender, EventArgs e)
        {
            if (int.Parse(maskedTextBox4.Text) <= 180 && int.Parse(maskedTextBox4.Text) >= 0)
            {
                trackBar4.Value = int.Parse(maskedTextBox4.Text);
            }
            else
            {
                status.Text = "Servo degree value should be between 0 and 180!";
                timerServo.Start();
            }
        }

        private void degBox_5_valchange(object sender, EventArgs e)
        {
            if (int.Parse(maskedTextBox5.Text) <= 180 && int.Parse(maskedTextBox5.Text) >= 0)
            {
                trackBar5.Value = int.Parse(maskedTextBox5.Text);
            }
            else
            {
                status.Text = "Servo degree value should be between 0 and 180!";
                timerServo.Start();
            }
        }

        private void degBox_6_valchange(object sender, EventArgs e)
        {
            if (int.Parse(maskedTextBox6.Text) <= 180 && int.Parse(maskedTextBox6.Text) >= 0)
            {
                trackBar6.Value = int.Parse(maskedTextBox6.Text);
            }
            else
            {
                status.Text = "Servo degree value should be between 0 and 180!";
                timerServo.Start();
            }
        }

        private void degBox_7_valchange(object sender, EventArgs e)
        {
            if (int.Parse(maskedTextBox7.Text) <= 180 && int.Parse(maskedTextBox7.Text) >= 0)
            {
                trackBar7.Value = int.Parse(maskedTextBox7.Text);
            }
            else
            {
                status.Text = "Servo degree value should be between 0 and 180!";
                timerServo.Start();
            }
        }

        private void degBox_8_valchange(object sender, EventArgs e)
        {
            if (int.Parse(maskedTextBox8.Text) <= 180 && int.Parse(maskedTextBox8.Text) >= 0)
            {
                trackBar8.Value = int.Parse(maskedTextBox8.Text);
            }
            else
            {
                status.Text = "Servo degree value should be between 0 and 180!";
                timerServo.Start();
            }
        }

        private void degBox_9_valchange(object sender, EventArgs e)
        {
            if (int.Parse(maskedTextBox9.Text) <= 180 && int.Parse(maskedTextBox9.Text) >= 0)
            {
                trackBar9.Value = int.Parse(maskedTextBox9.Text);
            }
            else
            {
                status.Text = "Servo degree value should be between 0 and 180!";
                timerServo.Start();
            }
        }

        private void degBox_10_valchange(object sender, EventArgs e)
        {
            if (int.Parse(maskedTextBox10.Text) <= 180 && int.Parse(maskedTextBox10.Text) >= 0)
            {
                trackBar10.Value = int.Parse(maskedTextBox10.Text);
            }
            else
            {
                status.Text = "Servo degree value should be between 0 and 180!";
                timerServo.Start();
            }
        }

        private void connect_ard_Click(object sender, EventArgs e)
        {
            connect_ard.Enabled = false;
            connect_ard_m.Enabled = false;
            updatePos.Enabled = true;
            center_servos.Enabled = true;
            disconnect_ard.Enabled = true;
            portBox.Enabled = false;
            
            try
            {
                if (ArduinoP.IsOpen == true)
                {
                    status.Text = "Already connected to Arduino on " + portBox.SelectedText + "!";
                    timerServo.Start();
                }
                else
                {
                    if (portBox.SelectedItem.ToString() != "")
                    {
                        ArduinoP.NewLine = "";
                        ArduinoP.PortName = ports[portBox.SelectedIndex];
                        ArduinoP.Open();
                        status.Text = "Connected with Arduno on specified COM port.";
                    }
                    else if (portBox.SelectedItem.ToString() == "")
                    {
                        status.Text = "Please specify the COM port of the Arduino to connect to and then try again.";
                        connect_ard.Enabled = true;
                        updatePos.Enabled = false;
                        center_servos.Enabled = false;
                        disconnect_ard.Enabled = false;
                        portBox.Enabled = true;
                        timerServo.Start();
                    }
                }
            }
            catch (Exception ex)
            {
                status.Text = "Not able to connect to Arduino! Try again please.";
                connect_ard.Enabled = true;
                connect_ard_m.Enabled = true;
                updatePos.Enabled = false;
                center_servos.Enabled = false;
                disconnect_ard.Enabled = false;
                portBox.Enabled = true;
                timerServo.Start();
                Console.Write(ex.ToString());
            }
            finally
            {
                if (ArduinoP.IsOpen)
                {
                    connect_ard.Enabled = false;
                    connect_ard_m.Enabled = false;
                    updatePos.Enabled = true;
                    center_servos.Enabled = true;
                    disconnect_ard.Enabled = true;
                }
                else
                {
                    connect_ard.Enabled = true;
                    connect_ard_m.Enabled = true;
                    updatePos.Enabled = false;
                    center_servos.Enabled = false;
                    disconnect_ard.Enabled = false;
                }
            }
        }

        private void center_servos_Click(object sender, EventArgs e)
        {
            try
            {
                if (ArduinoP.IsOpen)
                {
                    ArduinoP.WriteLine("90,90,90,90,90,90,90,90,90,90");
                }
                else
                {
                    status.Text = "Data connection is disconnected!";
                }
            }
            catch (Exception)
            {
                status.Text = "Not able to send data to Arduino! Check data connection.";
            }
        }

        private void disconnect_ard_Click(object sender, EventArgs e)
        {
            try
            {
                if (ArduinoP.IsOpen)
                {
                    ArduinoP.Close();
                    status.Text = "Disconnected from Arduino. Press \"Connect to Arduino\" to connect to the Arduino on specified COM port.";
                }
                else
                {
                    status.Text = "Already disconnected from Arduino! Press to connect again.";
                }
            }
            catch (System.IO.IOException)
            {
                status.Text = "Unable to disconnect from Arduino! Please try again!";
            }
        }

        private void exit_app_Click(object sender, EventArgs e)
        {
            try
            {
                if (ArduinoP.IsOpen)
                    ArduinoP.Close();
                this.Close();
            }
            catch (Exception)
            {
                timerServo.Dispose();
                timerServo.Close();
                this.Close();
            }
            finally
            {
                timerServo.Dispose();
                timerServo.Close();
                this.Close();
            }
        }

        private void updatePos_Click(object sender, EventArgs e)
        {
            try
            {
                ArduinoP.WriteLine(maskedTextBox1 + "," + maskedTextBox2 + "," + maskedTextBox3 + "," + maskedTextBox4 + ","
                        + maskedTextBox5 + "," + maskedTextBox6 + "," + maskedTextBox7 + "," + maskedTextBox8 + "," + maskedTextBox9
                        + "," + maskedTextBox10);
                char[] ret = { ' ' };
                char[] ack = { 'A', 'C', 'K' };
                int success = ArduinoP.Read(ret, 0, 3);
                if (success >= 3)
                {
                    if (ret.Equals(ack))
                    {
                        status.Text = "Servo positions successfully updated!";
                        timerServo.Start();
                    }
                    else
                    {
                        status.Text = "Unable to update servo positions! Please check connection and try again!";
                        timerServo.Start();
                    }
                }
            }
            catch (Exception)
            {
                status.Text = "Unable to communicate with Arduino! Please re-check the connection.";
            }
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox1 abt = new AboutBox1();
            abt.Show(this);
        }

        private void portBox_qeyDaoon(object sender, KeyEventArgs e)
        {
            portBox.Text = "";
        }

        private void portBox_qeyDaoon(object sender, KeyPressEventArgs e)
        {
            portBox.Text = "";
        }

        private void portBox_textChange(object sender, EventArgs e)
        {
            int index = portBox.SelectedIndex;
            portBo.SelectedIndex = index;
        }

        private void portBo_DropDownClosed(object sender, EventArgs e)
        {
            int index = portBo.SelectedIndex;
            portBox.SelectedIndex = index;
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox2 help = new AboutBox2();
            help.Show(this);
        }

     }
}
