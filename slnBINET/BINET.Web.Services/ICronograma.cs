using BINET.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BINET.Web.Services
{
   [ServiceContract]
    public interface ICronograma
    {
        [OperationContract]
        List<Cronogramas> Consulta_cronogrma(int pCodigo);


    }
}
