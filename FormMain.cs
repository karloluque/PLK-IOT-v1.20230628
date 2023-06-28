using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PLK_IIOT_V1.Models;
using PLK_IIOT_V1.Controllers;
using Color = System.Windows.Media.Color;
using LiveCharts.Wpf;
using System.Windows.Media;
using System.Drawing.Imaging;
using System.Net.Mail;
using System.Net.Mime;
using System.IO;

namespace PLK_IIOT_V1
{
    //public delegate void DataSendHandler(Model_PLC_1 data_in);
    public partial class FormMain : Form
    {
        //public event DataSendHandler DataSent;

        public delegate void SendDataToChildForm1(Model_PLC_1 Datain);
        public SendDataToChildForm1 SetPLCData1;

        public delegate void SendDataToChildForm2(Model_PLC_1 Datain);
        public SendDataToChildForm2 SetPLCData2;

        public delegate void SendDataToChildForm3(Model_PLC_1 Datain);
        public SendDataToChildForm3 SetPLCData3;


        public delegate void SendDataGraph1(double[] Graphic1_series_Y, double[] Graphic1_series_X);
        public SendDataGraph1 SetDataGraph1;

       public delegate void SendDataGraph2(double[] Graphic1_series_Y, double[] Graphic1_series_X);
        public SendDataGraph2 SetDataGraph2;

        String Hour = DateTime.Now.ToString("HH");
        string Minutes = DateTime.Now.ToString("mm");
        String DateHHMM = DateTime.Now.ToString("H:mm");
        String DateDDMMYY = DateTime.Now.ToString("MM/dd/yy");
        Model_Global_Tags PLC = new Model_Global_Tags();

        int last_hour, currentline, currentvaluehour = 40, hour = 5, graphlines1=0, sec = 0,secc;

        public DataForm1 ChildForm1 = new DataForm1();
        public DataForm2 ChildForm2 = new DataForm2();
        public Graphics1 ChildForm3 = new Graphics1();

        double[] Graphic1_series_Y = new double[168];
        double[] Graphic1_series_X = new double[168] ;
        int countcycle = 0, LineRecord;
        bool reportdone = false;
        Email_Controller_v2 e_mail = new Email_Controller_v2();
        Notepad_Control Notepad = new Notepad_Control();
        PLCController PLC1 = new PLCController("10.17.44.152", "1,0", "IOT_Tags_1", null);//MainLine PLC1
        PLCController PLC2 = new PLCController("10.17.44.2", "1,0", "IOT_Tags_1", null);//Flex Line PLC2
        string[] emails = new string[5];
        string CurrentDirectory = Environment.CurrentDirectory;
        public FormMain()
        {
            InitializeComponent();
            tmr_update.Interval = 500;
            tmr_update.Start();
            Open_DataForm_PLC1();
            Open_DataForm_PLC2();
            // Open_Graphics_PLC1();
            config_solidgauge_overall();
            config_solidgauges(420, 213);
        }

        
        private void Open_DataForm_PLC1()
        {
            
            Form activeform = null;         

            activeform = ChildForm1;

            ChildForm1.TopLevel = false;
            ChildForm1.FormBorderStyle = FormBorderStyle.None;
            ChildForm1.Dock = DockStyle.Fill;
            pnl_PLC1.Controls.Add(ChildForm1);
            pnl_PLC1.Tag = ChildForm1;

            this.SetPLCData1 += new SendDataToChildForm1(ChildForm1.Data_Refresh);
           
             ChildForm1.BringToFront();
            ChildForm1.Show();


        }
        private void Open_DataForm_PLC2()
        {

            Form activeform = null;
            if (activeform != null)
                activeform.Close();

            activeform = ChildForm2;



            ChildForm2.TopLevel = false;
            ChildForm2.FormBorderStyle = FormBorderStyle.None;
            ChildForm2.Dock = DockStyle.Fill;
            pnl_PLC2.Controls.Add(ChildForm2);
            pnl_PLC2.Tag = ChildForm2;
            ChildForm2.BringToFront();
            this.SetPLCData2 += new SendDataToChildForm2(ChildForm2.Data_Refresh);

            ChildForm2.Show();


        }
        private void Open_Graphics_PLC1()
        {

            Form activeform = null;
            if (activeform != null)
                activeform.Close();

            activeform = ChildForm3;



            ChildForm3.TopLevel = false;
            ChildForm3.FormBorderStyle = FormBorderStyle.None;
            ChildForm3.Dock = DockStyle.Fill;
            pnl_PLC2.Controls.Add(ChildForm3);
            pnl_PLC2.Tag = ChildForm3;
            ChildForm3.BringToFront();
            this.SetDataGraph1 += new SendDataGraph1(ChildForm3.plot1_refresh);
            this.SetDataGraph2 += new SendDataGraph2(ChildForm3.plot2_refresh);

            ChildForm3.Show();


        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e_mail.SimpleEmailSender($"YF Lines IOT: Closing App ", "");
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            e_mail.SimpleEmailSender($"YF Lines IOT: Starting App ", "");
        }

