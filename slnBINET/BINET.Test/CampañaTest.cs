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
    public class CampañaTest
    {

        [TestMethod]
        public void ConsultarCampana()
        {
            CampanaWS.CampanasServiceClient proxy = new CampanaWS.CampanasServiceClient();
            Campana RegistrarCronograma = proxy.ConsultarCampana(1);
            Assert.Equals(RegistrarCronograma.cliente, 1);
            Assert.Equals(RegistrarCronograma.cuenta, 2);
            Assert.Equals(RegistrarCronograma.moneda, 1);
            Assert.Equals(RegistrarCronograma.monto, 15000.00);
            Assert.Equals(RegistrarCronograma.tea, 12.50);
            Assert.Equals(RegistrarCronograma.cliente, 1);
            Assert.Equals(RegistrarCronograma.cuotas1, 12);
            Assert.Equals(RegistrarCronograma.montoc1, 445.41);
            Assert.Equals(RegistrarCronograma.cuotas2, 24);
            Assert.Equals(RegistrarCronograma.montoc2, 473.07);
            Assert.Equals(RegistrarCronograma.cuotas3, 36);
            Assert.Equals(RegistrarCronograma.montoc3, 501.80);
            Assert.Equals(RegistrarCronograma.estado, "A");
            Assert.Equals(RegistrarCronograma.montotot1, 5000.00);
            Assert.Equals(RegistrarCronograma.montotot2, 10000.00);
            Assert.Equals(RegistrarCronograma.montotot3, 15000.00);

        }
    }
}
