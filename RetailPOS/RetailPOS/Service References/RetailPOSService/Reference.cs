﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RetailPOS.RetailPOSService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="RetailPOSService.IRetailPOSServiceContract")]
    public interface IRetailPOSServiceContract {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRetailPOSServiceContract/GetCategories", ReplyAction="http://tempuri.org/IRetailPOSServiceContract/GetCategoriesResponse")]
        RetailPOS.CommonLayer.DataTransferObjects.ProductCategoryDTO[] GetCategories();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRetailPOSServiceContract/GetProductByCategory", ReplyAction="http://tempuri.org/IRetailPOSServiceContract/GetProductByCategoryResponse")]
        RetailPOS.CommonLayer.DataTransferObjects.ProductDTO[] GetProductByCategory(int categoryId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRetailPOSServiceContractChannel : RetailPOS.RetailPOSService.IRetailPOSServiceContract, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RetailPOSServiceContractClient : System.ServiceModel.ClientBase<RetailPOS.RetailPOSService.IRetailPOSServiceContract>, RetailPOS.RetailPOSService.IRetailPOSServiceContract {
        
        public RetailPOSServiceContractClient() {
        }
        
        public RetailPOSServiceContractClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RetailPOSServiceContractClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RetailPOSServiceContractClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RetailPOSServiceContractClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public RetailPOS.CommonLayer.DataTransferObjects.ProductCategoryDTO[] GetCategories() {
            return base.Channel.GetCategories();
        }
        
        public RetailPOS.CommonLayer.DataTransferObjects.ProductDTO[] GetProductByCategory(int categoryId) {
            return base.Channel.GetProductByCategory(categoryId);
        }
    }
}
