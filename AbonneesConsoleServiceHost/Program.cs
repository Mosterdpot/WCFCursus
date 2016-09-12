using AbonneeServiceLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace AbonneesConsoleServiceHost
{
    class Program
    {
        private const string QueueName = @".\private$\abonneeservicequeue";
        static void Main(string[] args)
        {
            // queue vanuit code maken,
            // als de queue nog niet bestaat:
            if (!MessageQueue.Exists(QueueName))
                MessageQueue.Create(QueueName, true);
            using (var serviceHost = new ServiceHost(typeof(AbonneeService)))
            {
                serviceHost.Open();
                Console.WriteLine("Druk s om de service te stoppen");
                while (Console.ReadLine() != "s")
                {
                }
            }
        }
    }
}
