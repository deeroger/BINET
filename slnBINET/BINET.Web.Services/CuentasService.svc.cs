using BINET.Data;
using BINET.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BINET.Web.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CuentasService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CuentasService.svc or CuentasService.svc.cs at the Solution Explorer and start debugging.
    public class CuentasService : ICuentasService
    {

        public IList<Cuenta> ObtenerCuentas(int cliente)
        {
            CuentaDAO dao = new CuentaDAO();
            return dao.ObtenerCuentas(cliente);
        }

        //public IList<Cuenta> ObtenerCuentasPrestamo(int cliente)
        //{
        //    CuentaDAO dao = new CuentaDAO();
        //    return dao.ObtenerCuentas(cliente);
        //}
    }
}
