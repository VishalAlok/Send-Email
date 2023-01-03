using System;
using System.Net;
using System.Net.Mail;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set the from and to addresses
            MailAddress from = new MailAddress("from@example.com", "Sender Name");
            MailAddress to = new MailAddress("to@example.com", "Receiver Name");

            // Set the email's subject and message
            string subject = "Hello World!";
            string body = "This is a test email.";

            // Create a new MailMessage object
            MailMessage message = new MailMessage(from, to);
            message.Subject = subject;
            message.Body = body;

            // Set the SMTP server and credentials
            SmtpClient client = new SmtpClient("smtp.example.com");
            client.Credentials = new NetworkCredential("username", "password");

            // Send the email
            client.Send(message);

            // Display a success message
            Console.WriteLine("Email sent!");
        }
    }
}
