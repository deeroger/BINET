using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BINET.Entities;

namespace BINET.Web.Services
{
    [ServiceContract]
    public interface IPrestamosService
    {
        [OperationContract]
        Prestamo CrearPrestamo(int tarjeta, int cuentaorigen, int moneda, double monto, int cuotas, double tea, double tcea, double montoc, DateTime fechor, int cliente, int cuentadestino);
        [OperationContract]
        Prestamo ObtenerPrestamo(int codigo);
        [OperationContract]
        Prestamo ModificarPrestamo(int codigo, int tarjeta, int cuentaorigen, int moneda, double monto, int cuotas, double tea, double tcea, double montoc, DateTime fechor, int cliente, int cuentadestino);
        [OperationContract]
        void EliminarPrestamo(int codigo);
        [OperationContract]
        List<Prestamo> ListarPrestamos();
        [OperationContract]
        List<Prestamo> ListarHistorial(string codigo);
    }
}

