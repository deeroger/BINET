using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace BINET.Entities
{


    [DataContract]
    public class Cronogramas
    {
        [DataMember]
        public int NroCuenta { get; set; } // para todos
        [DataMember]
        public DateTime FecDesem { get; set; } // fechas desembolso.
        [DataMember]
        public double MontoPrest { get; set; } // cuota mensual .
        [DataMember]
        public int NroCuotas { get; set; } //periodo .


    }
}
