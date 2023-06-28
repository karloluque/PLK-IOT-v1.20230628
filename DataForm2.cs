using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PLK_IIOT_V1.Controllers;
using PLK_IIOT_V1.Models;

namespace PLK_IIOT_V1
{
    public partial class DataForm2 : Form
    {
        public Model_PLC_1 PLC = new Model_PLC_1();
        public DataForm2()
        {
            InitializeComponent();
           // tmr_update.Start();
        }

        public void Data_Refresh(Model_PLC_1 data_in)
        {

            PLC = data_in;
            label_tittle.Text = PLC.Machine_Name;
            lbl_date.Text = PLC.PLC_Datetime[1].ToString("00") + "/" + PLC.PLC_Datetime[2].ToString("00") + "/" + PLC.PLC_Datetime[0].ToString("00") + "\n" + PLC.PLC_Datetime[3].ToString("00") + ":" + PLC.PLC_Datetime[4].ToString("00") + ":" + PLC.PLC_Datetime[5].ToString("00");

            //label_hours();
            hearbeat();



            lbl_total_s1.Text = PLC.Todays_Shifts[0].ToString();
            lbl_total_s2.Text = PLC.Todays_Shifts[1].ToString();
            lbl_total_s3.Text = PLC.Todays_Shifts[2].ToString();

            //lbl_oee.Text = OEE_calculate((float)PLC.Todays_Shifts[PLC.Current_Shift], 60).ToString() + " %";
            lbl_oee.Text = Decimal.Round(Convert.ToDecimal(PLC.OEE_Day), 2).ToString() + " %";
            lbl_avg_takttime.Text = Decimal.Round(Convert.ToDecimal(PLC.Avg_Takt_Time_msec), 2).ToString() + " Sec.";
            lbl_lasttakt.Text = Decimal.Round(Convert.ToDecimal(PLC.Last_Takt_Time_msec), 2).ToString() + " Sec.";

            lbl_s1h1.Text = PLC.Hourly_Counter[5].ToString();
            lbl_s1h2.Text = PLC.Hourly_Counter[6].ToString();
            lbl_s1h3.Text = PLC.Hourly_Counter[7].ToString();
            lbl_s1h4.Text = PLC.Hourly_Counter[8].ToString();
            lbl_s1h5.Text = PLC.Hourly_Counter[9].ToString();
            lbl_s1h6.Text = PLC.Hourly_Counter[10].ToString();
            lbl_s1h7.Text = PLC.Hourly_Counter[11].ToString();
            lbl_s1h8.Text = PLC.Hourly_Counter[12].ToString();

            lbl_s2h1.Text = PLC.Hourly_Counter[13].ToString();
            lbl_s2h2.Text = PLC.Hourly_Counter[14].ToString();
            lbl_s2h3.Text = PLC.Hourly_Counter[15].ToString();
            lbl_s2h4.Text = PLC.Hourly_Counter[16].ToString();
            lbl_s2h5.Text = PLC.Hourly_Counter[17].ToString();
            lbl_s2h6.Text = PLC.Hourly_Counter[18].ToString();
            lbl_s2h7.Text = PLC.Hourly_Counter[19].ToString();
            lbl_s2h8.Text = PLC.Hourly_Counter[20].ToString();

            lbl_s3h1.Text = PLC.Hourly_Counter[21].ToString();
            lbl_s3h2.Text = PLC.Hourly_Counter[22].ToString();
            lbl_s3h3.Text = PLC.Hourly_Counter[23].ToString();
            lbl_s3h4.Text = PLC.Hourly_Counter[0].ToString();
            lbl_s3h5.Text = PLC.Hourly_Counter[1].ToString();
            lbl_s3h6.Text = PLC.Hourly_Counter[2].ToString();
            lbl_s3h7.Text = PLC.Hourly_Counter[3].ToString();
            lbl_s3h8.Text = PLC.Hourly_Counter[4].ToString();

        }
        void label_hours()
        {
            label_s1h1.Text = "5:30\n6:30";
            label_s1h2.Text = "6:30\n7:30";
            label_s1h3.Text = "7:30\n8:30";
            label_s1h4.Text = "8:30\n9:30";
            label_s1h5.Text = "9:30\n10:30";
            label_s1h6.Text = "10:30\n11:30";
            label_s1h7.Text = "11:30\n12:30";
            label_s1h8.Text = "12:30\n1:30";

            label_s2h1.Text = "1:30\n2:30";
            label_s2h2.Text = "2:30\n3:30";
            label_s2h3.Text = "3:30\n4:30";
            label_s2h4.Text = "4:30\n5:30";
            label_s2h5.Text = "5:30\n6:30";
            label_s2h6.Text = "6:30\n7:30";
            label_s2h7.Text = "7:30\n8:30";
            label_s2h8.Text = "8:30\n9:30";

            label_s3h1.Text = "9:30\n10:30";
            label_s3h2.Text = "10:30\n11:30";
            label_s3h3.Text = "11:30\n12:30";
            label_s3h4.Text = "12:30\n1:30";
            label_s3h5.Text = "1:30\n2:30";
            label_s3h6.Text = "2:30\n3:30";
            label_s3h7.Text = "3:30\n4:30";
            label_s3h8.Text = "4:30\n5:30";





        }
        float OEE_calculate(float goodpartsshift, int idealCT)
        {
            float return_value = 0.0F;


            return_value = (float)Decimal.Round(Convert.ToDecimal(((goodpartsshift * (float)idealCT) / (float)(420 * 60)) * 100), 2);

            return return_value;
        }
        void hearbeat()
        {
            if (Convert.ToBoolean(PLC.SpareDINT[0]) == true)
            {
                pb_heartbeat.BackColor = System.Drawing.Color.White;

            }
            else
            {
                pb_heartbeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(43)))), ((int)(((byte)(87)))));


            }
        }
    }
}
