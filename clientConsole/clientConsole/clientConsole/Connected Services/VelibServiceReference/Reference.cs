﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace clientConsole.VelibServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="VelibStation", Namespace="http://schemas.datacontract.org/2004/07/VelibSoapService")]
    [System.SerializableAttribute()]
    public partial class VelibStation : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string addressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int availableBikesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool bankingField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int numberOfPointAttacheField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int numberOfPointAttacheAvailableField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string stationNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int stationNumberField;
        
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
        public string address {
            get {
                return this.addressField;
            }
            set {
                if ((object.ReferenceEquals(this.addressField, value) != true)) {
                    this.addressField = value;
                    this.RaisePropertyChanged("address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int availableBikes {
            get {
                return this.availableBikesField;
            }
            set {
                if ((this.availableBikesField.Equals(value) != true)) {
                    this.availableBikesField = value;
                    this.RaisePropertyChanged("availableBikes");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool banking {
            get {
                return this.bankingField;
            }
            set {
                if ((this.bankingField.Equals(value) != true)) {
                    this.bankingField = value;
                    this.RaisePropertyChanged("banking");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int numberOfPointAttache {
            get {
                return this.numberOfPointAttacheField;
            }
            set {
                if ((this.numberOfPointAttacheField.Equals(value) != true)) {
                    this.numberOfPointAttacheField = value;
                    this.RaisePropertyChanged("numberOfPointAttache");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int numberOfPointAttacheAvailable {
            get {
                return this.numberOfPointAttacheAvailableField;
            }
            set {
                if ((this.numberOfPointAttacheAvailableField.Equals(value) != true)) {
                    this.numberOfPointAttacheAvailableField = value;
                    this.RaisePropertyChanged("numberOfPointAttacheAvailable");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string stationName {
            get {
                return this.stationNameField;
            }
            set {
                if ((object.ReferenceEquals(this.stationNameField, value) != true)) {
                    this.stationNameField = value;
                    this.RaisePropertyChanged("stationName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int stationNumber {
            get {
                return this.stationNumberField;
            }
            set {
                if ((this.stationNumberField.Equals(value) != true)) {
                    this.stationNumberField = value;
                    this.RaisePropertyChanged("stationNumber");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="VelibServiceReference.IVelibService")]
    public interface IVelibService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVelibService/getStations", ReplyAction="http://tempuri.org/IVelibService/getStationsResponse")]
        clientConsole.VelibServiceReference.VelibStation[] getStations(string cityID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVelibService/getStations", ReplyAction="http://tempuri.org/IVelibService/getStationsResponse")]
        System.Threading.Tasks.Task<clientConsole.VelibServiceReference.VelibStation[]> getStationsAsync(string cityID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVelibService/getStation", ReplyAction="http://tempuri.org/IVelibService/getStationResponse")]
        clientConsole.VelibServiceReference.VelibStation getStation(string cityID, int stationID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVelibService/getStation", ReplyAction="http://tempuri.org/IVelibService/getStationResponse")]
        System.Threading.Tasks.Task<clientConsole.VelibServiceReference.VelibStation> getStationAsync(string cityID, int stationID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IVelibServiceChannel : clientConsole.VelibServiceReference.IVelibService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class VelibServiceClient : System.ServiceModel.ClientBase<clientConsole.VelibServiceReference.IVelibService>, clientConsole.VelibServiceReference.IVelibService {
        
        public VelibServiceClient() {
        }
        
        public VelibServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public VelibServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public VelibServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public VelibServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public clientConsole.VelibServiceReference.VelibStation[] getStations(string cityID) {
            return base.Channel.getStations(cityID);
        }
        
        public System.Threading.Tasks.Task<clientConsole.VelibServiceReference.VelibStation[]> getStationsAsync(string cityID) {
            return base.Channel.getStationsAsync(cityID);
        }
        
        public clientConsole.VelibServiceReference.VelibStation getStation(string cityID, int stationID) {
            return base.Channel.getStation(cityID, stationID);
        }
        
        public System.Threading.Tasks.Task<clientConsole.VelibServiceReference.VelibStation> getStationAsync(string cityID, int stationID) {
            return base.Channel.getStationAsync(cityID, stationID);
        }
    }
}
