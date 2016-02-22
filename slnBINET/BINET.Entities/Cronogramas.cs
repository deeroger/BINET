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
        public int prestamo { get; set; }
        [DataMember]
        public int cliente { get; set; }
        [DataMember]
        public int cuota { get; set; }
        [DataMember]
        public DateTime fecha { get; set; }
        [DataMember]
        public decimal monto { get; set; }
        [DataMember]
        public string estado { get; set; }

    }
}
