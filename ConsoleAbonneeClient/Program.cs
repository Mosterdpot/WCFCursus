using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using ConsoleAbonneeClient;
using ConsoleAbonneeClient.AbonneeServiceReference;

namespace ConsoleAbonneeClient
{
    class Program
    {
        static void Main(string[] args)
        {
            var abonneeServiceClient = new AbonneeServiceClient();
            try
            {
                Console.Write("Voornaam (Tik s om te stoppen):");
                var voornaam = Console.ReadLine();
                while (voornaam != "s")
                {
                    Console.Write("Familienaam:");
                    var familienaam = Console.ReadLine();
                    Console.Write("EmailAdres:");
                    var emailAdres = Console.ReadLine();
                    var persoon = new Persoon { Voornaam = voornaam, Familienaam = familienaam, EmailAdres = emailAdres };
                    abonneeServiceClient.VoegPersoonToe(persoon);
                    Console.Write("Voornaam (Tik s om te stoppen):");
                    voornaam = Console.ReadLine();
                }
            }
            catch (FaultException)
            {
                Console.WriteLine("Kan abonnee niet toevoegen");
            }
            finally
            {
                if (abonneeServiceClient.State == CommunicationState.Faulted)
                    abonneeServiceClient.Abort();
                else
                    abonneeServiceClient.Close();
            }
        }
    }
}
