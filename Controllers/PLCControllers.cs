using Corsinvest.AllenBradley.PLC.Api;
using PLK_IIOT_V1.Models;
using System;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLK_IIOT_V1.Controllers
{
    class PLCController
    {
        Email_Controller_v2 Emailsend = new Email_Controller_v2();
        public bool connected;
        Controller cpu;
        TagGroup g1;
        public string tag = null;
        public string tag2 = null;
        string ip_address;

        //public Tag<Model_PLC_1>[] Nest = new Tag<Model_PLC_1>[2];

        public Model_PLC_1 Datareaded_out = new Model_PLC_1();

        public int attempt2connect = 0;
        public bool plc_disable;

        bool testingmode = false;
        //Nest 0 = Flex Line
        //Nest 1 = Main Line

        public PLCController(string ip, string path, string tag_in, string tag_in2)
        {
            cpu = new Controller(ip, path, CPUType.LGX);
            g1 = cpu.CreateGroup();
            tag = tag_in;
            tag2 = tag_in2;
            ip_address = ip;
            if (testingmode == false)
            {
                if (pinging_at_start(ip) == true)

                {
                    Task.Run(Thread1);

                }
                else
                {


                    if (plc_disable == false)
                    {
                        Emailsend.SimpleEmailSender($"No Pinging at start, No Connection {ip_address}", "");
                        string message = "Check Ethernet Connection";
                        string title = $"Error: PLC Address {ip} Not Connected";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                        Thread.Sleep(10000);
                        Environment.Exit(0);

                    }
                }
            }

        }

        void Thread1()
        {
            var datareaded_in = g1.CreateTagType<Model_PLC_1>(tag);
            while (plc_disable != true)
            {

                if (pinging(ip_address) == true)
                {
                    try
                    {
                        var status = g1.Read();
                        Datareaded_out = datareaded_in.Value;
                        connected = status.Where(x => x.StatusCode != 0).Count() == 0 ? true : false;

                        Thread.Sleep(250);
                    }
                    catch (Exception)
                    {
                        attempt2connect++;
                        if (attempt2connect > 3)
                        {
                            Emailsend.SimpleEmailSender($"YF Lines IOT: Not Reading, No Data Readed{ip_address}", "PLC Comunication Disable");
                            connected = false;
                            plc_disable = true;
                        }



                    }

                }
                else
                {
                    //Emailsend.SimpleEmailSender($"YF Lines IOT: No Pinging in running, No Connection PLC {ip_address}", "");
                    //string message = "Check Ethernet Connection";
                    //string title = $"Error: PLC Address {ip_address} Not Connected";
                    //MessageBoxButtons buttons = MessageBoxButtons.OK;
                    //MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);


                    //    Thread.Sleep(10000);
                    /// Environment.Exit(0);


                }


            }
        }


        bool pinging(string ip)
        {
            bool plc_connected = false;
            try
            {
                Ping myPing = new Ping();
                PingReply reply = myPing.Send(ip, 1000);
                if (reply.Status == IPStatus.Success)
                {
                    //Console.WriteLine("Status :  " + reply.Status + " \n Time : " + reply.RoundtripTime.ToString() + " \n Address : " + reply.Address);
                    ////Console.WriteLine(reply.ToString());
                    //string message = "Status :  " + reply.Status + " \n Time : " + reply.RoundtripTime.ToString() + " \n Address : " + reply.Address;
                    //string title = $"Message: PLC {ip} Connected";
                    //MessageBox.Show(message, title);
                    plc_connected = true;


                }
                else
                {


                    string message = "No Pinging, PLC has been disconnected";
                    string title = $"Error: PLC Address {ip} Not Connected";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                    plc_connected = false;
                    //Thread.Sleep(10000);
                    //Environment.Exit(0);
                    plc_disable = true;

                }
            }
            catch (Exception e)
            {

                Console.WriteLine("Exception: " + e.Message);
                string message = e.Message;
                string title = $"Error: PLC Address {ip} has been disconnected";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                plc_connected = false;

                plc_disable = true;

                //  Thread.Sleep(10000);
                //Environment.Exit(0);



            }
            return plc_connected;

        }
        bool pinging_at_start(string ip)
        {
            bool plc_connected = false;
            try
            {
                Ping myPing = new Ping();
                PingReply reply = myPing.Send(ip, 1000);
                if (reply.Status == IPStatus.Success)
                {
                    //Console.WriteLine("Status :  " + reply.Status + " \n Time : " + reply.RoundtripTime.ToString() + " \n Address : " + reply.Address);
                    ////Console.WriteLine(reply.ToString());
                    //string message = "Status :  " + reply.Status + " \n Time : " + reply.RoundtripTime.ToString() + " \n Address : " + reply.Address;
                    //string title = $"Message: PLC {ip} Connected";
                    //MessageBox.Show(message, title);
                    plc_connected = true;


                }
                else
                {


                    string message = "PLC is not replying, Do you want to continue running the second PLC?";
                    string title = $"Error: PLC Address {ip} Not Connected";



                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {
                        plc_disable = true;
                        Emailsend.SimpleEmailSender($"YF Lines IOT: PLC {ip_address}, not reply, Comunication Disable", "");
                    }
                    else
                    {
                        Thread.Sleep(5000);
                        Environment.Exit(0);
                    }

                    plc_connected = false;

                }
            }
            catch (Exception e)
            {

                Console.WriteLine("Exception: " + e.Message);
                string message = e.Message;
                string title = $"Error: PLC Address {ip} Not Connected at start";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                plc_connected = false;
                if (plc_disable == false)
                {
                    Thread.Sleep(10000);
                    //  Environment.Exit(0);

                }



            }
            return plc_connected;

        }
    }



}


