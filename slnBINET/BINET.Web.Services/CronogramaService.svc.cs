using BINET.Entities;
using BINET.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BINET.Web.Services
{
    public class CronogramaService : ICronograma
    {
        public List<Cronogramas> Consulta_cronogrma(int pCodigo)
        {
            CronogramaDAO listcro = new CronogramaDAO();
            return listcro.obtenerListCronograma(pCodigo);
        }

      


    }
}
