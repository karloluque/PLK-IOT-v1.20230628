using System;
using System.Text;

using PLK_IIOT_V1.Models;

using System.Text.RegularExpressions;
using System.Threading;
using System;


using MimeKit;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;

namespace PLK_IIOT_V1.Controllers
{


    class Email_Controller_v2
    {

        string CurrentDirectory = Environment.CurrentDirectory;
        string HostName = Dns.GetHostName();
        string IpAddress_Host;
        Notepad_Control Notepad1 = new Notepad_Control();


        public Email_Controller_v2()
        {
            //Emailsender("hugo.palafox@plastikon.com", "juan.aceves@plastikon.com", "testing", "This has been sent from IOT Application");


        }
        public void SimpleEmailSender(string subject, string body)
        {
            IpAddress_Host = ip_host(HostName);
            try
            {
                MailMessage mail = new MailMessage();
                System.Net.Mail.SmtpClient SmtpServer = new System.Net.Mail.SmtpClient("smtp.gmail.com");

                string sender = "plastikoniot@gmail.com";
                mail.From = new MailAddress(sender);
                mail.To.Add("hugo.palafox@plastikon.com");
                MailAddress copy1 = new MailAddress("karlo.luque@plastikon.com");
                mail.CC.Add(copy1);
                mail.Priority = MailPriority.High;
                mail.Subject = subject;
                mail.IsBodyHtml = true;
                mail.Body = ($"{body} \n Name of computer: { HostName} ");
                SmtpServer.Port = 587;
                //SmtpServer.UseDefaultCredentials = true;
                SmtpServer.Credentials = new System.Net.NetworkCredential("plastikoniot@gmail.com", "gbpnotamivbmplam");
                SmtpServer.EnableSsl = true;


                SmtpServer.Send(mail);

               

            }
            catch (Exception ee)
            {

                System.Windows.MessageBox.Show(ee.Message);
                Thread.Sleep(10000);
            }
        }
        public void Emailsender(string CC1, string CC2, string CC3, string CC4, string CC5, string subject, Model_PLC_1 data, Model_PLC_1 data2, int LineRecord)
        {


            IpAddress_Host = ip_host(HostName);
            string body;


            string line_record;
            line_record = String.Join(" ", Notepad1.Read_Notepad("0"));

            DateTime theDate = DateTime.Now;
            theDate.ToString("yyyy-MM-dd");





            try
            {
                MailMessage mail = new MailMessage();
                System.Net.Mail.SmtpClient SmtpServer = new System.Net.Mail.SmtpClient("smtp.gmail.com");

                string sender = "plastikoniot@gmail.com";
                mail.From = new MailAddress(sender);
                mail.To.Add("hugo.palafox@plastikon.com");

                if (ValidateEmail(CC1))
                {
                    MailAddress copy1 = new MailAddress(CC1);
                    mail.CC.Add(copy1);
                }
                if (ValidateEmail(CC2))
                {
                    MailAddress copy2 = new MailAddress(CC2);
                    mail.CC.Add(copy2);
                }
                if (ValidateEmail(CC3))
                {
                    MailAddress copy3 = new MailAddress(CC3);
                    mail.CC.Add(copy3);
                }
                if (ValidateEmail(CC4))
                {
                    MailAddress copy4 = new MailAddress(CC4);
                    mail.CC.Add(copy4);
                }
                if (ValidateEmail(CC5))
                {
                    MailAddress copy5 = new MailAddress(CC5);
                    mail.CC.Add(copy5);
                }


                mail.Subject = subject;



                mail.IsBodyHtml = true;


                // mail.Priority = MailPriority.High;



                string html = htmlcontent(data, data2, LineRecord) + "<img src='cid:imagen' />";


                AlternateView htmlView =
                    AlternateView.CreateAlternateViewFromString(html,
                                            Encoding.UTF8,
                                            MediaTypeNames.Text.Html);

                LinkedResource img =
                    new LinkedResource(@$"{CurrentDirectory}\Capture.png",
                                        MediaTypeNames.Image.Jpeg);
                img.ContentId = "imagen";

                htmlView.LinkedResources.Add(img);

                mail.AlternateViews.Add(htmlView);





                // mail.Body =  htmlcontent(data, data2, LineRecord)  + "<img src='cid:imagen' />";;

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("plastikoniot@gmail.com", "gbpnotamivbmplam");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                //System.Windows.MessageBox.Show("Email has been sent Successfully!");
            }
            catch (Exception ee)
            {

                System.Windows.MessageBox.Show(ee.Message);
                Thread.Sleep(10000);
            }

        }
        

