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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CampanasService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CampanasService.svc or CampanasService.svc.cs at the Solution Explorer and start debugging.
    public class CampanasService : ICampanasService
    {

        public Campana ConsultarCampana(int cliente)
        {
            CampanaDA dao = new CampanaDA();
            return dao.ConsultarCampana(cliente);
        }
    }
}
