using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BINET.Data.COM
{
    public class Conexion
    {
        public string SdgSqlCnn()
        {
            return ConfigurationManager.ConnectionStrings["servidorRemoto"].ConnectionString;
        }
    }
}
