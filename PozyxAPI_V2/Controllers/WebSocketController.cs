﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Net.Http;
//using System.Web.Http;
//using RabbitMQ.Client;
//using System.Text;

//namespace PozyxAPI_V2.Controllers
//{
//    public class WebSocketController : ApiController
//    {
//        public static void Send()
//        {
//            var factory = new ConnectionFactory() { HostName = "localhost" };
//            using (var connection = factory.CreateConnection())
//            using (var channel = connection.CreateModel())
//            {
//                channel.QueueDeclare(queue: "hello",
//                                     durable: false,
//                                     exclusive: false,
//                                     autoDelete: false,
//                                     arguments: null);

//                string message = "Hello World!";
//                var body = Encoding.UTF8.GetBytes(message);

//                channel.BasicPublish(exchange: "",
//                                     routingKey: "hello",
//                                     basicProperties: null,
//                                     body: body);
//                Console.WriteLine(" [x] Sent {0}", message);
//            }

//            Console.WriteLine(" Press [enter] to exit.");
//            Console.ReadLine();
//        }

//    }
//}