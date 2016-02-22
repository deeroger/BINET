﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BINET.Web.Services.CronogramaWS {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CronogramaWS.ICronogramasService")]
    public interface ICronogramasService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICronogramasService/ConsultarCronograma", ReplyAction="http://tempuri.org/ICronogramasService/ConsultarCronogramaResponse")]
        BINET.Entities.Cronogramas[] ConsultarCronograma(int prestamo, int cliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICronogramasService/ConsultarCronograma", ReplyAction="http://tempuri.org/ICronogramasService/ConsultarCronogramaResponse")]
        System.Threading.Tasks.Task<BINET.Entities.Cronogramas[]> ConsultarCronogramaAsync(int prestamo, int cliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICronogramasService/RegistrarCronograma", ReplyAction="http://tempuri.org/ICronogramasService/RegistrarCronogramaResponse")]
        BINET.Entities.Cronogramas[] RegistrarCronograma(int prestamo, int cliente, int cuotas, System.DateTime fechaini, decimal monto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICronogramasService/RegistrarCronograma", ReplyAction="http://tempuri.org/ICronogramasService/RegistrarCronogramaResponse")]
        System.Threading.Tasks.Task<BINET.Entities.Cronogramas[]> RegistrarCronogramaAsync(int prestamo, int cliente, int cuotas, System.DateTime fechaini, decimal monto);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICronogramasServiceChannel : BINET.Web.Services.CronogramaWS.ICronogramasService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CronogramasServiceClient : System.ServiceModel.ClientBase<BINET.Web.Services.CronogramaWS.ICronogramasService>, BINET.Web.Services.CronogramaWS.ICronogramasService {
        
        public CronogramasServiceClient() {
        }
        
        public CronogramasServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CronogramasServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CronogramasServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CronogramasServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public BINET.Entities.Cronogramas[] ConsultarCronograma(int prestamo, int cliente) {
            return base.Channel.ConsultarCronograma(prestamo, cliente);
        }
        
        public System.Threading.Tasks.Task<BINET.Entities.Cronogramas[]> ConsultarCronogramaAsync(int prestamo, int cliente) {
            return base.Channel.ConsultarCronogramaAsync(prestamo, cliente);
        }
        
        public BINET.Entities.Cronogramas[] RegistrarCronograma(int prestamo, int cliente, int cuotas, System.DateTime fechaini, decimal monto) {
            return base.Channel.RegistrarCronograma(prestamo, cliente, cuotas, fechaini, monto);
        }
        
        public System.Threading.Tasks.Task<BINET.Entities.Cronogramas[]> RegistrarCronogramaAsync(int prestamo, int cliente, int cuotas, System.DateTime fechaini, decimal monto) {
            return base.Channel.RegistrarCronogramaAsync(prestamo, cliente, cuotas, fechaini, monto);
        }
    }
}