        private void tmr_update_Tick(object sender, EventArgs e)
        {
        if(PLC1.Datareaded_out.SpareDINT[5] == 1|| PLC2.Datareaded_out.SpareDINT[5] == 1)
            {
                string CurrentDirectory = Environment.CurrentDirectory;

                System.Diagnostics.Process.Start(@$"{CurrentDirectory}\PLK_IIOT_V1.exe");
                Environment.Exit(0);
            }

            
            SetPLCData1(PLC1.Datareaded_out);

           
            SetPLCData2(PLC2.Datareaded_out);

            lbl_shift_record.Text = Shift_record(PLC1.Datareaded_out.Todays_Shifts[PLC1.Datareaded_out.Current_Shift]).ToString();
            lbl_shift_record.Text = Shift_record(PLC2.Datareaded_out.Todays_Shifts[PLC2.Datareaded_out.Current_Shift]).ToString();

            Hour = DateTime.Now.ToString("HH");
            Minutes = DateTime.Now.ToString("mm");
            DateHHMM = DateTime.Now.ToString("H:mm");
            DateDDMMYY = DateTime.Now.ToString("MM/dd/yy");



            sg_today_ml_total.Value = PLC2.Datareaded_out.Todays_Total;
            sg_yday_ml_total.Value = PLC2.Datareaded_out.Ydays_Total;

            sg_today_fl_total.Value = PLC1.Datareaded_out.Todays_Total;
            sg_yday_fl_total.Value = PLC1.Datareaded_out.Ydays_Total;

            sg_overall.Value = (PLC1.Datareaded_out.Todays_Total + PLC2.Datareaded_out.Todays_Total);
            
         


            reporting();

            //sec++;
            //secc++;
            //if (sec >= 5)
            //{
            //    sec = 0;
            //    hour++;

            //}
            //if (secc == 2)
            //{
            //    currentvaluehour++;
            //    secc = 0;
            //}

            //sg_today_ml_total.Value = currentvaluehour;
            //sg_yday_ml_total.Value = hour;
            //sg_today_fl_total.Value = secc;

            //hours_historical(currentvaluehour,hour);



        }

