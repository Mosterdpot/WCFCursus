using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BierenServiceLibrary
{
    public enum Hint
    {
        Hoger, Lager, Correct
    }

    [DataContract]
    public class RaadResultaat
    {
        [DataMember]
        public Hint Hint { get; set; }
        [DataMember]
        public int Beurten { get; set; }
        [DataMember]
        public int BesteScore { get; set; }
    }
}
