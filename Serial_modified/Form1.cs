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
using System.Threading;
using System.Text.RegularExpressions;

namespace BatteryBuddy
{


    public partial class Form1 : Form
    {
        public delegate void AddDataDelegate(String[] myString);
        public AddDataDelegate myDelegate;
        int count = 1;
        int flag = 0;
        int exit_flag = 0;

        public Form1()
        {
            InitializeComponent();
            getAvailableports();
            this.myDelegate = new AddDataDelegate(AddDataMethod);
            this.FormClosing += Form1_FormClosing;
        }
        void getAvailableports()
        {
            String[] ports = SerialPort.GetPortNames();
            comport.Items.AddRange(ports);
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(func_datareceived);
        }
        public void AddDataMethod(String[] myString)
        {
            try
            {
                if (exit_flag == 1)
                {
                    if (myString[0] == "Voltages:")
                    {
                        textBox1.Clear();
                        textBox1.AppendText(myString[1]);
                        textBox2.Clear();
                        textBox2.AppendText(myString[2]);
                        textBox3.Clear();
                        textBox3.AppendText(myString[3]);
                        textBox4.Clear();
                        textBox4.AppendText(myString[4]);
                        textBox5.Clear();
                        textBox5.AppendText(myString[5]);
                        textBox6.Clear();
                        textBox6.AppendText(myString[6]);
                        textBox7.Clear();
                        textBox7.AppendText(myString[7]);
                        textBox8.Clear();
                        textBox8.AppendText(myString[8]);
                        textBox9.Clear();
                        textBox9.AppendText(myString[9]);
                        textBox10.Clear();
                        textBox10.AppendText(myString[10]);
                        textBox11.Clear();
                        textBox11.AppendText(myString[11]);
                        textBox12.Clear();
                        textBox12.AppendText(myString[12]);
                        textBox13.Clear();
                        textBox13.AppendText(myString[13]);
                        //////////////////////////////////////
                        textBox26.Clear();
                        textBox26.AppendText(myString[1]);
                        textBox27.Clear();
                        textBox27.AppendText(myString[2]);
                        textBox28.Clear();
                        textBox28.AppendText(myString[3]);
                        textBox29.Clear();
                        textBox29.AppendText(myString[4]);
                        textBox30.Clear();
                        textBox30.AppendText(myString[5]);
                        textBox31.Clear();
                        textBox31.AppendText(myString[6]);
                        textBox32.Clear();
                        textBox32.AppendText(myString[7]);
                        textBox33.Clear();
                        textBox33.AppendText(myString[8]);
                        textBox34.Clear();
                        textBox34.AppendText(myString[9]);
                        textBox35.Clear();
                        textBox35.AppendText(myString[10]);
                        textBox36.Clear();
                        textBox36.AppendText(myString[11]);
                        textBox37.Clear();
                        textBox37.AppendText(myString[12]);
                        textBox38.Clear();
                        textBox38.AppendText(myString[13]);
                        //////////////////////////////////////

                        float sum = float.Parse(myString[1]) + float.Parse(myString[2]) + float.Parse(myString[3]) + float.Parse(myString[4]) + float.Parse(myString[5]) + float.Parse(myString[6]) + float.Parse(myString[7]) + float.Parse(myString[8]) + float.Parse(myString[9]) + float.Parse(myString[10]) + float.Parse(myString[11]) + float.Parse(myString[12]) + float.Parse(myString[13]);
                        ////////////////////////////////////////////////////////////////////////////////////////////
                        pictureBox9.Visible = true;
                        pictureBox2.Visible = true;
                        pictureBox5.Visible = true;
                        pictureBox11.Visible = true;
                        pictureBox14.Visible = true;
                        pictureBox17.Visible = true;
                        pictureBox20.Visible = true;
                        pictureBox23.Visible = true;
                        pictureBox26.Visible = true;
                        pictureBox29.Visible = true;
                        pictureBox32.Visible = true;
                        pictureBox35.Visible = true;
                        pictureBox38.Visible = true;

                        pictureBox9.Height = 200 - 2 * (int)Math.Ceiling(((float.Parse(myString[1]) - 2.8) / (4.23 - 2.8)) * 100); //1
                        pictureBox2.Height = 200 - 2 * (int)Math.Ceiling(((float.Parse(myString[2]) - 2.8) / (4.23 - 2.8)) * 100); //2
                        pictureBox5.Height = 200 - 2 * (int)Math.Ceiling(((float.Parse(myString[3]) - 2.8) / (4.23 - 2.8)) * 100); //3
                        pictureBox11.Height = 200 - 2 * (int)Math.Ceiling(((float.Parse(myString[4]) - 2.8) / (4.23 - 2.8)) * 100); //4
                        pictureBox14.Height = 200 - 2 * (int)Math.Ceiling(((float.Parse(myString[5]) - 2.8) / (4.23 - 2.8)) * 100); //5
                        pictureBox17.Height = 200 - 2 * (int)Math.Ceiling(((float.Parse(myString[6]) - 2.8) / (4.23 - 2.8)) * 100); //6
                        pictureBox20.Height = 200 - 2 * (int)Math.Ceiling(((float.Parse(myString[7]) - 2.8) / (4.23 - 2.8)) * 100); //7
                        pictureBox23.Height = 200 - 2 * (int)Math.Ceiling(((float.Parse(myString[8]) - 2.8) / (4.23 - 2.8)) * 100); //8
                        pictureBox26.Height = 200 - 2 * (int)Math.Ceiling(((float.Parse(myString[9]) - 2.8) / (4.23 - 2.8)) * 100); //9
                        pictureBox29.Height = 200 - 2 * (int)Math.Ceiling(((float.Parse(myString[10]) - 2.8) / (4.23 - 2.8)) * 100); //10
                        pictureBox32.Height = 200 - 2 * (int)Math.Ceiling(((float.Parse(myString[11]) - 2.8) / (4.23 - 2.8)) * 100); //11
                        pictureBox35.Height = 200 - 2 * (int)Math.Ceiling(((float.Parse(myString[12]) - 2.8) / (4.23 - 2.8)) * 100); //12
                        pictureBox38.Height = 200 - 2 * (int)Math.Ceiling(((float.Parse(myString[13]) - 2.8) / (4.23 - 2.8)) * 100); //13
                                                                                                                                    ////////////////////////////////////////////////////////////////////////////////////////////
                        textBox23.Clear();
                        textBox23.AppendText(Convert.ToString(sum));
                        this.chart1.ChartAreas[0].AxisY.Maximum = 4.5;
                        this.chart1.ChartAreas[0].AxisY.Minimum = 2.8;
                        this.chart1.ChartAreas[0].AxisX.Interval = 0.5;
                        this.chart1.Titles["Title1"].Name.Equals("Cell voltages");
                        this.chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
                        this.chart1.ChartAreas[0].AxisY.MinorGrid.Enabled = false;
                        this.chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                        this.chart1.ChartAreas[0].AxisX.MinorGrid.Enabled = false;
                        this.chart1.Series["batvol"].Points.Clear();
                        this.chart1.Series["batvol"].Points.AddXY("Cell 1", Convert.ToDecimal(myString[1]));
                        this.chart1.Series["batvol"].Points.AddXY("Cell 2", Convert.ToDecimal(myString[2]));
                        this.chart1.Series["batvol"].Points.AddXY("Cell 3", Convert.ToDecimal(myString[3]));
                        this.chart1.Series["batvol"].Points.AddXY("Cell 4", Convert.ToDecimal(myString[4]));
                        this.chart1.Series["batvol"].Points.AddXY("Cell 5", Convert.ToDecimal(myString[5]));
                        this.chart1.Series["batvol"].Points.AddXY("Cell 6", Convert.ToDecimal(myString[6]));
                        this.chart1.Series["batvol"].Points.AddXY("Cell 7", Convert.ToDecimal(myString[7]));
                        this.chart1.Series["batvol"].Points.AddXY("Cell 8", Convert.ToDecimal(myString[8]));
                        this.chart1.Series["batvol"].Points.AddXY("Cell 9", Convert.ToDecimal(myString[9]));
                        this.chart1.Series["batvol"].Points.AddXY("Cell 10", Convert.ToDecimal(myString[10]));
                        this.chart1.Series["batvol"].Points.AddXY("Cell 11", Convert.ToDecimal(myString[11]));
                        this.chart1.Series["batvol"].Points.AddXY("Cell 12", Convert.ToDecimal(myString[12]));
                        this.chart1.Series["batvol"].Points.AddXY("Cell 13", Convert.ToDecimal(myString[13]));
                        flag = 1;
                    }
                    else if (myString[0] == "Current:")
                    {
                        textBox15.Clear();
                        textBox15.AppendText(myString[1]);
                        textBox42.Clear();
                        textBox42.AppendText(myString[1]);
                        this.chart2.Series["current"].Points.AddXY(count++, (myString[1]));
                        if (float.Parse(myString[1]) > -0.2 || float.Parse(myString[1]) < 0.2)
                        {
                            textBox25.Clear();
                            textBox25.AppendText("IDLE");
                        }
                        if (float.Parse(myString[1]) > 0.2)
                        {
                            textBox25.Clear();
                            textBox25.AppendText("CHARGING");
                        }
                        if (float.Parse(myString[1]) < -0.2)
                        {
                            textBox25.Clear();
                            textBox25.AppendText("DISCHARGING");
                        }

                    }
                    else if (myString[0] == "Temperature:")
                    {
                        textBox19.Clear();
                        textBox19.AppendText(myString[1]);
                        textBox20.Clear();
                        textBox20.AppendText(myString[2]);
                        textBox21.Clear();
                        textBox21.AppendText(myString[3]);
                        textBox22.Clear();
                        textBox22.AppendText(myString[1]);
                    }
                    else if (myString[0] == "Battery")
                    {
                        textBox16.Clear();
                        textBox16.AppendText(myString[2]);
                        textBox41.Clear();
                        textBox41.AppendText(myString[2]);
                    }
                    else if (myString[0] == "Total")
                    {
                        textBox24.Clear();
                        textBox24.AppendText(myString[2]);
                    }
                    else if (myString[0] == "Discharging")
                    {
                        if (myString[2] == "ON")
                        {
                            textBox17.Clear();
                            textBox17.AppendText("YES");
                            textBox40.Clear();
                            textBox40.AppendText("YES");
                        }
                        else
                        {
                            textBox17.Clear();
                            textBox17.AppendText("NO");
                            textBox40.Clear();
                            textBox40.AppendText("NO");
                        }

                    }
                    else if (myString[0] == "Charging")
                    {
                        if (myString[2] == "ON")
                        {
                            textBox18.Clear();
                            textBox18.AppendText("YES");
                            textBox39.Clear();
                            textBox39.AppendText("YES");

                        }
                        else
                        {
                            textBox18.Clear();
                            textBox18.AppendText("NO");
                            textBox39.Clear();
                            textBox39.AppendText("NO");
                        }


                    }
                    else if (myString[0] == "Health:")
                    {
                        textBox56.Clear();
                        textBox56.AppendText(myString[1]);
                    }
                    else if (myString[0] == "OC_TC_SC:")
                    {
                        textBox58.Clear();
                        textBox58.AppendText(myString[1]);
                        textBox59.Clear();
                        textBox59.AppendText(myString[3]);
                        textBox60.Clear();
                        textBox60.AppendText(myString[2]);
                    }
                    else if (myString[0] == "Balancing:")
                    {
                        text1.Clear();
                        text1.AppendText("OFF");
                        text1.BackColor = Color.LightPink;
                        text2.Clear();
                        text2.AppendText("OFF");
                        text2.BackColor = Color.LightPink;
                        text3.Clear();
                        text3.AppendText("OFF");
                        text3.BackColor = Color.LightPink;
                        text4.Clear();
                        text4.AppendText("OFF");
                        text4.BackColor = Color.LightPink;
                        text5.Clear();
                        text5.AppendText("OFF");
                        text5.BackColor = Color.LightPink;
                        text6.Clear();
                        text6.AppendText("OFF");
                        text6.BackColor = Color.LightPink;
                        text7.Clear();
                        text7.AppendText("OFF");
                        text7.BackColor = Color.LightPink;
                        text8.Clear();
                        text8.AppendText("OFF");
                        text8.BackColor = Color.LightPink;
                        text9.Clear();
                        text9.AppendText("OFF");
                        text9.BackColor = Color.LightPink;
                        text10.Clear();
                        text10.AppendText("OFF");
                        text10.BackColor = Color.LightPink;
                        text11.Clear();
                        text11.AppendText("OFF");
                        text11.BackColor = Color.LightPink;
                        text12.Clear();
                        text12.AppendText("OFF");
                        text12.BackColor = Color.LightPink;
                        text13.Clear();
                        text13.AppendText("OFF");
                        text13.BackColor = Color.LightPink;
                        if (myString[1] == "NONE")
                        {
                            text1.Clear();
                            text1.AppendText("OFF");
                            text1.BackColor = Color.LightPink;
                            text2.Clear();
                            text2.AppendText("OFF");
                            text2.BackColor = Color.LightPink;
                            text3.Clear();
                            text3.AppendText("OFF");
                            text3.BackColor = Color.LightPink;
                            text4.Clear();
                            text4.AppendText("OFF");
                            text4.BackColor = Color.LightPink;
                            text5.Clear();
                            text5.AppendText("OFF");
                            text5.BackColor = Color.LightPink;
                            text6.Clear();
                            text6.AppendText("OFF");
                            text6.BackColor = Color.LightPink;
                            text7.Clear();
                            text7.AppendText("OFF");
                            text7.BackColor = Color.LightPink;
                            text8.Clear();
                            text8.AppendText("OFF");
                            text8.BackColor = Color.LightPink;
                            text9.Clear();
                            text9.AppendText("OFF");
                            text9.BackColor = Color.LightPink;
                            text10.Clear();
                            text10.AppendText("OFF");
                            text10.BackColor = Color.LightPink;
                            text11.Clear();
                            text11.AppendText("OFF");
                            text11.BackColor = Color.LightPink;
                            text12.Clear();
                            text12.AppendText("OFF");
                            text12.BackColor = Color.LightPink;
                            text13.Clear();
                            text13.AppendText("OFF");
                            text13.BackColor = Color.LightPink;
                            ////////////////////////////////////
                            textBox43.Clear();
                            textBox44.Clear();
                            textBox45.Clear();
                            textBox46.Clear();
                            textBox47.Clear();
                            textBox48.Clear();
                            textBox49.Clear();
                            textBox50.Clear();
                            textBox51.Clear();
                            textBox52.Clear();
                            textBox53.Clear();
                            textBox54.Clear();
                            textBox55.Clear();

                            ////////////////////////////////////
                        }
                        else
                        {
                            int lenght = myString.Length;
                            for (int i = 1; i < lenght; i++)
                            {
                                textBox43.Clear();
                                textBox44.Clear();
                                textBox45.Clear();
                                textBox46.Clear();
                                textBox47.Clear();
                                textBox48.Clear();
                                textBox49.Clear();
                                textBox50.Clear();
                                textBox51.Clear();
                                textBox52.Clear();
                                textBox53.Clear();
                                textBox54.Clear();
                                textBox55.Clear();
                                if ((myString[i]) == "1")
                                {
                                    text1.Clear();
                                    text1.AppendText("ON");
                                    text1.BackColor = Color.LightSeaGreen;

                                    textBox55.Clear();
                                    textBox55.AppendText("BALANCING!");
                                    textBox55.ForeColor = Color.Red;
                                    if (flag == 1)
                                        this.chart1.Series["batvol"].Points[0].Color = Color.LightGreen;


                                }
                                else if (myString[i] == "2")
                                {
                                    text2.Clear();
                                    text2.AppendText("ON");
                                    text2.BackColor = Color.LightSeaGreen;
                                    textBox54.Clear();
                                    textBox54.AppendText("BALANCING!");
                                    textBox54.ForeColor = Color.Red;
                                    if (flag == 1)
                                        this.chart1.Series["batvol"].Points[1].Color = Color.LightGreen;
                                }
                                else if (myString[i] == "3")
                                {
                                    text3.Clear();
                                    text3.AppendText("ON");
                                    text3.BackColor = Color.LightSeaGreen;
                                    textBox53.Clear();
                                    textBox53.AppendText("BALANCING!");
                                    textBox53.ForeColor = Color.Red;
                                    if (flag == 1)
                                        this.chart1.Series["batvol"].Points[2].Color = Color.LightGreen;
                                }
                                else if (myString[i] == "4")
                                {
                                    text4.Clear();
                                    text4.AppendText("ON");
                                    text4.BackColor = Color.LightSeaGreen;
                                    textBox52.Clear();
                                    textBox52.AppendText("BALANCING!");
                                    textBox52.ForeColor = Color.Red;
                                    if (flag == 1)
                                        this.chart1.Series["batvol"].Points[3].Color = Color.LightGreen;
                                }
                                else if (myString[i] == "5")
                                {
                                    text5.Clear();
                                    text5.AppendText("ON");
                                    text5.BackColor = Color.LightSeaGreen;
                                    textBox51.Clear();
                                    textBox51.AppendText("BALANCING!");
                                    textBox51.ForeColor = Color.Red;
                                    if (flag == 1)
                                        this.chart1.Series["batvol"].Points[4].Color = Color.LightGreen;
                                }
                                else if (myString[i] == "6")
                                {
                                    text6.Clear();
                                    text6.AppendText("ON");
                                    text6.BackColor = Color.LightSeaGreen;
                                    textBox50.Clear();
                                    textBox50.AppendText("BALANCING!");
                                    textBox50.ForeColor = Color.Red;
                                    if (flag == 1)
                                        this.chart1.Series["batvol"].Points[5].Color = Color.LightGreen;
                                }
                                else if (myString[i] == "7")
                                {
                                    text7.Clear();
                                    text7.AppendText("ON");
                                    text7.BackColor = Color.LightSeaGreen;
                                    textBox49.Clear();
                                    textBox49.AppendText("BALANCING!");
                                    textBox49.ForeColor = Color.Red;
                                    if (flag == 1)
                                        this.chart1.Series["batvol"].Points[6].Color = Color.LightGreen;
                                }
                                else if (myString[i] == "8")
                                {
                                    text8.Clear();
                                    text8.AppendText("ON");
                                    text8.BackColor = Color.LightSeaGreen;
                                    textBox48.Clear();
                                    textBox48.AppendText("BALANCING!");
                                    textBox48.ForeColor = Color.Red;
                                    if (flag == 1)
                                        this.chart1.Series["batvol"].Points[7].Color = Color.LightGreen;
                                }
                                else if (myString[i] == "9")
                                {
                                    text9.Clear();
                                    text9.AppendText("ON");
                                    text9.BackColor = Color.LightSeaGreen;
                                    textBox47.Clear();
                                    textBox47.AppendText("BALANCING!");
                                    textBox47.ForeColor = Color.Red;
                                    if (flag == 1)
                                        this.chart1.Series["batvol"].Points[8].Color = Color.LightGreen;
                                }
                                else if (myString[i] == "10")
                                {
                                    text10.Clear();
                                    text10.AppendText("ON");
                                    text10.BackColor = Color.LightSeaGreen;
                                    textBox46.Clear();
                                    textBox46.AppendText("BALANCING!");
                                    textBox46.ForeColor = Color.Red;
                                    if (flag == 1)
                                        this.chart1.Series["batvol"].Points[9].Color = Color.LightGreen;
                                }
                                else if (myString[i] == "11")
                                {
                                    text11.Clear();
                                    text11.AppendText("ON");
                                    text11.BackColor = Color.LightSeaGreen;
                                    textBox45.Clear();
                                    textBox45.AppendText("BALANCING!");
                                    textBox45.ForeColor = Color.Red;
                                    if (flag == 1)
                                        this.chart1.Series["batvol"].Points[10].Color = Color.LightGreen;
                                }
                                else if (myString[i] == "12")
                                {
                                    text12.Clear();
                                    text12.AppendText("ON");
                                    text12.BackColor = Color.LightSeaGreen;
                                    textBox44.Clear();
                                    textBox44.AppendText("BALANCING!");
                                    textBox44.ForeColor = Color.Red;
                                    if (flag == 1)
                                        this.chart1.Series["batvol"].Points[11].Color = Color.LightGreen;
                                }
                                else if (myString[i] == "13")
                                {
                                    text13.Clear();
                                    text13.AppendText("ON");
                                    text13.BackColor = Color.LightSeaGreen;
                                    textBox43.Clear();
                                    textBox43.AppendText("BALANCING!");
                                    textBox43.ForeColor = Color.Red;
                                    if (flag == 1)
                                        this.chart1.Series["batvol"].Points[12].Color = Color.LightGreen;
                                }

                            }
                        }
                    }
                }
            }
            catch (System.IO.IOException)
            {
                serialPort1.Dispose();
                serialPort1.Close();
                exit_flag = 0;
                GC.Collect();
            }
            catch (System.ObjectDisposedException)
            {
                serialPort1.Dispose();
                serialPort1.Close();
                exit_flag = 0;
                GC.Collect();
            }
            catch(System.FormatException)
            {
                serialPort1.Dispose();
                serialPort1.Close();
                exit_flag = 0;
                GC.Collect();
            }
            catch(System.IndexOutOfRangeException)
            {
                serialPort1.Dispose();
                serialPort1.Close();
                exit_flag = 0;
                GC.Collect();
            }
        }

