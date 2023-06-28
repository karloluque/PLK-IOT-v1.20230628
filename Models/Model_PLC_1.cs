using System;
using System.Collections.Generic;
using System.Text;

namespace PLK_IIOT_V1.Models
{
    [Serializable]
    public class Model_PLC_1
    {
        /// added 
        public string Machine_Name { get; set; }
        public string Ip_Address { get; set; }
        public int Sequence_Step { get; set; }
        public int Current_Shift { get; set; }
        public int Daily_Target { get; set; }
        public int[] Downtime_msec { get; set; } = new int[24];
        public int Down_Total_msec { get; set; }
        public int[] Uptime_msec { get; set; } = new int[24];
        public int Up_Total_msec { get; set; }
        public int[] PLC_Datetime { get; set; } = new int[7];
        public int[] Hourly_Counter { get; set; } = new int[24];
        public int[] Todays_Shifts { get; set; } = new int[3];
        public int Todays_Total { get; set; }
        public int[] Ydays_Shifts { get; set; } = new int[3];
        public int Ydays_Total { get; set; }
        public int Avg_Takt_Time_msec { get; set; }
        public int Last_Takt_Time_msec { get; set; }
        public float OR { get; set; }
        public float OEE_Shift { get; set; }
        public float OEE_Day { get; set; }
        public int[] SpareDINT { get; set; } = new int[20];














    }
}
