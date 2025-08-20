using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Mail;
using SolidWorkshop.SRP.interfaces;

namespace SolidWorkshop.SRP
{

    // Clase "Dios"
    public class OrderProcessor
    {
        private IOrderValidator Validator;
        private IOrderRepository Repository;
        private INotificationService notification;
        private ILogger logger;

        public OrderProcessor(IOrderValidator Validator, IOrderRepository Repository, INotificationService notification, ILogger logger)
        {
            this.Validator = Validator;
            this.Repository = Repository;
            this.notification = notification;
            this.logger = logger;
        }

        public void Process(Order order)
        {
            Validator.Validation(order);
            logger.Log($"[LOG] Processing order {order.Id} at {DateTime.UtcNow:o}");
            Repository.Save(order);
            notification.SendConfirmation(order);
            logger.Log($"[LOG] Order {order.Id} processed successfully.");
        }
    }
}
