﻿using BINET.Data;
using BINET.Entities;
using BINET.Queue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BINET.Web.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CronogramasService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CronogramasService.svc or CronogramasService.svc.cs at the Solution Explorer and start debugging.
    public class CronogramasService : ICronogramasService
    {
        CronogramaDAO dao = new CronogramaDAO();

        public IList<Cronogramas> ConsultarCronograma(int prestamo, int cliente)
        {   
            return dao.ConsultarCronograma(prestamo, cliente);
        }


        public IList<Cronogramas> RegistrarCronograma(int prestamo, int cliente, int cuotas, DateTime fechaini, decimal monto)
        {
            return dao.RegistarCronograma(prestamo, cliente, cuotas, fechaini, monto);
        }


        public IList<Prestamo> SincronizarCronograma()
        {
            CronogramaCola cola = new CronogramaCola();
            List<Prestamo> lista = cola.Recibir(@".\private$\prestamoCalendarioOffline");
            foreach (var item in lista)
            {
                dao.RegistarCronograma(item.Codigo, item.Cliente.IdCli, item.Cuotas, item.Fechor, Convert.ToDecimal(item.Montoc));
            }
            return lista;
        }
    }
}
