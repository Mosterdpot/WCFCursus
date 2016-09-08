using ConsoleBierenClient.BierenServiceReference;
using ConsoleBierenClient.EtikettenServiceReference;
using ConsoleBierenClient.RadenServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBierenClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //ToonRadenScherm();
            //ToonBierenScherm();
            //ToonEtikettenScherm();
            //ToonEtikettenMetCallbackScherm();
            ToonBierenMetFountenScherm();

        }

        private static void ToonEtikettenMetCallbackScherm()
        {
            var etikettenServiceCallBack = new EtikettenServiceCallBack();
            using (var etikettenServiceClient = new EtikettenServiceClient(
                new InstanceContext(etikettenServiceCallBack)))
            {
                etikettenServiceClient.VerwittigAlsEtikettenVerwijderdZijn();
                Console.Write("Datum tijd (druk s om te stoppen):");
                var antwoord = Console.ReadLine();
                while (antwoord != "s")
                {
                    var datum = DateTime.Parse(antwoord);
                    etikettenServiceClient.VerwijderEtikettenOuderDan(datum);
                    Console.Write("Datum tijd (druk s om te stoppen):");
                    antwoord = Console.ReadLine();
                }
                etikettenServiceClient.StopVerwittigenAlsEtikettenVerwijderdZijn();
            }
        }

        private static void ToonEtikettenScherm()
        {
            //using (var etikettenServiceClient = new EtikettenServiceClient())
            //{
            //    Console.Write("Datum tijd:");
            //    var datum = DateTime.Parse(Console.ReadLine());
            //    etikettenServiceClient.VerwijderEtikettenOuderDan(datum);
            //}
        }

        private static void ToonBierenScherm()
        {
            using (var bierenServiceClient = new BierenServiceClient("httpBieren"))
            {
                Console.WriteLine("Aantal bieren: {0}",
                bierenServiceClient.GetTotaalAantalBieren());
                Console.Write("Van alcohol:");
                var van = Decimal.Parse(Console.ReadLine());
                Console.Write("Tot alcohol:");
                var tot = Decimal.Parse(Console.ReadLine());
                Console.WriteLine("Aantal bieren: {0}",
                bierenServiceClient.GetAantalBierenTussenAlcohol(van, tot));
                Console.Write("Woord:");
                var woord = Console.ReadLine();
                var bieren = bierenServiceClient.GetBierenMetWoord(woord);
                foreach (var bier in bieren)
                {
                    Console.WriteLine("{0} {1} {2}%", bier.BierNr, bier.Naam, bier.Alcohol);
                }
                Console.WriteLine();
                foreach (var bier in bierenServiceClient.GetStrafsteBieren())
                {
                    Console.WriteLine("{0} {1} {2}%", bier.BierNr, bier.Naam, bier.Alcohol);
                }

            }
            Console.ReadLine();
        }

        private static void ToonBierenMetFountenScherm()
        {
            var bierenServiceClient = new BierenServiceClient("httpBieren");
            try
            {
                Console.WriteLine("Van Alcohol :");
                var van = Decimal.Parse(Console.ReadLine());
                Console.Write("Tot alcohol:");
                var tot = Decimal.Parse(Console.ReadLine());
                Console.WriteLine("Aantal bieren: {0}", bierenServiceClient.GetAantalBierenTussenAlcohol(van, tot));

            }
            catch (FaultException)
            {
                Console.WriteLine("Kan bieren niet ophalen");
            }
            finally {
                if (bierenServiceClient.State == CommunicationState.Faulted)
                {
                    bierenServiceClient.Abort();
                }
                else
                {
                    bierenServiceClient.Close();
                }
            }
        }

        private static void ToonRadenScherm()
        {
            using (var radenServiceClient = new RadenServiceClient())
            {
                Console.WriteLine("Raad het alcohol% van Duvel");
                var alcohol = Decimal.Parse(Console.ReadLine());
                var antwoord = radenServiceClient.RaadDuvelAlcohol(alcohol);
                while (antwoord.Hint != Hint.Correct)
                {
                    Console.WriteLine("{0}, {1} beurt(en)", antwoord.Hint, antwoord.Beurten);
                    alcohol = Decimal.Parse(Console.ReadLine());
                    antwoord = radenServiceClient.RaadDuvelAlcohol(alcohol);
                }
                Console.WriteLine("{0}, {1} beurt(en)", antwoord.Hint, antwoord.Beurten);

                Console.WriteLine("Beste score:{0}", antwoord.BesteScore);
            }
            Console.ReadLine();
        }
    }
}
