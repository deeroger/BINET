using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BINET.Entities
{
    [DataContract]
    public class Prestamo
    {
        [DataMember]
        public int Codigo { get; set; }
        [DataMember]
        public Tarjeta Tarjeta { get; set; }
        [DataMember]
        public Cuenta Cuentaorigen { get; set; }
        [DataMember]        
        public Moneda Moneda { get; set; }  
        [DataMember]
        public double Monto { get; set; }        
        [DataMember]
        public int Cuotas { get; set; }
        [DataMember]       
        public double Tea { get; set; }
        [DataMember]
        public double Tcea { get; set; }
        [DataMember]
        public double Montoc { get; set; }
        [DataMember]
        public DateTime Fechor { get; set; }
        [DataMember]
        public Cuenta Cuentadestino { get; set; }
        [DataMember]
        public Cliente Cliente { get; set; }  
    }
}