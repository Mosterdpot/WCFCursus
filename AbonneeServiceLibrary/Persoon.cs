using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace AbonneeServiceLibrary
{
    [DataContract]
    public class Persoon
    {
        [DataMember]
        public string Voornaam { get; set; }
        [DataMember]
        public string Familienaam { get; set; }
        [DataMember]
        public string EmailAdres { get; set; }
    }
}
