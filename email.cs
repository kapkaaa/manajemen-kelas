using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Manajemen_kelas
{
    public class email
    {
        public void SendEmail(string emailTujuan, string tokenn, string username)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("erpeel018@gmail.com"); // Ganti dengan email kamu
                mail.To.Add(emailTujuan);
                mail.Subject = "Token Login Anda";
                mail.IsBodyHtml = true;
                mail.Body = "Halo " + username + ",<br><br>" +
                            "Kami mengirimkan token untuk login ke akun Anda.<br><br>" +
                             "<b><span style='font-size:24px; color:black;'>Token: " + tokenn + "</span></b><br><br>" +
                            "Mohon jangan membagikan token ini kepada siapa pun.<br><br>" +
                            "Token ini berlaku selama 5 menit.<br><br>" +
                            "Jika Anda tidak meminta token ini, abaikan pesan ini.<br><br>" +
                            "Terima kasih.<br><br>" +
                            "Hormat kami,<br><br>" +
                            "Tim Manajemen Kelas";

                smtpServer.Port = 587;
                smtpServer.Credentials = new NetworkCredential("erpeel018@gmail.com", "zjmknqxgqgsdksul"); // Ganti dengan email & app password kamu
                smtpServer.EnableSsl = true;

                smtpServer.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengirim email: " + ex.Message);
            }
        }
    }
}
