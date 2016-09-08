﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleBierenClient.BierenServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="AlcoholFout", Namespace="http://schemas.datacontract.org/2004/07/BierenServiceLibrary")]
    [System.SerializableAttribute()]
    public partial class AlcoholFout : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string[] VerkeerdeParametersField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] VerkeerdeParameters {
            get {
                return this.VerkeerdeParametersField;
            }
            set {
                if ((object.ReferenceEquals(this.VerkeerdeParametersField, value) != true)) {
                    this.VerkeerdeParametersField = value;
                    this.RaisePropertyChanged("VerkeerdeParameters");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Bier", Namespace="http://schemas.datacontract.org/2004/07/BierenServiceLibrary")]
    [System.SerializableAttribute()]
    public partial class Bier : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal AlcoholField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int BierNrField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NaamField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Alcohol {
            get {
                return this.AlcoholField;
            }
            set {
                if ((this.AlcoholField.Equals(value) != true)) {
                    this.AlcoholField = value;
                    this.RaisePropertyChanged("Alcohol");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int BierNr {
            get {
                return this.BierNrField;
            }
            set {
                if ((this.BierNrField.Equals(value) != true)) {
                    this.BierNrField = value;
                    this.RaisePropertyChanged("BierNr");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Naam {
            get {
                return this.NaamField;
            }
            set {
                if ((object.ReferenceEquals(this.NaamField, value) != true)) {
                    this.NaamField = value;
                    this.RaisePropertyChanged("Naam");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://vdab.be/bierenservice", ConfigurationName="BierenServiceReference.IBierenService")]
    public interface IBierenService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://vdab.be/bierenservice/IBierenService/GetTotaalAantalBieren", ReplyAction="http://vdab.be/bierenservice/IBierenService/GetTotaalAantalBierenResponse")]
        int GetTotaalAantalBieren();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://vdab.be/bierenservice/IBierenService/GetTotaalAantalBieren", ReplyAction="http://vdab.be/bierenservice/IBierenService/GetTotaalAantalBierenResponse")]
        System.Threading.Tasks.Task<int> GetTotaalAantalBierenAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://vdab.be/bierenservice/IBierenService/GetAantalBierenTussenAlcohol", ReplyAction="http://vdab.be/bierenservice/IBierenService/GetAantalBierenTussenAlcoholResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(ConsoleBierenClient.BierenServiceReference.AlcoholFout), Action="http://vdab.be/bierenservice/IBierenService/GetAantalBierenTussenAlcoholAlcoholFo" +
            "utFault", Name="AlcoholFout", Namespace="http://schemas.datacontract.org/2004/07/BierenServiceLibrary")]
        int GetAantalBierenTussenAlcohol(decimal van, decimal tot);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://vdab.be/bierenservice/IBierenService/GetAantalBierenTussenAlcohol", ReplyAction="http://vdab.be/bierenservice/IBierenService/GetAantalBierenTussenAlcoholResponse")]
        System.Threading.Tasks.Task<int> GetAantalBierenTussenAlcoholAsync(decimal van, decimal tot);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://vdab.be/bierenservice/IBierenService/GetBierenMetWoord", ReplyAction="http://vdab.be/bierenservice/IBierenService/GetBierenMetWoordResponse")]
        ConsoleBierenClient.BierenServiceReference.Bier[] GetBierenMetWoord(string woord);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://vdab.be/bierenservice/IBierenService/GetBierenMetWoord", ReplyAction="http://vdab.be/bierenservice/IBierenService/GetBierenMetWoordResponse")]
        System.Threading.Tasks.Task<ConsoleBierenClient.BierenServiceReference.Bier[]> GetBierenMetWoordAsync(string woord);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://vdab.be/bierenservice/IBierenService/GetStrafsteBieren", ReplyAction="http://vdab.be/bierenservice/IBierenService/GetStrafsteBierenResponse")]
        ConsoleBierenClient.BierenServiceReference.Bier[] GetStrafsteBieren();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://vdab.be/bierenservice/IBierenService/GetStrafsteBieren", ReplyAction="http://vdab.be/bierenservice/IBierenService/GetStrafsteBierenResponse")]
        System.Threading.Tasks.Task<ConsoleBierenClient.BierenServiceReference.Bier[]> GetStrafsteBierenAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBierenServiceChannel : ConsoleBierenClient.BierenServiceReference.IBierenService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BierenServiceClient : System.ServiceModel.ClientBase<ConsoleBierenClient.BierenServiceReference.IBierenService>, ConsoleBierenClient.BierenServiceReference.IBierenService {
        
        public BierenServiceClient() {
        }
        
        public BierenServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BierenServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BierenServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BierenServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int GetTotaalAantalBieren() {
            return base.Channel.GetTotaalAantalBieren();
        }
        
        public System.Threading.Tasks.Task<int> GetTotaalAantalBierenAsync() {
            return base.Channel.GetTotaalAantalBierenAsync();
        }
        
        public int GetAantalBierenTussenAlcohol(decimal van, decimal tot) {
            return base.Channel.GetAantalBierenTussenAlcohol(van, tot);
        }
        
        public System.Threading.Tasks.Task<int> GetAantalBierenTussenAlcoholAsync(decimal van, decimal tot) {
            return base.Channel.GetAantalBierenTussenAlcoholAsync(van, tot);
        }
        
        public ConsoleBierenClient.BierenServiceReference.Bier[] GetBierenMetWoord(string woord) {
            return base.Channel.GetBierenMetWoord(woord);
        }
        
        public System.Threading.Tasks.Task<ConsoleBierenClient.BierenServiceReference.Bier[]> GetBierenMetWoordAsync(string woord) {
            return base.Channel.GetBierenMetWoordAsync(woord);
        }
        
        public ConsoleBierenClient.BierenServiceReference.Bier[] GetStrafsteBieren() {
            return base.Channel.GetStrafsteBieren();
        }
        
        public System.Threading.Tasks.Task<ConsoleBierenClient.BierenServiceReference.Bier[]> GetStrafsteBierenAsync() {
            return base.Channel.GetStrafsteBierenAsync();
        }
    }
}
