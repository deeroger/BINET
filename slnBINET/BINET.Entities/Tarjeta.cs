using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BINET.Entities
{
    [DataContract]
    public class Tarjeta
    {
        [DataMember]
        public int Codigo { get; set; }        
        [DataMember]
        public int Cuenta { get; set; }
        [DataMember]
        public string Tipo { get; set; }     
        [DataMember]
        public string Estado { get; set; }        
    }
}