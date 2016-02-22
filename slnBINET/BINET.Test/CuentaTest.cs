using BINET.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BINET.Test
{
    [TestClass]
    public class CuentaTest
    {
        [TestMethod]
        public void ObtenerCuentas()
        {
            CuentaServices.CuentasServiceClient proxy = new CuentaServices.CuentasServiceClient();
            Cuenta[] ObtenerCuenta = proxy.ObtenerCuentas(1);
            Assert.IsFalse(ObtenerCuenta.Length == 0);

        }
    }


   


}
