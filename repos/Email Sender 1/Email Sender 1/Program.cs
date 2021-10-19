using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Email_Sender_1
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection("Server=DESKTOP-5SIR5IV;Database=Falik Family;Integrated Security=true");
            conn.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Kids", conn);

            SqlDataReader reader = cmd.ExecuteReader();



            while (reader.Read())
            {
                if (reader.GetString(0) == "Meir Simcha")
                {
                    string emailAddress = "falikyakov@gmail.com";
                    string emailBody = "Time to renew your policy.";
                    string emailSubject = "Policy Renewl";
                    var message = new MailMessage(emailAddress, reader.GetString(4));
                    message.Subject = emailSubject;
                    message.Body = emailBody;

                    using (SmtpClient mailer = new SmtpClient("smtp.gmail.com", 567))
                    {
                        mailer.Credentials = new NetworkCredential(emailAddress, "falik9920835");
                        mailer.EnableSsl = true;
                        mailer.Send(message);
                    }

                    Console.WriteLine("done");

                }
                else { Console.WriteLine("else"); }

            }

            Console.ReadLine();
        }
    }
}
