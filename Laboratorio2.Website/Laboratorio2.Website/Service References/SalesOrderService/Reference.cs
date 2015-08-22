﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Laboratorio2.Website.SalesOrderService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SalesOrderService.ISalesOrderService")]
    public interface ISalesOrderService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISalesOrderService/GetSales", ReplyAction="http://tempuri.org/ISalesOrderService/GetSalesResponse")]
        Laboratorio2.DataAccess.SalesOrder[] GetSales(System.Nullable<System.DateTime> startDate, System.Nullable<System.DateTime> endDate, string productName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISalesOrderService/GetSales", ReplyAction="http://tempuri.org/ISalesOrderService/GetSalesResponse")]
        System.Threading.Tasks.Task<Laboratorio2.DataAccess.SalesOrder[]> GetSalesAsync(System.Nullable<System.DateTime> startDate, System.Nullable<System.DateTime> endDate, string productName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISalesOrderService/GetSalesOrderDetailBySalesOrderID", ReplyAction="http://tempuri.org/ISalesOrderService/GetSalesOrderDetailBySalesOrderIDResponse")]
        Laboratorio2.DataAccess.SalesOrder[] GetSalesOrderDetailBySalesOrderID(int salesOrderID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISalesOrderService/GetSalesOrderDetailBySalesOrderID", ReplyAction="http://tempuri.org/ISalesOrderService/GetSalesOrderDetailBySalesOrderIDResponse")]
        System.Threading.Tasks.Task<Laboratorio2.DataAccess.SalesOrder[]> GetSalesOrderDetailBySalesOrderIDAsync(int salesOrderID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISalesOrderServiceChannel : Laboratorio2.Website.SalesOrderService.ISalesOrderService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SalesOrderServiceClient : System.ServiceModel.ClientBase<Laboratorio2.Website.SalesOrderService.ISalesOrderService>, Laboratorio2.Website.SalesOrderService.ISalesOrderService {
        
        public SalesOrderServiceClient() {
        }
        
        public SalesOrderServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SalesOrderServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SalesOrderServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SalesOrderServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Laboratorio2.DataAccess.SalesOrder[] GetSales(System.Nullable<System.DateTime> startDate, System.Nullable<System.DateTime> endDate, string productName) {
            return base.Channel.GetSales(startDate, endDate, productName);
        }
        
        public System.Threading.Tasks.Task<Laboratorio2.DataAccess.SalesOrder[]> GetSalesAsync(System.Nullable<System.DateTime> startDate, System.Nullable<System.DateTime> endDate, string productName) {
            return base.Channel.GetSalesAsync(startDate, endDate, productName);
        }
        
        public Laboratorio2.DataAccess.SalesOrder[] GetSalesOrderDetailBySalesOrderID(int salesOrderID) {
            return base.Channel.GetSalesOrderDetailBySalesOrderID(salesOrderID);
        }
        
        public System.Threading.Tasks.Task<Laboratorio2.DataAccess.SalesOrder[]> GetSalesOrderDetailBySalesOrderIDAsync(int salesOrderID) {
            return base.Channel.GetSalesOrderDetailBySalesOrderIDAsync(salesOrderID);
        }
    }
}