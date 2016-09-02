﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace BierenServiceLibrary
{
    [ServiceContract(Namespace="http://vdab.be/bierenservice")]
    public interface IBierenService
    {
        int GetTotaalAantalBieren();
        int GetAantalBierenTussenAlcohol(decimal van, decimal tot);
        List<Bier> GetBierenMetWoord(string woord);
    }
}