        private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            throw new NotImplementedException();
        }

        void func_datareceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                if (exit_flag == 1)
                {
                    string data = serialPort1.ReadLine();
                    Console.WriteLine("read " + data);
                    string[] data_parsed = data.Split(' ');
                    if (data_parsed[0] == "Voltages:")
                    {
                        if(data_parsed.Length == 15)
                        {
                            textBox1.Invoke(this.myDelegate, new Object[] { data_parsed });
                            textBox2.Invoke(this.myDelegate, new Object[] { data_parsed });
                            textBox3.Invoke(this.myDelegate, new Object[] { data_parsed });
                            textBox4.Invoke(this.myDelegate, new Object[] { data_parsed });
                            textBox5.Invoke(this.myDelegate, new Object[] { data_parsed });
                            textBox6.Invoke(this.myDelegate, new Object[] { data_parsed });
                            textBox7.Invoke(this.myDelegate, new Object[] { data_parsed });
                            textBox8.Invoke(this.myDelegate, new Object[] { data_parsed });
                            textBox9.Invoke(this.myDelegate, new Object[] { data_parsed });
                            textBox10.Invoke(this.myDelegate, new Object[] { data_parsed });
                            textBox11.Invoke(this.myDelegate, new Object[] { data_parsed });
                            textBox12.Invoke(this.myDelegate, new Object[] { data_parsed });
                            textBox13.Invoke(this.myDelegate, new Object[] { data_parsed });
                            Console.WriteLine("lenght" + data_parsed.Length);
                        }
                        Console.WriteLine("lenght" + data_parsed.Length);

                    }
                    else if (data_parsed[0] == "Current:")
                    {
                        if(data_parsed.Length==2)
                        {
                            textBox15.Invoke(this.myDelegate, new Object[] { data_parsed });
                            //Console.WriteLine("current  " + data_parsed[1]);
                        }

                    }
                    else if (data_parsed[0] == "OC_TC_SC:")
                    {
                        if (data_parsed.Length == 4)
                        {
                            textBox60.Invoke(this.myDelegate, new Object[] { data_parsed });
                            textBox59.Invoke(this.myDelegate, new Object[] { data_parsed });
                            textBox58.Invoke(this.myDelegate, new Object[] { data_parsed });
                            //Console.WriteLine("current  " + data_parsed[1]);
                        }

                    }
                    else if (data_parsed[0] == "Temperature:")
                    {
                        if (data_parsed.Length == 5)
                        {
                            textBox19.Invoke(this.myDelegate, new Object[] { data_parsed });
                            textBox20.Invoke(this.myDelegate, new Object[] { data_parsed });
                            textBox21.Invoke(this.myDelegate, new Object[] { data_parsed });
                            textBox22.Invoke(this.myDelegate, new Object[] { data_parsed });
                        }
                    }
                    else if (data_parsed[0] == "Battery")
                    {
                        if (data_parsed.Length == 4)
                        {
                            textBox16.Invoke(this.myDelegate, new Object[] { data_parsed });
                        }
                    }
                    else if (data_parsed[0] == "Total")
                    {
                        if (data_parsed.Length == 3)
                        {
                            textBox24.Invoke(this.myDelegate, new Object[] { data_parsed });
                        }
                    }
                    else if (data_parsed[0] == "Charging")
                    {
                        if (data_parsed.Length == 4)
                        {
                            textBox17.Invoke(this.myDelegate, new Object[] { data_parsed });
                        }
                    }
                    else if (data_parsed[0] == "Discharging")
                    {
                        if (data_parsed.Length == 4)
                        {
                            textBox18.Invoke(this.myDelegate, new Object[] { data_parsed });
                        }
                    }
                    else if (data_parsed[0] == "Balancing:")
                    {

                        text1.Invoke(this.myDelegate, new Object[] { data_parsed });
                        text2.Invoke(this.myDelegate, new Object[] { data_parsed });
                        text3.Invoke(this.myDelegate, new Object[] { data_parsed });
                        text4.Invoke(this.myDelegate, new Object[] { data_parsed });
                        text5.Invoke(this.myDelegate, new Object[] { data_parsed });
                        text6.Invoke(this.myDelegate, new Object[] { data_parsed });
                        text7.Invoke(this.myDelegate, new Object[] { data_parsed });
                        text8.Invoke(this.myDelegate, new Object[] { data_parsed });
                        text9.Invoke(this.myDelegate, new Object[] { data_parsed });
                        text10.Invoke(this.myDelegate, new Object[] { data_parsed });
                        text11.Invoke(this.myDelegate, new Object[] { data_parsed });
                        text12.Invoke(this.myDelegate, new Object[] { data_parsed });
                        text13.Invoke(this.myDelegate, new Object[] { data_parsed });
                    }
                    else if (data_parsed[0] == "Health:")
                    {
                        if (data_parsed.Length == 3)
                        {
                            textBox56.Invoke(this.myDelegate, new Object[] { data_parsed });
                            //Console.WriteLine("here");
                        }
                    }

                }
                else if (exit_flag == 0)
                {
                    serialPort1.Dispose();
                    serialPort1.Close();
                    GC.Collect();
                    exit_flag = 0;
                    Console.WriteLine("readlineexit");
                    //break;
                }
            }
            catch (System.IO.IOException)
            {
                serialPort1.Dispose();
                serialPort1.Close();
                exit_flag = 0;
                GC.Collect();
            }
            catch(System.ObjectDisposedException)
            {
                serialPort1.Dispose();
                serialPort1.Close();
                exit_flag = 0;
                GC.Collect();
            }
            catch (System.FormatException)
            {
                serialPort1.Dispose();
                serialPort1.Close();
                exit_flag = 0;
                GC.Collect();
            }
            catch (System.IndexOutOfRangeException)
            {
                serialPort1.Dispose();
                serialPort1.Close();
                exit_flag = 0;
                GC.Collect();
            }


        }
        private void openport_Click(object sender, EventArgs e)
        {
            try
            {
                if (comport.Text == "" || baudrate.Text == "")
                {
                    textBox14.Text = "Please select the proper port settings";
                }
                else
                {
                    if (exit_flag == 0)
                    {
                        exit_flag = 1; // port open condition
                        serialPort1.PortName = comport.Text;
                        serialPort1.BaudRate = Convert.ToInt32(baudrate.Text);
                        serialPort1.Parity = Parity.None;
                        serialPort1.DataBits = 8;
                        serialPort1.StopBits = StopBits.One;
                        serialPort1.Handshake = Handshake.None;
                        //serialPort1.ReadTimeout = 20000;
                        //serialPort1.NewLine = "\r\n";
                        //serialPort1.RtsEnable = true;
                        //serialPort1.DtrEnable = true;
                        serialPort1.Open();

                        //char[] data = new char[1];
                        //data[0] = 'b';
                        //serialPort1.Write(data, 0, 1);
                        serialPort1.Write("a\r\n");
                        //serialPort1.Write(new byte[] { 13, 10 }, 0, 2);

                        textBox14.Text = "OPENING PORT";
                        progressBar1.Value = 100;
                        textBox14.Text = "PORT OPENED";
                        textBox1.Enabled = true;
                        textBox2.Enabled = true;
                        textBox3.Enabled = true;
                        textBox4.Enabled = true;
                        textBox5.Enabled = true;
                        textBox6.Enabled = true;
                        textBox7.Enabled = true;
                        textBox8.Enabled = true;
                        textBox9.Enabled = true;
                        textBox10.Enabled = true;
                        textBox11.Enabled = true;
                        textBox12.Enabled = true;
                        textBox13.Enabled = true;
                        //closeport.Enabled = true;
                        openport.Enabled = false;
                        
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                textBox14.Text = "Unauthorized access";
            }
            catch (System.IO.IOException)
            {
                serialPort1.Close();
                exit_flag = 0;
                GC.Collect();
            }
            catch (System.ObjectDisposedException)
            {
                serialPort1.Close();
                exit_flag = 0;
                GC.Collect();
            }
            catch (System.FormatException)
            {
                serialPort1.Close();
                exit_flag = 0;
                GC.Collect();
            }
            catch (System.IndexOutOfRangeException)
            {
                serialPort1.Close();
                exit_flag = 0;
                GC.Collect();
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            getAvailableports();
        }

        private void closeport_Click(object sender, EventArgs e)
        {
            try
            { 
                exit_flag = 0;
                serialPort1.Close();
                progressBar1.Value = 0;
                serialPort1.Dispose();
                GC.Collect();
                textBox14.Text = "PORT CLOSED";
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                textBox5.Enabled = false;
                textBox6.Enabled = false;
                textBox7.Enabled = false;
                textBox8.Enabled = false;
                textBox9.Enabled = false;
                textBox10.Enabled = false;
                textBox11.Enabled = false;
                textBox12.Enabled = false;
                textBox13.Enabled = false;
                closeport.Enabled = false;
                openport.Enabled = true;
                Console.WriteLine("closeport");
                Application.Exit();
                Application.ExitThread();
            }
            catch (System.IO.IOException)
            {
                serialPort1.Close();
                exit_flag = 0;
                GC.Collect();
                Application.Exit();
                Application.ExitThread();
            }
            catch (System.ObjectDisposedException)
            {
                serialPort1.Close();
                exit_flag = 0;
                GC.Collect();
                Application.Exit();
                Application.ExitThread();
            }
            catch (System.FormatException)
            {
                serialPort1.Close();
                exit_flag = 0;
                GC.Collect();
                Application.Exit();
                Application.ExitThread();
            }
            catch (System.IndexOutOfRangeException)
            {
                serialPort1.Close();
                exit_flag = 0;
                GC.Collect();
                Application.Exit();
                Application.ExitThread();
            }


        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)

        {

            if (serialPort1.IsOpen)

            {

                e.Cancel = true; //cancel the fom closing

                Thread CloseDown = new Thread(new ThreadStart(CloseSerialOnExit)); //close port in new thread to avoid hang

                CloseDown.Start(); //close port in new thread to avoid hang

            }

        }

        private void CloseSerialOnExit()

        {

            try

            {

                serialPort1.Close(); //close the serial port

            }

            catch (Exception ex)

            {

                MessageBox.Show(ex.Message); //catch any serial port closing error messages

            }

            this.Invoke(new EventHandler(NowClose)); //now close back in the main thread

        }

        private void NowClose(object sender, EventArgs e)

        {

            this.Close(); //now close the form

        }

        private void comport_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }

        private void comport_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {


        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {

        }

        private void baudrate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter_1(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }
    }
}
