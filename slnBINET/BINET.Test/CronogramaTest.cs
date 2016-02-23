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
    public class CronogramaTest
    {
        [TestMethod]
        public void ConsultarCronograma()
        {
            
            CronogramaWS.CronogramasServiceClient  proxy = new CronogramaWS.CronogramasServiceClient();
            Cronogramas[] ConsultarCronograma = proxy.ConsultarCronograma(9, 1);
            Assert.IsFalse(ConsultarCronograma.Length > 0);

        }
        [TestMethod]
        public void RegistrarCronograma()
        {
            CronogramaWS.CronogramasServiceClient proxy = new CronogramaWS.CronogramasServiceClient();
            Cronogramas[] RegistrarCronograma = proxy.RegistrarCronograma(1,1,12,DateTime.Now,12000);
            Assert.IsFalse(RegistrarCronograma.Length == 0);
        }
    }
}
