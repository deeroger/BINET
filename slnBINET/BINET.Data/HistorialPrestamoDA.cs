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
    public class HistorialPrestamoDA : Conexion     
    {
         Prestamo prestamoBE = null;
        List<Prestamo> lista = null;
        public List <Prestamo> listaPrestamo(string codigo)
        {
            
           try
            {
                SqlConnection oCnn = new SqlConnection(Conexion.SqlCnn());
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select p.codigo, p.fechor,p.monto,p.tea,p.tcea,p.cuotas from prestamo p join cliente c on (p.cliente = c.IdCliente) where c.IdCliente = @CODIGO";
                comando.Connection = oCnn;
                comando.Parameters.AddWithValue("@CODIGO", codigo);
                oCnn.Open();
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    lista = new List<Prestamo>();
                    while (reader.Read())
                    {
                        prestamoBE = new Prestamo();
                        prestamoBE.Codigo = reader.GetInt32(0);
                        prestamoBE.Fechor = reader.GetDateTime(1);
                        prestamoBE.Monto = (Double)reader.GetDecimal(2);
                        prestamoBE.Tea = (Double)reader.GetDecimal(3);
                        prestamoBE.Tcea = (Double)reader.GetDecimal(4);
                        prestamoBE.Cuotas = reader.GetInt32(5);
                        lista.Add(prestamoBE);
                    }
                    
                }
                reader.Close();
                oCnn.Close();
                comando.Dispose();

                return lista;

            }
            catch(Exception ex) {
                Console.WriteLine("Error: " + ex);
                return null;
            }
           

        }





    }
}
