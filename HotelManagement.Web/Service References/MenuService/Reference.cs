﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelManagement.Web.MenuService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MenuService.IMenuService")]
    public interface IMenuService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMenuService/GetAll", ReplyAction="http://tempuri.org/IMenuService/GetAllResponse")]
        HotelManagement.DTO.MenuDTO[] GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMenuService/GetMenu", ReplyAction="http://tempuri.org/IMenuService/GetMenuResponse")]
        HotelManagement.DTO.MenuDTO GetMenu(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMenuService/Save", ReplyAction="http://tempuri.org/IMenuService/SaveResponse")]
        void Save(HotelManagement.DTO.MenuDTO obj);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMenuService/Delete", ReplyAction="http://tempuri.org/IMenuService/DeleteResponse")]
        void Delete(HotelManagement.DTO.MenuDTO obj);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMenuServiceChannel : HotelManagement.Web.MenuService.IMenuService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MenuServiceClient : System.ServiceModel.ClientBase<HotelManagement.Web.MenuService.IMenuService>, HotelManagement.Web.MenuService.IMenuService {
        
        public MenuServiceClient() {
        }
        
        public MenuServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MenuServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MenuServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MenuServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public HotelManagement.DTO.MenuDTO[] GetAll() {
            return base.Channel.GetAll();
        }
        
        public HotelManagement.DTO.MenuDTO GetMenu(int id) {
            return base.Channel.GetMenu(id);
        }
        
        public void Save(HotelManagement.DTO.MenuDTO obj) {
            base.Channel.Save(obj);
        }
        
        public void Delete(HotelManagement.DTO.MenuDTO obj) {
            base.Channel.Delete(obj);
        }
    }
}
