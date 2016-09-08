using ConsoleBierenClient.EtikettenServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleBierenClient
{
    class EtikettenServiceCallBack : IEtikettenServiceCallback
    {
        public void EtikettenZijnVerwijderd(string[] etiketten)
        {
            Console.WriteLine("Volgende etiketten zijn verwijderd");
            foreach (var etiket in etiketten)
                Console.WriteLine(etiket);
        }
    }
}
