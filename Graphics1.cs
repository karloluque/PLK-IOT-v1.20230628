using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using PLK_IIOT_V1.Controllers;
using PLK_IIOT_V1.Models;
using ScottPlot;
namespace PLK_IIOT_V1
{
    
    public partial class Graphics1 : Form
    {
       

        double[] dataY = new double[168];
        double[] dataX = new double[168];

        double[] Graphic1_series_Y = new double[] { 1, 2, 3, 4, 5 };
        double[] Graphic1_series_X = new double []{ 1, 2, 3, 4, 5 };

        int last_hour,currentline,currentvaluehour=40,hour=5,graphlines1,sec=0;
        public Model_PLC_1 PLC = new Model_PLC_1();
        Notepad_Control Notepad = new Notepad_Control();

        private void Graphics1_Load(object sender, EventArgs e)
        {
            //currentline = Notepad.readlines("Graphics1X");

            //Graphic1_series_Y = Notepad.Read_Notepad("Graphics1Y");
            //Graphic1_series_X = Notepad.Read_Notepad("Graphics1X");
        }

        private void tmr_update_Tick(object sender, EventArgs e)
        {
           
               


        }

        public Graphics1()
        {
            InitializeComponent();

           


            





        }
        public void Data_Refresh(Model_PLC_1 data_in)
        {
            PLC = data_in;
            
           
            
            

            
        }

        private void button1_Click(object sender, EventArgs e)
        {

           


        }

       
        public void plot1_refresh(double[] DataX, double[] DataY)
        {
            Plot1_hours_historical.plt.Title($"Hours Production");
            Plot1_hours_historical.plt.XLabel("Horizontal Axis Hours");
            Plot1_hours_historical.plt.YLabel("Vertical Axis Parts");
            Plot1_hours_historical.Render();
            Plot1_hours_historical.Reset();
            Plot1_hours_historical.Plot.AddScatter(DataX, DataY);
            Plot1_hours_historical.Refresh();

          
        }
        public void plot2_refresh(double[] DataX, double[] DataY)
        {
            var plt1 = new ScottPlot.Plot(600, 400);

            // add a bar graph to the plot and enable values to be displayed above each bar
            var bar = plt1.AddBar(DataX);
            bar.ShowValuesAboveBars = true;

            // adjust axis limits so there is no padding below the bar graph
            plt1.SetAxisLimits(yMin: 0);

            formsPlot1.Reset();
            formsPlot1.Plot.AddBar(DataX, DataY);
            formsPlot1.Refresh();





        }



    }
}
//void hours_historical(int current_value, int hour)
//{



//    graphlines1 = Notepad.readlines("Graphics1X");
//    if (graphlines1 < 168)
//        graphlines1 = Notepad.readlines("Graphics1X");
//    else
//    {
//        graphlines1 = 168;

//    }
//    if (hour != last_hour)
//    {

//        for (int i = graphlines1; i >= 0; i--)
//        {
//            if (graphlines1 >= 167)
//            {


//            }

//            else
//            {
//                Graphic1_series_X[i + 1] = Graphic1_series_X[i];
//                Graphic1_series_Y[i + 1] = Graphic1_series_Y[i];

//            }



//        }
//        // Graphic1_serie_X[0] = hour;
//        // Graphic1_serie_Y[0] = current_value;
//        Graphic1_series_X[0] = Convert.ToString(hour);
//        Graphic1_series_Y[0] = Convert.ToString(current_value);

//        hour = last_hour;


//        //currentline++;
//        //Notepad.Write_Notepad(Graphic1_series_X, "Graphics1X");
//        //Notepad.Write_Notepad(Graphic1_series_Y, "Graphics1Y");

//    }
//    else
//    {

//    }



//    //graphlines1 = Notepad.readlines("Graphics1X");
//    //if (graphlines1 < 168)
//    //    graphlines1 = Notepad.readlines("Graphics1X");
//    //else
//    //{
//    //    graphlines1 = 168;

//    //}
//    double[] dataY = new double[graphlines1];
//    double[] dataX = new double[graphlines1];

//    for (int i = 0; i < graphlines1; i++)
//    {
//        dataX[i] = Convert.ToDouble(Graphic1_series_X[i]);
//        dataY[i] = Convert.ToDouble(Graphic1_series_Y[i]);


//    }
//    formsPlot1.Reset();
//    formsPlot1.Plot.AddScatter(dataX, dataY);
//    formsPlot1.Refresh();

//    label1.Text = hour.ToString();
//    label2.Text = currentvaluehour.ToString();


//}