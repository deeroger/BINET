using BINET.Data.COM;
using BINET.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BINET.Data
{
    public class CuentaDAO : BaseDAO<Cuenta, int>
    {

        public IList<Cuenta> ObtenerCuentas(int cliente)
        {
            Cuenta cuenta = null;
            List<Cuenta> lista = null;
            try
            {
                SqlConnection oCnn = new SqlConnection(Conexion.SqlCnn());
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select cu.codigo, tc.nombre tipodes, mo.nombre monedades, cu.disponible, 'Cuenta ' + rTrim(tc.nombre) + ' ' + rTrim(mo.nombre) + ' N° ' + convert(varchar,cu.codigo)  DesCuentaFinal from cuenta cu inner join moneda mo on mo.codigo=cu.moneda inner join tipocuenta tc on tc.codigo=cu.tipo where cu.cliente=@codigo and cu.estado='A' and cu.tipo!='P';";
                comando.Connection = oCnn;
                comando.Parameters.AddWithValue("@codigo", cliente);
                oCnn.Open();
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    
                    lista = new List<Cuenta>();
                    while (reader.Read())
                    {
                        cuenta = new Cuenta();
                        cuenta.Codigo = (Int32)reader.GetDecimal(0);
                        cuenta.TipoDes = reader.GetString(1).Trim();
                        cuenta.MonedaDes = reader.GetString(2).Trim();
                        cuenta.Disponible = (double)reader.GetDecimal(3);
                        cuenta.DesCuentaFinal = reader.GetString(4).Trim();
                        lista.Add(cuenta);
                    }

                }
                reader.Close();
                oCnn.Close();
                comando.Dispose();

                return lista;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
                return null;
            }
        }

        public IList<Cuenta> ObtenerCuentasPrestamo(int cliente)
        {
            Cuenta cuenta = null;
            List<Cuenta> lista = null;
            try
            {
                SqlConnection oCnn = new SqlConnection(Conexion.SqlCnn());
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select cu.codigo, tc.nombre tipodes, mo.nombre monedades, cu.disponible, 'Cuenta ' + rTrim(tc.nombre) + ' ' + rTrim(mo.nombre) + ' N° ' + convert(varchar,cu.codigo)  DesCuentaFinal from cuenta cu inner join moneda mo on mo.codigo=cu.moneda inner join tipocuenta tc on tc.codigo=cu.tipo where cu.cliente=@codigo and cu.estado='A' and cu.tipo!='P' and cu.tipo='A';";
                comando.Connection = oCnn;
                comando.Parameters.AddWithValue("@codigo", cliente);
                oCnn.Open();
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {

                    lista = new List<Cuenta>();
                    while (reader.Read())
                    {
                        cuenta = new Cuenta();
                        cuenta.Codigo = (Int32)reader.GetDecimal(0);
                        cuenta.TipoDes = reader.GetString(1).Trim();
                        cuenta.MonedaDes = reader.GetString(2).Trim();
                        cuenta.Disponible = (double)reader.GetDecimal(3);
                        cuenta.DesCuentaFinal = reader.GetString(4).Trim();
                        lista.Add(cuenta);
                    }

                }
                reader.Close();
                oCnn.Close();
                comando.Dispose();

                return lista;

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
                return null;
            }
        }

    }
}