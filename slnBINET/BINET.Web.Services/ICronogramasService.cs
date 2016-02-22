using BINET.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BINET.Web.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICronogramasService" in both code and config file together.
    [ServiceContract]
    public interface ICronogramasService
    {
        [OperationContract]
        IList<Cronogramas> ConsultarCronograma(int prestamo, int cliente);

        [OperationContract]
        IList<Cronogramas> RegistrarCronograma(int prestamo, int cliente, int cuotas, DateTime fechaini, decimal monto);

        [OperationContract]
        IList<Prestamo> SincronizarCronograma();
    }
}
