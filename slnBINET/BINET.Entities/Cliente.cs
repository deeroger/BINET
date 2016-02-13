using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BINET.Entities
{
    [DataContract]
    public class Cliente
    {
        [DataMember]
        public int IdCli { get; set; }
        [DataMember]
        public string NomCli01 { get; set; }
        [DataMember]
        public string ApePat { get; set; }
        [DataMember]
        public string ApeMat { get; set; }
        [DataMember]
        public string NumIde { get; set; }
        [DataMember]
        public string MailCli01 { get; set; }
        [DataMember]
        public string TelCli01 { get; set; }

    }
}