        bool ValidateEmail(string email)
        {
            bool bool_return = false;



            if (email == null)
            {
                bool_return = false;
            }
            else
            {
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(email);
                bool_return = match.Success;
            }



            return bool_return;
        }
        public string ip_host(string HostName)
        {
            string str_return = null;
            IPAddress[] ipaddress = Dns.GetHostAddresses(HostName);
            str_return = Convert.ToString(ipaddress[1]);
            return str_return;
        }
        string htmlcontent(Model_PLC_1 data, Model_PLC_1 data2, int LineRecord)
        {



            DateTime theDate = DateTime.Now;
            theDate.ToString("yyyy-MM-dd");

            string htmlString = $@"<html>
<body>
 <p><b>YF Line Production {theDate} </b></p>

<p><b>YF Flex Line Production</b></p>
<table>
<table border=0>

 <! ––this is a comment––> 


<th><b>Hours</b></th>
<th><b>Production Shift 1</b></th>
<th><b>Hours</b></th>
<th><b>Production Shift 2</b></th>
<th><b>Hours</b></th>
<th><b>Production Shift 3</b></th>



 <! ––Data 1––> 
<tr>
<td>5:00-6:00</td>
<td><center>{data.Hourly_Counter[5]}</center></td>

<td>13:00-14:00</td>
<td><center>{data.Hourly_Counter[13]}</center></td>

<td>21:00-22:00</td>
<td><center>{data.Hourly_Counter[21]}</center></td>
</tr>



<tr>
<td>6:00-7:00</td>
<td><center>{data.Hourly_Counter[6]}</center></td>

<td>14:00-15:00</td>
<td><center>{data.Hourly_Counter[14]}</center></td>

<td>22:00-23:00</td>
<td><center>{data.Hourly_Counter[22]}</center></td>
</tr>



<tr>
<td>7:00-8:00</td>
<td><center>{data.Hourly_Counter[7]}</center></td>

<td>15:00-16:00</td>
<td><center>{data.Hourly_Counter[15]}</center></td>

<td>23:00-00:00</td>
<td><center>{data.Hourly_Counter[23]}</center></td>
</tr>



<tr>
<td>8:00-9:00</td>
<td><center>{data.Hourly_Counter[8]}</center></td>

<td>16:00-17:00</td>
<td><center>{data.Hourly_Counter[16]}</center></td>

<td>00:00-1:00</td>
<td><center>{data.Hourly_Counter[0]}</center></td>
</tr>



<tr>
<td>9:00-10:00</td>
<td><center>{data.Hourly_Counter[9]}</center></td>

<td>17:00-18:00</td>
<td><center>{data.Hourly_Counter[17]}</center></td>

<td>1:00-2:00</td>
<td><center>{data.Hourly_Counter[1]}</center></td>
</tr>

<tr>
<td>10:00-11:00</td>
<td><center>{data.Hourly_Counter[10]}</center></td>

<td>18:00-19:00</td>
<td><center>{data.Hourly_Counter[18]}</center></td>

<td>2:00-3:00</td>
<td><center>{data.Hourly_Counter[2]}</center></td>
</tr>

<tr>
<td>11:00-12:00</td>
<td><center>{data.Hourly_Counter[11]}</center></td>

<td>19:00-20:00</td>
<td><center>{data.Hourly_Counter[19]}</center></td>

<td>3:00-2:00</td>
<td><center>{data.Hourly_Counter[3]}</center></td>
</tr>

<tr>
<td>12:00-13:00</td>
<td><center>{data.Hourly_Counter[12]}</center></td>
<td>20:00-21:00</td>
<td><center>{data.Hourly_Counter[20]}</center></td>
<td>4:00-5:00</td>
<td><center>{data.Hourly_Counter[4]}</center></td>
</tr>

<tr>
<td>Total Shift 1</td>
<td><center>{data.Todays_Shifts[0]}</center></td>
<td>Total Shift 2</td>
<td><center>{data.Todays_Shifts[1]}</center></td>
<td>Total Shift 3</td>
<td><center>{data.Todays_Shifts[2]}</center></td>
</tr>

<tr>
<td>Yesterday's Totals Shift 1</td>
<td><center>{data.Ydays_Shifts[0]}</center></td>
<td>Yesterday's Totals Shift 3</td>
<td><center>{data.Ydays_Shifts[1]}</center></td>
<td>Yesterday's Totals Shift 3</td>
<td><center>{data.Ydays_Shifts[2]}</center></td>
</tr>
</table>
<br>  <br/> 

<p><b>YF Main Line Production</b></p>
<br>  <br/> 
<table>
 <! ––Data 2––> 
<th><b>Hours</b></th>
<th><b>Production Shift 1</b></th>
<th><b>Hours</b></th>
<th><b>Production Shift 2</b></th>
<th><b>Hours</b></th>
<th><b>Production Shift 3</b></th>



<tr>
<td>5:00-6:00</td>
<td><center>{data2.Hourly_Counter[5]}</center></td>

<td>13:00-14:00</td>
<td><center>{data2.Hourly_Counter[13]}</center></td>

<td>21:00-22:00</td>
<td><center>{data2.Hourly_Counter[21]}</center></td>
</tr>



<tr>
<td>6:00-7:00</td>
<td><center>{data2.Hourly_Counter[6]}</center></td>

<td>14:00-15:00</td>
<td><center>{data2.Hourly_Counter[14]}</center></td>

<td>22:00-23:00</td>
<td><center>{data2.Hourly_Counter[22]}</center></td>
</tr>



<tr>
<td>7:00-8:00</td>
<td><center>{data2.Hourly_Counter[7]}</center></td>

<td>15:00-16:00</td>
<td><center>{data2.Hourly_Counter[15]}</center></td>

<td>23:00-00:00</td>
<td><center>{data2.Hourly_Counter[23]}</center></td>
</tr>



<tr>
<td>8:00-9:00</td>
<td><center>{data2.Hourly_Counter[8]}</center></td>

<td>16:00-17:00</td>
<td><center>{data2.Hourly_Counter[16]}</center></td>

<td>00:00-1:00</td>
<td><center>{data2.Hourly_Counter[0]}</center></td>
</tr>



<tr>
<td>9:00-10:00</td>
<td><center>{data2.Hourly_Counter[9]}</center></td>

<td>17:00-18:00</td>
<td><center>{data2.Hourly_Counter[17]}</center></td>

<td>1:00-2:00</td>
<td><center>{data2.Hourly_Counter[1]}</center></td>
</tr>

<tr>
<td>10:00-11:00</td>
<td><center>{data2.Hourly_Counter[10]}</center></td>

<td>18:00-19:00</td>
<td><center>{data2.Hourly_Counter[18]}</center></td>

<td>2:00-3:00</td>
<td><center>{data2.Hourly_Counter[2]}</center></td>
</tr>

<tr>
<td>11:00-12:00</td>
<td><center>{data2.Hourly_Counter[11]}</center></td>

<td>19:00-20:00</td>
<td><center>{data2.Hourly_Counter[19]}</center></td>

<td>3:00-2:00</td>
<td><center>{data2.Hourly_Counter[3]}</center></td>
</tr>

<tr>
<td>12:00-13:00</td>
<td><center>{data2.Hourly_Counter[12]}</center></td>
<td>20:00-21:00</td>
<td><center>{data2.Hourly_Counter[20]}</center></td>
<td>4:00-5:00</td>
<td><center>{data2.Hourly_Counter[4]}</center></td>
</tr>

<tr>
<td>Total Shift 1</td>
<td><center>{data2.Todays_Shifts[0]}</center></td>
<td>Total Shift 2</td>
<td><center>{data2.Todays_Shifts[1]}</center></td>
<td>Total Shift 3</td>
<td><center>{data2.Todays_Shifts[2]}</center></td>
</tr>

<tr>
<td>Yesterday's Totals Shift 1</td>
<td><center>{data2.Ydays_Shifts[0]}</center></td>
<td>Yesterday's Totals Shift 3</td>
<td><center>{data2.Ydays_Shifts[1]}</center></td>
<td>Yesterday's Totals Shift 3</td>
<td><center>{data2.Ydays_Shifts[2]}</center></td>
</tr>






</table>
<p></p>
<p></p>
<p><b>Line Record: {LineRecord} </b></p>
<p></p>
<p><b>Todal Overall Lines: {data.Todays_Total + data2.Todays_Total} </b></p>
<p></p>
<p>This has been sent by IOT Application Automatically at end of shifts<br></br></p>

<p>Host Name: {HostName} </p>
 



      </body>
</html>
             ";
            return htmlString;
        }


    }



}
