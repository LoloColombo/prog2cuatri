using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using SolidWorkshop.SRP.interfaces;

namespace SolidWorkshop.SRP.Implementaciones
{
    public class EmailNotificationService : INotificationService
    {
        public void SendConfirmation(Order order)
        {
            // 4) Envío de email
            try
            {
                var smtp = new SmtpClient("smtp.example.com");
                var mail = new MailMessage("sales@example.com", order.CustomerEmail);
                mail.Subject = $"Order Confirmation #{order.Id}";
                mail.Body = $"Thanks! Your total is {order.Total:C2}";
                smtp.Send(mail);
            }
            catch (Exception ex)
            {
                ConsoleLog log = new ConsoleLog();
                log.Log("[LOG] Failed to send email: " + ex.Message);
                
            }
        }
    }
}
