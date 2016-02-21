using BINET.Data.COM;
using BINET.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BINET.Data
{
    public   class CronogramaDAO:Conexion 
    {
        public List<Cronogramas> obtenerListCronograma(int codigo)
        {

            Cronogramas crono = new Cronogramas();
            List<Cronogramas> liscro = new List<Cronogramas>();
            try
            {
                SqlConnection oCnn = new SqlConnection(this.SqlCnn());
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select cuotas, fechor, monto from prestamo where codigo=@CODIGO";
                comando.Connection = oCnn;
                comando.Parameters.AddWithValue("@CODIGO", codigo);
                oCnn.Open();
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        crono.NroCuenta = codigo;
                        crono.NroCuotas = reader.GetInt32(0);
                        crono.FecDesem = reader.GetDateTime(1);
                        crono.MontoPrest = reader.GetDouble(2);

                    }

                }
                reader.Close();
                oCnn.Close();
                comando.Dispose();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }

            double mensualidad = crono.MontoPrest / crono.NroCuotas;
            int indice = crono.NroCuotas;
            for (int i = 0; indice > i; i++)
            {
                crono.NroCuotas = i + 1;
                crono.FecDesem = crono.FecDesem.AddMonths(1);
                crono.MontoPrest = mensualidad;
                liscro.Add(crono);
            }

            return liscro;

        }

    }
}
