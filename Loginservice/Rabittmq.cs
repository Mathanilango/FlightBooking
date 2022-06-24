using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketService.Model;

namespace Loginservice
{
    public static class Rabittmq
    {
        public static void consume(IModel model)
        {
            model.QueueDeclare("Senddata", durable: true, exclusive: false, autoDelete: false, arguments: null);
            var consumer = new EventingBasicConsumer(model);
            consumer.Received += (sender, e) =>
            {
                newtest tt = new newtest();
                // tt=e.Body
                var body = e.Body.ToArray();
                var data = Encoding.UTF8.GetString(body);
                //tt = data;
            };
            model.BasicConsume("Senddata", true, consumer);
        }
    }
}
