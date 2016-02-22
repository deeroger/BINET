using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BINET.Entities
{
    [DataContract]
    public class Campana
    {
        [DataMember]
        public int codigo { get; set; }
        [DataMember]
        public int cliente { get; set; }
        [DataMember]
        public decimal cuenta { get; set; }
        [DataMember]
        public int moneda { get; set; }
        [DataMember]
        public string monedades { get; set; }
        [DataMember]
        public decimal monto { get; set; }
        [DataMember]
        public decimal tea { get; set; }
        [DataMember]
        public decimal tcea { get; set; }
        [DataMember]
        public int cuotas1 { get; set; }
        [DataMember]
        public decimal montoc1 { get; set; }
        [DataMember]
        public int cuotas2 { get; set; }
        [DataMember]
        public decimal montoc2 { get; set; }
        [DataMember]
        public int cuotas3 { get; set; }
        [DataMember]
        public decimal montoc3 { get; set; }
        [DataMember]
        public string estado { get; set; }
        [DataMember]
        public decimal montotot1 { get; set; }
        [DataMember]
        public decimal montotot2 { get; set; }
        [DataMember]
        public decimal montotot3 { get; set; }
        [DataMember]
        public decimal tarjeta { get; set; }
    }
}
