using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BINET.Entities
{
    public class CustomException : Exception
    {
        public int codigo { get; set; }
        public string mensaje { get; set; }
    }
}
