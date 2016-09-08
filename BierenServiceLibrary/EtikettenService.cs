using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BierenServiceLibrary
{
    //public class EtikettenService : IEtikettenService
    //{
    //    public void VerwijderEtikettenOuderDan(DateTime datum)
    //    {
    //        Thread.Sleep(30000);
    //        foreach (var bestandsNaam in Directory.GetFiles(@"c:\temp\etiketten"))
    //            if (File.GetLastWriteTime(bestandsNaam) < datum)
    //                File.Delete(bestandsNaam);
    //    }

    //}

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class EtikettenService : IEtikettenService
    {
        private List<IEtikettenServiceCallBack> callBackChannels = new List<IEtikettenServiceCallBack>();
        public void VerwittigAlsEtikettenVerwijderdZijn()
        {
            callBackChannels.Add(
                OperationContext.Current.GetCallbackChannel<IEtikettenServiceCallBack>());
        }
        public void StopVerwittigenAlsEtikettenVerwijderdZijn()
        {
            callBackChannels.Remove(
                OperationContext.Current.GetCallbackChannel<IEtikettenServiceCallBack>());
        }
        public void VerwijderEtikettenOuderDan(DateTime datum)
        {
            var verwijderdebestandsNamen = new List<string>();
            foreach (var bestandsNaam in Directory.GetFiles(@"c:\etiketten"))
            {
                if (File.GetLastWriteTime(bestandsNaam) < datum)
                {
                    File.Delete(bestandsNaam);
                    verwijderdebestandsNamen.Add(bestandsNaam);
                }
            }
            if (verwijderdebestandsNamen.Count != 0)
            {
                var callBackChannelsDieNietMeerReageren = new List<IEtikettenServiceCallBack>();
                foreach (var callBackChannel in callBackChannels)
                {
                    try
                    {
                        callBackChannel.EtikettenZijnVerwijderd(verwijderdebestandsNamen);
                    }
                    catch
                    {
                        callBackChannelsDieNietMeerReageren.Add(callBackChannel);
                    }
                }
                foreach (var callBackChannelsDatNietMeerReageert in callBackChannelsDieNietMeerReageren)
                {
                    callBackChannels.Remove(callBackChannelsDatNietMeerReageert);
                }
            }
        }
    }


}
