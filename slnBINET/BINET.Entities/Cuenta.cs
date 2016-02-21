using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BINET.Entities
{
    [DataContract]
    public class Cuenta
    {
        [DataMember]
        public int Codigo { get; set; }        
        [DataMember]
        public int Cliente { get; set; }
        [DataMember]
        public int Moneda { get; set; }
        [DataMember]
        public string Tipo { get; set; }
        [DataMember]
        public double Disponible { get; set; }
        [DataMember]
        public string Estado { get; set; }        
    }
}
