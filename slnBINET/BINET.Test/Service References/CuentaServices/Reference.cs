﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BINET.Test.CuentaServices {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CuentaServices.ICuentasService")]
    public interface ICuentasService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICuentasService/ObtenerCuentas", ReplyAction="http://tempuri.org/ICuentasService/ObtenerCuentasResponse")]
        BINET.Entities.Cuenta[] ObtenerCuentas(int cliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICuentasService/ObtenerCuentas", ReplyAction="http://tempuri.org/ICuentasService/ObtenerCuentasResponse")]
        System.Threading.Tasks.Task<BINET.Entities.Cuenta[]> ObtenerCuentasAsync(int cliente);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICuentasServiceChannel : BINET.Test.CuentaServices.ICuentasService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CuentasServiceClient : System.ServiceModel.ClientBase<BINET.Test.CuentaServices.ICuentasService>, BINET.Test.CuentaServices.ICuentasService {
        
        public CuentasServiceClient() {
        }
        
        public CuentasServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CuentasServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CuentasServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CuentasServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public BINET.Entities.Cuenta[] ObtenerCuentas(int cliente) {
            return base.Channel.ObtenerCuentas(cliente);
        }
        
        public System.Threading.Tasks.Task<BINET.Entities.Cuenta[]> ObtenerCuentasAsync(int cliente) {
            return base.Channel.ObtenerCuentasAsync(cliente);
        }
    }
}
