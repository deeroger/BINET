using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BINET.Entities
{
    [DataContract]
    public class ServiceException
    {
        [DataMember]
        public int codigo { get; set; }
        [DataMember]
        public string mensaje { get; set; }
    }
}
