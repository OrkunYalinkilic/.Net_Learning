using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            EMailGonder("orkunyalinkilic@gmail.com", "Udemy - EMail Gönderme İşlemleri - 1", "Merhaba Orkun Yalınkılıç");
        }

        static void EMailGonder(string kime, string konu, string icerik)
        {
            Encoding encode = Encoding.GetEncoding("windows-1254"); // türkçe karakter desteği sağlar.

            MailAddress to1 = new MailAddress("orkunyalinkilic69@gmail.com", "Orkun Yalınkılıç", encode); // kime gidecek
            MailAddress MailFrom = new MailAddress("yalinkilic.orkun@std.izu.edu.tr", "Orkun Bilgilendirme", encode);
            MailMessage EMail = new MailMessage();
            EMail.To.Add(kime); 
            EMail.To.Add(to1);
            EMail.From = MailFrom;


            // cc: mesaj iletildi gibi bilgi verir. bcc: karşoya mail gittiğinde bcc ye eklenen kişiler görükmez.

            //EMail.CC.Add(); Email içersinde tanımlı olan kişi veya kişileri görebilir.
            //EMail.Bcc.Add(); Bu alanda kişi eklenen kişileri göremez.

            EMail.Subject = konu;
            EMail.Body = icerik;
            EMail.IsBodyHtml = true; // email içerisinin html formatta olacağını belirtmiş oluruz.

            EMail.Attachments.Add(@"c:\udemy\exceldosyasi.xlsx");

            SmtpClient smtpMail = new SmtpClient("mail.hotmail.com", 587); // 25 olarak da denenebilir.
            smtpMail.Credentials = new System.Net.NetworkCredential("orkunyalinkilic034@hotmail.com", "2**");
            smtpMail.EnableSsl = false;
            smtpMail.Send(EMail);
        } 

    }
}
