using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace _10K_5
{
    public class EmailHandler
    {
        public string Send_Email_With_Given_Parameters(string Email_Account,
            string Email_Pass, string SMTP_Server_Port,
            string SMTP_Server_Host, bool SMTP_Server_Enable_SSL,
            bool Include_Attachment, string Attachment_Path,
            string Email_From_Address, string Email_To_Address,
            string Email_Message, string Email_Subject)
        {

            // try
            //  {
            SmtpClient Smtp_Server = new SmtpClient();
            MailMessage e_mail = new MailMessage();
            Smtp_Server.UseDefaultCredentials = false;
            Smtp_Server.Credentials = new NetworkCredential(Email_Account, Email_Pass);
            Smtp_Server.Port = 587;
            Smtp_Server.EnableSsl = true;
            Smtp_Server.Host = "smtp.gmail.com";




            e_mail = new MailMessage();

            ////Decide on whether to include attachment
            //if (Include_Attachment == true)
            //{
            //    System.Net.Mail.Attachment attachment = default(System.Net.Mail.Attachment);
            //    attachment = new System.Net.Mail.Attachment(Attachment_Path);
            //    //"C:\Users\TRIUMPH\Documents\doc2.docx")

            //    e_mail.Attachments.Add(attachment);

            //}

            e_mail.From = new MailAddress(Email_From_Address);
            e_mail.To.Add(Email_To_Address);
            e_mail.Subject = Email_Subject;
            e_mail.IsBodyHtml = false;
            e_mail.Body = Email_Message;
            Smtp_Server.Send(e_mail);

            // SentListBoxDisplay.Items.Add(Email_To_Address & " " & Email_Subject)

            return "Mail Sent";

            //   }
            //catch (Exception error_t)
            //{
            //    // NotSentListboxDisplay.Items.Add(Email_To_Address & " " & Email_Subject)

            //    return error_t.ToString;
            //}

        }
    }
}