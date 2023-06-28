using System;
using System.Collections.Generic;
using System.Text;
using PLK_IIOT_V1.Models;
using Corsinvest.AllenBradley.PLC.Api;
using System.Threading.Tasks;
using System.Threading;
using System.Linq;
using System.IO;
using System.Windows.Forms;

namespace PLK_IIOT_V1.Controllers
{
    class Notepad_Control
    {
        string error_line;
        public string[] readed_value = new string[30];
        public string path = Directory.GetCurrentDirectory();
        public Notepad_Control()
        {



        }


        public void Write_Notepad(string[] Data_in, string notepad_number)
        {
            CreateDirectory();
            try
            {

                //Pass the filepath and filename to the StreamWriter Constructor
                StreamWriter sw = new StreamWriter($"{path}\\notepad data\\DataStored_{notepad_number}.txt");

                for (int i = 0; i < Data_in.Length; i++)
                {
                    sw.WriteLine(Data_in[i]);
                }





                //Close the file
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
                string message = e.Message;
                string title = "Error Write";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }

        }
        public string[] Read_Notepad(string notepad_number)
        {
            string[] returnstrings = new string[50];
            String line, ln;
            int counter = 0, return_value = 0;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr_countline = new StreamReader($"{path}\\notepad data\\DataStored_{notepad_number}.txt");
                StreamReader sr = new StreamReader($"{path}\\notepad data\\DataStored_{notepad_number}.txt");
                //Count all lines of text

                while ((ln = sr_countline.ReadLine()) != null)
                {

                    counter++;
                }
                var f = 0;
                //Read until you reach end of file
                for (int i = 0; i < counter; i++)
                {


                    //Read the next line
                    line = sr.ReadLine();
                    returnstrings[i] = line;
                    error_line = line;
                    var sd = 0;
                }


                //close the file
                sr.Close();
                sr_countline.Close();


            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
                string message = e.Message + "\n" + $"DataStored_{notepad_number}" + $"\n Line:{error_line}";
                string title = "Error Read";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                Thread.Sleep(10000);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
            return returnstrings;

        }
        void CreateDirectory()
        {
            // Specify the directory you want to manipulate.



            string folderName = $"{path}\\Notepad Data";
            // If directory does not exist, create it
            if (!Directory.Exists(folderName))
            {
                Directory.CreateDirectory(folderName);
            }


        }
        public int readlines(string notepad_number)
        {
            string[] returnstrings = new string[50];
            String line, ln;
            int counter = 0, return_value = 0;
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr_countline = new StreamReader($"{path}\\notepad data\\DataStored_{notepad_number}.txt");
                StreamReader sr = new StreamReader($"{path}\\notepad data\\DataStored_{notepad_number}.txt");
                //Count all lines of text

                while ((ln = sr_countline.ReadLine()) != null)
                {

                    counter++;
                }
                var f = 0;
                return_value = counter;
                sr_countline.Close();


            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
                string message = e.Message;
                string title = "Error Read Lines";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                Thread.Sleep(10000);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
            return return_value;

        }








    }
}


