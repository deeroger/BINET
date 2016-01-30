using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BINET.Entities
{
    public class Usuario
    {
        public int IdCli { get; set; }
        public string UID { get; set; }
        public string Password { get; set; }

        public bool FlaAct { get; set; }
    }
}
