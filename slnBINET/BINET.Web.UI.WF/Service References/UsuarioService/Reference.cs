﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BINET.Web.UI.WF.UsuarioService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UsuarioService.IUsuarioService")]
    public interface IUsuarioService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarioService/LogIn", ReplyAction="http://tempuri.org/IUsuarioService/LogInResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(BINET.Entities.ServiceException), Action="http://tempuri.org/IUsuarioService/LogInServiceExceptionFault", Name="ServiceException", Namespace="http://schemas.datacontract.org/2004/07/BINET.Entities")]
        BINET.Entities.Usuario LogIn(string uid, string pwd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsuarioService/LogIn", ReplyAction="http://tempuri.org/IUsuarioService/LogInResponse")]
        System.Threading.Tasks.Task<BINET.Entities.Usuario> LogInAsync(string uid, string pwd);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUsuarioServiceChannel : BINET.Web.UI.WF.UsuarioService.IUsuarioService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UsuarioServiceClient : System.ServiceModel.ClientBase<BINET.Web.UI.WF.UsuarioService.IUsuarioService>, BINET.Web.UI.WF.UsuarioService.IUsuarioService {
        
        public UsuarioServiceClient() {
        }
        
        public UsuarioServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UsuarioServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UsuarioServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UsuarioServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public BINET.Entities.Usuario LogIn(string uid, string pwd) {
            return base.Channel.LogIn(uid, pwd);
        }
        
        public System.Threading.Tasks.Task<BINET.Entities.Usuario> LogInAsync(string uid, string pwd) {
            return base.Channel.LogInAsync(uid, pwd);
        }
    }
}
