﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelManagement.Web.HotelService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="HotelDTO", Namespace="http://schemas.datacontract.org/2004/07/HotelManagement.ServiceApp.DTO")]
    [System.SerializableAttribute()]
    public partial class HotelDTO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Address1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Address2Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Address3Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Address4Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Address5Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private HotelManagement.Web.HotelService.HotelChainDTO HotelChainDTOField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool InOperationField;
        
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
        public string Address1 {
            get {
                return this.Address1Field;
            }
            set {
                if ((object.ReferenceEquals(this.Address1Field, value) != true)) {
                    this.Address1Field = value;
                    this.RaisePropertyChanged("Address1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Address2 {
            get {
                return this.Address2Field;
            }
            set {
                if ((object.ReferenceEquals(this.Address2Field, value) != true)) {
                    this.Address2Field = value;
                    this.RaisePropertyChanged("Address2");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Address3 {
            get {
                return this.Address3Field;
            }
            set {
                if ((object.ReferenceEquals(this.Address3Field, value) != true)) {
                    this.Address3Field = value;
                    this.RaisePropertyChanged("Address3");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Address4 {
            get {
                return this.Address4Field;
            }
            set {
                if ((object.ReferenceEquals(this.Address4Field, value) != true)) {
                    this.Address4Field = value;
                    this.RaisePropertyChanged("Address4");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Address5 {
            get {
                return this.Address5Field;
            }
            set {
                if ((object.ReferenceEquals(this.Address5Field, value) != true)) {
                    this.Address5Field = value;
                    this.RaisePropertyChanged("Address5");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public HotelManagement.Web.HotelService.HotelChainDTO HotelChainDTO {
            get {
                return this.HotelChainDTOField;
            }
            set {
                if ((object.ReferenceEquals(this.HotelChainDTOField, value) != true)) {
                    this.HotelChainDTOField = value;
                    this.RaisePropertyChanged("HotelChainDTO");
                }
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
        public bool InOperation {
            get {
                return this.InOperationField;
            }
            set {
                if ((this.InOperationField.Equals(value) != true)) {
                    this.InOperationField = value;
                    this.RaisePropertyChanged("InOperation");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="HotelService.IHotelService")]
    public interface IHotelService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHotelService/GetAll", ReplyAction="http://tempuri.org/IHotelService/GetAllResponse")]
        HotelManagement.Web.HotelService.HotelDTO[] GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHotelService/GetHotel", ReplyAction="http://tempuri.org/IHotelService/GetHotelResponse")]
        HotelManagement.Web.HotelService.HotelDTO GetHotel(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHotelService/Save", ReplyAction="http://tempuri.org/IHotelService/SaveResponse")]
        void Save(HotelManagement.Web.HotelService.HotelDTO obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IHotelService/Delete", ReplyAction="http://tempuri.org/IHotelService/DeleteResponse")]
        void Delete(HotelManagement.Web.HotelService.HotelDTO obj);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IHotelServiceChannel : HotelManagement.Web.HotelService.IHotelService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HotelServiceClient : System.ServiceModel.ClientBase<HotelManagement.Web.HotelService.IHotelService>, HotelManagement.Web.HotelService.IHotelService {
        
        public HotelServiceClient() {
        }
        
        public HotelServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public HotelServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HotelServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HotelServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public HotelManagement.Web.HotelService.HotelDTO[] GetAll() {
            return base.Channel.GetAll();
        }
        
        public HotelManagement.Web.HotelService.HotelDTO GetHotel(int id) {
            return base.Channel.GetHotel(id);
        }
        
        public void Save(HotelManagement.Web.HotelService.HotelDTO obj) {
            base.Channel.Save(obj);
        }
        
        public void Delete(HotelManagement.Web.HotelService.HotelDTO obj) {
            base.Channel.Delete(obj);
        }
    }
}
