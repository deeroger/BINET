using BINET.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BINET.Web.Services
{
    public class Service1 : ICronograma
    {
        public Cronogramas Registrar_Cronograma(int pCodigo, DateTime pFecDesem, double pMontoPrest, int pNroCuotas)
        {
            Cronogramas NuevoCro = new Cronogramas()
            {
                NroCuenta = pCodigo,
                FecDesem = pFecDesem,
                MontoPrest = pMontoPrest,
                NroCuotas = pNroCuotas,
            };

            return Reporte.Agregar(NuevoCro);
        }


        CronogramaDAO Reporte = new CronogramaDAO();
        public Cronogramas Consulta_cronogrma(int pCodigo)
        {
            return Reporte.buscarCronograma(pCodigo);
        }
    }
}