        private void picbx_logo_Click(object sender, EventArgs e)
        {
            CaptureMyScreen();
            emails = Notepad.Read_Notepad("emails");
            e_mail.Emailsender(emails[0], emails[1], emails[2], emails[3], emails[4], "Production Report YF Lines", PLC1.Datareaded_out, PLC2.Datareaded_out, LineRecord);

            // e_mail.SimpleEmailSender($"Test", "");
           
        }
        void hours_historical(int current_value, int hour)
        {

            if (hour != last_hour)
            {
                double[] arraytemp = new double[168];
                double[] arraytemp1 = new double[168];

                Array.Copy(Graphic1_series_X, 0, arraytemp, 1, Graphic1_series_X.Length - 1);
                Graphic1_series_X = arraytemp;
                Graphic1_series_X[0] = hour;
            
                Array.Copy(Graphic1_series_Y, 0, arraytemp1, 1, Graphic1_series_Y.Length - 1);
                Graphic1_series_Y = arraytemp1;
                Graphic1_series_Y[0] = current_value;



                last_hour =hour;

                var g = 4;

                SetDataGraph1(Graphic1_series_X, Graphic1_series_Y);
                SetDataGraph2(Graphic1_series_X, Graphic1_series_Y);
            }
            else
            {

            }



           
        }
        int Shift_record(int currentcount)
        {
            string[] str1 = new string[50];
            int return_value = 0, readvalue = 0;

            str1 = Notepad.Read_Notepad("0");
            //currentcount = 555;
            readvalue = Convert.ToInt32(str1[0]);
            if (currentcount > readvalue)

            {
                str1[0] = Convert.ToString(currentcount);
                Notepad.Write_Notepad(str1, "0");
                return_value = currentcount;
                e_mail.SimpleEmailSender($"YF Lines IOT: New Line Record {return_value} ", "");
            }
            else
            {
                return_value = readvalue;
            }

            LineRecord = return_value;

            return return_value;

        }
        void reporting()
        {
            int hrs, min;
           

            hrs = Convert.ToInt32(Hour);
            min = Convert.ToInt32(Minutes);


            //if (((hrs == 5 && min == 00) || (hrs == 13 && min == 30) || (hrs == 21 && min == 30)) && reportdone == false)
            if (( (hrs == 21 && min == 00)) && reportdone == false)
            {
                CaptureMyScreen();
                emails = Notepad.Read_Notepad("emails");
                e_mail.Emailsender(emails[0], emails[1], emails[2], emails[3], emails[4], "Production Report YF Lines", PLC1.Datareaded_out, PLC2.Datareaded_out, LineRecord);

                reportdone = true;
            }
            else
            {






                if (min != 00)
                {
                    reportdone = false;

                }



            }



        }
        void config_solidgauge_overall()
        {
            sg_overall.From = 0;
            sg_overall.To = 100;

            sg_overall.Base.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));

        }
        void config_solidgauges(int goal_fl_shift, int goal_ml_shift)
        {



            sg_today_ml_total.From = 0;
            sg_yday_ml_total.From = 0;
            sg_today_fl_total.From = 0;
            sg_yday_fl_total.From = 0;

            sg_overall.To = (goal_ml_shift * 3) + (goal_fl_shift * 3);
            sg_today_ml_total.To = goal_ml_shift * 3;
            sg_yday_ml_total.To = goal_ml_shift * 3;
            sg_today_fl_total.To = goal_fl_shift * 3;
            sg_yday_fl_total.To = goal_fl_shift * 3;





            sg_today_ml_total.Base.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            sg_today_ml_total.HighFontSize = 40;
            sg_today_ml_total.Base.GaugeActiveFill = new SolidColorBrush(Colors.Yellow);
            


            sg_yday_ml_total.Base.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            sg_yday_ml_total.HighFontSize = 40;
            sg_yday_ml_total.Base.GaugeActiveFill = new SolidColorBrush(Colors.Yellow);


            sg_today_fl_total.Base.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            sg_today_fl_total.HighFontSize = 40;
            sg_today_fl_total.Base.GaugeActiveFill = new SolidColorBrush(Colors.Green);

            sg_yday_fl_total.Base.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            sg_yday_fl_total.HighFontSize = 40;
            sg_yday_fl_total.Base.GaugeActiveFill = new SolidColorBrush(Colors.Green);

            
            
            sg_overall.Base.Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            sg_overall.HighFontSize = 40;
            sg_overall.Base.GaugeActiveFill = new SolidColorBrush(Colors.White);

        }

        private void CaptureMyScreen()

        {
            string CurrentDirectory = Environment.CurrentDirectory;
            DeleteFile(@$"{CurrentDirectory}\Capture.png");
            try

            {

                Bitmap bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
                                    Screen.PrimaryScreen.Bounds.Height);
                Graphics graphics = Graphics.FromImage(bitmap as Image);
                graphics.CopyFromScreen(0, 0, 0, 0, bitmap.Size);
                bitmap.Save(@$"{CurrentDirectory}\Capture.png", ImageFormat.Png);

                //Displaying the Successfull Result

                //MessageBox.Show("Screen Captured");

            }

            catch (Exception ex)

            {
                //MessageBox.Show(ex.Message);
            }

        }
        public static void DeleteFile(string path)
        {
            if (!File.Exists(path))
            {
                return;
            }

            bool isDeleted = false;
            while (!isDeleted)
            {
                try
                {
                    File.Delete(path);
                    isDeleted = true;
                }
                catch (Exception e)
                {
                }
                
            }
        }

    }




}


