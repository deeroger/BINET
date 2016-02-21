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
                SqlConnection oCnn = new SqlConnection(this.SqlCnn());
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select p.fechor,p.monto,p.tea,p.tcea,p.cuotas from prestamo p join cliente c on (p.cliente = c.IdCliente) where c.IdCliente = @CODIGO";
                comando.Connection = oCnn;
                comando.Parameters.AddWithValue("@CODIGO", codigo);
                oCnn.Open();
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    prestamoBE = new Prestamo();
                    lista = new List<Prestamo>();
                    while (reader.Read())
                    {
                        prestamoBE.Fechor = reader.GetDateTime(0);
                        prestamoBE.Monto = (Double)reader.GetDecimal(1);
                        prestamoBE.Tea = (Double)reader.GetDecimal(2);
                        prestamoBE.Tcea = (Double)reader.GetDecimal(3);
                        prestamoBE.Cuotas = reader.GetInt32(4);
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
