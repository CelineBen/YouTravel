using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ContactUsSubmit_Click(object sender, EventArgs e)
        {
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com",587); 
            MailMessage message = new MailMessage(); 
            try {
                MailAddress fromAddress = new MailAddress(YourEmail.Text.ToString(), "Sender"); 
                MailAddress toAddress = new MailAddress("celine.bensoussan@gmail.com", "Recipient"); 
                message.From = fromAddress; 
                message.To.Add(toAddress); 
                message.Subject = "Message via YouTravel from " + YourName.Text.ToString();
                message.Body = YourMessage.Text.ToString();
                smtpClient.EnableSsl = true;
                //Enter gmail username and password for it to work.
                smtpClient.Credentials = new System.Net.NetworkCredential("username", "password"); 
                smtpClient.Send(message);
                AnswerMessage.Text = "Message sent.";
            }
            catch (Exception ex) {
                AnswerMessage.Text = "Your message could not be sent!";
            }
        }
    }
}