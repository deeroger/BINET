using BINET.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BINET.Web.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICampanasService" in both code and config file together.
    [ServiceContract]
    public interface ICampanasService
    {
        [OperationContract]
        Campana ConsultarCampana(int cliente);
    }
}
