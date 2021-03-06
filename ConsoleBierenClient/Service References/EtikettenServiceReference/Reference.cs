﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleBierenClient.EtikettenServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://vdab.be/etikettenservice", ConfigurationName="EtikettenServiceReference.IEtikettenService", CallbackContract=typeof(ConsoleBierenClient.EtikettenServiceReference.IEtikettenServiceCallback))]
    public interface IEtikettenService {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://vdab.be/etikettenservice/IEtikettenService/VerwijderEtikettenOuderDan")]
        void VerwijderEtikettenOuderDan(System.DateTime datum);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://vdab.be/etikettenservice/IEtikettenService/VerwijderEtikettenOuderDan")]
        System.Threading.Tasks.Task VerwijderEtikettenOuderDanAsync(System.DateTime datum);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://vdab.be/etikettenservice/IEtikettenService/VerwittigAlsEtikettenVerwijderd" +
            "Zijn")]
        void VerwittigAlsEtikettenVerwijderdZijn();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://vdab.be/etikettenservice/IEtikettenService/VerwittigAlsEtikettenVerwijderd" +
            "Zijn")]
        System.Threading.Tasks.Task VerwittigAlsEtikettenVerwijderdZijnAsync();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://vdab.be/etikettenservice/IEtikettenService/StopVerwittigenAlsEtikettenVerw" +
            "ijderdZijn")]
        void StopVerwittigenAlsEtikettenVerwijderdZijn();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://vdab.be/etikettenservice/IEtikettenService/StopVerwittigenAlsEtikettenVerw" +
            "ijderdZijn")]
        System.Threading.Tasks.Task StopVerwittigenAlsEtikettenVerwijderdZijnAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEtikettenServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://vdab.be/etikettenservice/IEtikettenService/EtikettenZijnVerwijderd")]
        void EtikettenZijnVerwijderd(string[] etiketten);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEtikettenServiceChannel : ConsoleBierenClient.EtikettenServiceReference.IEtikettenService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EtikettenServiceClient : System.ServiceModel.DuplexClientBase<ConsoleBierenClient.EtikettenServiceReference.IEtikettenService>, ConsoleBierenClient.EtikettenServiceReference.IEtikettenService {
        
        public EtikettenServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public EtikettenServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public EtikettenServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public EtikettenServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public EtikettenServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void VerwijderEtikettenOuderDan(System.DateTime datum) {
            base.Channel.VerwijderEtikettenOuderDan(datum);
        }
        
        public System.Threading.Tasks.Task VerwijderEtikettenOuderDanAsync(System.DateTime datum) {
            return base.Channel.VerwijderEtikettenOuderDanAsync(datum);
        }
        
        public void VerwittigAlsEtikettenVerwijderdZijn() {
            base.Channel.VerwittigAlsEtikettenVerwijderdZijn();
        }
        
        public System.Threading.Tasks.Task VerwittigAlsEtikettenVerwijderdZijnAsync() {
            return base.Channel.VerwittigAlsEtikettenVerwijderdZijnAsync();
        }
        
        public void StopVerwittigenAlsEtikettenVerwijderdZijn() {
            base.Channel.StopVerwittigenAlsEtikettenVerwijderdZijn();
        }
        
        public System.Threading.Tasks.Task StopVerwittigenAlsEtikettenVerwijderdZijnAsync() {
            return base.Channel.StopVerwittigenAlsEtikettenVerwijderdZijnAsync();
        }
    }
}
