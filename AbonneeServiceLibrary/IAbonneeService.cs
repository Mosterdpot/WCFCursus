using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace AbonneeServiceLibrary
{

    [ServiceContract(Namespace="http://vdab.be/abonneeservice")]
    public interface IAbonneeService
    {
        [OperationContract(IsOneWay = true)]
        void VoegPersoonToe(Persoon persoon);
    }
}
