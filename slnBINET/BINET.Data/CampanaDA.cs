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
    public class CampanaDA
    {
        public Campana ConsultarCampana(int cliente)
        {
            try
            {
                Campana campanaBE = null;
                StringBuilder sql = new StringBuilder();
                SqlConnection oCnn = new SqlConnection(Conexion.SqlCnn());
                SqlCommand comando = new SqlCommand();
                sql.Append("select ca.*, mo.nombre monedades, ta.codigo tarjeta");
                sql.Append(Environment.NewLine);
                sql.Append("from campana ca ");
                sql.Append(Environment.NewLine);
                sql.Append("inner join cuenta cu on cu.codigo=ca.cuenta and cu.estado='A' and cu.tipo='P' and cu.moneda=ca.moneda and cu.cliente=ca.cliente ");
                sql.Append(Environment.NewLine);
                sql.Append("inner join tarjeta ta on ta.cuenta=cu.codigo and ta.estado='A' and ta.tipo='C'");
                sql.Append(Environment.NewLine);
                sql.Append("inner join moneda mo on mo.codigo=ca.moneda");
                sql.Append(Environment.NewLine);
                sql.Append("where ca.codigo=1 and ca.CLIENTE=@codigo and ca.estado = 'A' and ca.moneda=1 and ca.monto>=5000 and exists (select * from Cuenta where cliente=@codigo and estado='A' and tipo='A');");
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sql.ToString();
                comando.Connection = oCnn;
                comando.Parameters.AddWithValue("@codigo", cliente);
                oCnn.Open();
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    campanaBE = new Campana();
                    while (reader.Read())
                    {
                        campanaBE.codigo = reader.GetInt32(0);
                        campanaBE.cliente = reader.GetInt32(1);
                        campanaBE.cuenta = reader.GetDecimal(2);
                        campanaBE.moneda = reader.GetInt32(3);
                        campanaBE.monto = reader.GetDecimal(4);
                        campanaBE.tea = reader.GetDecimal(5);
                        campanaBE.tcea = reader.GetDecimal(6);
                        campanaBE.cuotas1 = reader.GetInt32(7);
                        campanaBE.montoc1 = reader.GetDecimal(8);
                        campanaBE.cuotas2 = reader.GetInt32(9);
                        campanaBE.montoc2 = reader.GetDecimal(10);
                        campanaBE.cuotas3 = reader.GetInt32(11);
                        campanaBE.montoc3 = reader.GetDecimal(12);
                        campanaBE.estado = reader.GetString(13);
                        campanaBE.montotot1 = reader.GetDecimal(14);
                        campanaBE.montotot2 = reader.GetDecimal(15);
                        campanaBE.montotot3 = reader.GetDecimal(16);
                        campanaBE.monedades = reader.GetString(17).Trim();
                        campanaBE.tarjeta = reader.GetDecimal(18);
                    }

                }
                reader.Close();
                oCnn.Close();
                comando.Dispose();
                return campanaBE;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
                return null;
            }
        }
    }
}
