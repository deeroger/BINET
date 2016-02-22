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
        public IList<Cronogramas> ConsultarCronograma(int prestamo, int cliente)
        {

            Cronogramas crono = null;
            List<Cronogramas> liscro = null;
            try
            {
                SqlConnection oCnn = new SqlConnection(Conexion.SqlCnn());
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select * from cronograma where prestamo=@prestamo and cliente=@cliente;";
                comando.Connection = oCnn;
                comando.Parameters.AddWithValue("@prestamo", prestamo);
                comando.Parameters.AddWithValue("@cliente", cliente);
                oCnn.Open();
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    liscro = new List<Cronogramas>();
                    while (reader.Read())
                    {
                        crono = new Cronogramas();
                        crono.prestamo = reader.GetInt32(0);
                        crono.cliente = reader.GetInt32(1);
                        crono.cuota = reader.GetInt32(2);
                        crono.fecha = reader.GetDateTime(3);
                        crono.monto = reader.GetDecimal(4);
                        crono.estado = reader.GetString(5);
                        liscro.Add(crono);
                    }

                }
                reader.Close();
                oCnn.Close();
                comando.Dispose();

                return liscro;

            }           

            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
                return null;
            }


        }

        public IList<Cronogramas> RegistarCronograma(int prestamo, int cliente, int cuotas, DateTime fechaini, decimal monto) 
        {
            try
            {
                StringBuilder sql = new StringBuilder();
                for (int i = 1; i <= cuotas; i++)
                {
                    DateTime fecha = fechaini.AddMonths(i);
                    sql.Append(string.Format("Insert into cronograma values ({0},{1},{2},'{3}',{4},'P');", prestamo, cliente, i, fecha.ToString("yyyyMMdd"), monto/cuotas));
                    sql.Append(Environment.NewLine);
                }
                SqlConnection oCnn = new SqlConnection(Conexion.SqlCnn());
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Connection = oCnn;
                oCnn.Open();
                int cant = comando.ExecuteNonQuery();
                oCnn.Close();
                comando.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
            return ConsultarCronograma(prestamo,cliente);
        }

    }
}
