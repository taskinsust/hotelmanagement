﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelManagement.Web.HotelChainService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="HotelChainDTO", Namespace="http://schemas.datacontract.org/2004/07/HotelManagement.ServiceApp.DTO")]
    [System.SerializableAttribute()]
    public partial class HotelChainDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="HotelChainService.IHotelChainService")]
    public interface IHotelChainService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHotelChainService/GetAll", ReplyAction="http://tempuri.org/IHotelChainService/GetAllResponse")]
        HotelManagement.Web.HotelChainService.HotelChainDTO[] GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHotelChainService/GetHotelChain", ReplyAction="http://tempuri.org/IHotelChainService/GetHotelChainResponse")]
        HotelManagement.Web.HotelChainService.HotelChainDTO GetHotelChain(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHotelChainService/Save", ReplyAction="http://tempuri.org/IHotelChainService/SaveResponse")]
        void Save(HotelManagement.Web.HotelChainService.HotelChainDTO obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHotelChainService/Delete", ReplyAction="http://tempuri.org/IHotelChainService/DeleteResponse")]
        void Delete(HotelManagement.Web.HotelChainService.HotelChainDTO obj);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IHotelChainServiceChannel : HotelManagement.Web.HotelChainService.IHotelChainService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HotelChainServiceClient : System.ServiceModel.ClientBase<HotelManagement.Web.HotelChainService.IHotelChainService>, HotelManagement.Web.HotelChainService.IHotelChainService {
        
        public HotelChainServiceClient() {
        }
        
        public HotelChainServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public HotelChainServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HotelChainServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HotelChainServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public HotelManagement.Web.HotelChainService.HotelChainDTO[] GetAll() {
            return base.Channel.GetAll();
        }
        
        public HotelManagement.Web.HotelChainService.HotelChainDTO GetHotelChain(int id) {
            return base.Channel.GetHotelChain(id);
        }
        
        public void Save(HotelManagement.Web.HotelChainService.HotelChainDTO obj) {
            base.Channel.Save(obj);
        }
        
        public void Delete(HotelManagement.Web.HotelChainService.HotelChainDTO obj) {
            base.Channel.Delete(obj);
        }
    }
}
