using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BINET.Entities
{
    [DataContract]
    public class Usuario
    {
        [DataMember]
        public int IdCli { get; set; }
        [DataMember]
        public string UID { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public bool FlaAct { get; set; }
    }
}
