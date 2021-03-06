﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BINET.Web.UI.WF.PrestamoWS {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PrestamoWS.IPrestamosService")]
    public interface IPrestamosService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrestamosService/CrearPrestamo", ReplyAction="http://tempuri.org/IPrestamosService/CrearPrestamoResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(BINET.Entities.ServiceException), Action="http://tempuri.org/IPrestamosService/CrearPrestamoServiceExceptionFault", Name="ServiceException", Namespace="http://schemas.datacontract.org/2004/07/BINET.Entities")]
        BINET.Entities.Prestamo CrearPrestamo(int tarjeta, int cuentaorigen, int moneda, double monto, int cuotas, double tea, double tcea, double montoc, System.DateTime fechor, int cliente, int cuentadestino);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrestamosService/CrearPrestamo", ReplyAction="http://tempuri.org/IPrestamosService/CrearPrestamoResponse")]
        System.Threading.Tasks.Task<BINET.Entities.Prestamo> CrearPrestamoAsync(int tarjeta, int cuentaorigen, int moneda, double monto, int cuotas, double tea, double tcea, double montoc, System.DateTime fechor, int cliente, int cuentadestino);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrestamosService/ObtenerPrestamo", ReplyAction="http://tempuri.org/IPrestamosService/ObtenerPrestamoResponse")]
        BINET.Entities.Prestamo ObtenerPrestamo(int codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrestamosService/ObtenerPrestamo", ReplyAction="http://tempuri.org/IPrestamosService/ObtenerPrestamoResponse")]
        System.Threading.Tasks.Task<BINET.Entities.Prestamo> ObtenerPrestamoAsync(int codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrestamosService/ModificarPrestamo", ReplyAction="http://tempuri.org/IPrestamosService/ModificarPrestamoResponse")]
        BINET.Entities.Prestamo ModificarPrestamo(int codigo, int tarjeta, int cuentaorigen, int moneda, double monto, int cuotas, double tea, double tcea, double montoc, System.DateTime fechor, int cliente, int cuentadestino);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrestamosService/ModificarPrestamo", ReplyAction="http://tempuri.org/IPrestamosService/ModificarPrestamoResponse")]
        System.Threading.Tasks.Task<BINET.Entities.Prestamo> ModificarPrestamoAsync(int codigo, int tarjeta, int cuentaorigen, int moneda, double monto, int cuotas, double tea, double tcea, double montoc, System.DateTime fechor, int cliente, int cuentadestino);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrestamosService/EliminarPrestamo", ReplyAction="http://tempuri.org/IPrestamosService/EliminarPrestamoResponse")]
        void EliminarPrestamo(int codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrestamosService/EliminarPrestamo", ReplyAction="http://tempuri.org/IPrestamosService/EliminarPrestamoResponse")]
        System.Threading.Tasks.Task EliminarPrestamoAsync(int codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrestamosService/ListarPrestamos", ReplyAction="http://tempuri.org/IPrestamosService/ListarPrestamosResponse")]
        BINET.Entities.Prestamo[] ListarPrestamos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrestamosService/ListarPrestamos", ReplyAction="http://tempuri.org/IPrestamosService/ListarPrestamosResponse")]
        System.Threading.Tasks.Task<BINET.Entities.Prestamo[]> ListarPrestamosAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrestamosService/ListarHistorial", ReplyAction="http://tempuri.org/IPrestamosService/ListarHistorialResponse")]
        BINET.Entities.Prestamo[] ListarHistorial(string codigo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPrestamosService/ListarHistorial", ReplyAction="http://tempuri.org/IPrestamosService/ListarHistorialResponse")]
        System.Threading.Tasks.Task<BINET.Entities.Prestamo[]> ListarHistorialAsync(string codigo);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPrestamosServiceChannel : BINET.Web.UI.WF.PrestamoWS.IPrestamosService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PrestamosServiceClient : System.ServiceModel.ClientBase<BINET.Web.UI.WF.PrestamoWS.IPrestamosService>, BINET.Web.UI.WF.PrestamoWS.IPrestamosService {
        
        public PrestamosServiceClient() {
        }
        
        public PrestamosServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PrestamosServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PrestamosServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PrestamosServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public BINET.Entities.Prestamo CrearPrestamo(int tarjeta, int cuentaorigen, int moneda, double monto, int cuotas, double tea, double tcea, double montoc, System.DateTime fechor, int cliente, int cuentadestino) {
            return base.Channel.CrearPrestamo(tarjeta, cuentaorigen, moneda, monto, cuotas, tea, tcea, montoc, fechor, cliente, cuentadestino);
        }
        
        public System.Threading.Tasks.Task<BINET.Entities.Prestamo> CrearPrestamoAsync(int tarjeta, int cuentaorigen, int moneda, double monto, int cuotas, double tea, double tcea, double montoc, System.DateTime fechor, int cliente, int cuentadestino) {
            return base.Channel.CrearPrestamoAsync(tarjeta, cuentaorigen, moneda, monto, cuotas, tea, tcea, montoc, fechor, cliente, cuentadestino);
        }
        
        public BINET.Entities.Prestamo ObtenerPrestamo(int codigo) {
            return base.Channel.ObtenerPrestamo(codigo);
        }
        
        public System.Threading.Tasks.Task<BINET.Entities.Prestamo> ObtenerPrestamoAsync(int codigo) {
            return base.Channel.ObtenerPrestamoAsync(codigo);
        }
        
        public BINET.Entities.Prestamo ModificarPrestamo(int codigo, int tarjeta, int cuentaorigen, int moneda, double monto, int cuotas, double tea, double tcea, double montoc, System.DateTime fechor, int cliente, int cuentadestino) {
            return base.Channel.ModificarPrestamo(codigo, tarjeta, cuentaorigen, moneda, monto, cuotas, tea, tcea, montoc, fechor, cliente, cuentadestino);
        }
        
        public System.Threading.Tasks.Task<BINET.Entities.Prestamo> ModificarPrestamoAsync(int codigo, int tarjeta, int cuentaorigen, int moneda, double monto, int cuotas, double tea, double tcea, double montoc, System.DateTime fechor, int cliente, int cuentadestino) {
            return base.Channel.ModificarPrestamoAsync(codigo, tarjeta, cuentaorigen, moneda, monto, cuotas, tea, tcea, montoc, fechor, cliente, cuentadestino);
        }
        
        public void EliminarPrestamo(int codigo) {
            base.Channel.EliminarPrestamo(codigo);
        }
        
        public System.Threading.Tasks.Task EliminarPrestamoAsync(int codigo) {
            return base.Channel.EliminarPrestamoAsync(codigo);
        }
        
        public BINET.Entities.Prestamo[] ListarPrestamos() {
            return base.Channel.ListarPrestamos();
        }
        
        public System.Threading.Tasks.Task<BINET.Entities.Prestamo[]> ListarPrestamosAsync() {
            return base.Channel.ListarPrestamosAsync();
        }
        
        public BINET.Entities.Prestamo[] ListarHistorial(string codigo) {
            return base.Channel.ListarHistorial(codigo);
        }
        
        public System.Threading.Tasks.Task<BINET.Entities.Prestamo[]> ListarHistorialAsync(string codigo) {
            return base.Channel.ListarHistorialAsync(codigo);
        }
    }
}
