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
    public class ClienteDA : Conexion
    {
        Cliente clienteBE = null;
        public Cliente obtenerCliente(int codigo)
        {
            
           try
            {               
                SqlConnection oCnn = new SqlConnection(this.SqlCnn());
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select Nombre,ApellidoPaterno,ApellidoMaterno,NumIdent,Email,Telefono from cliente where IdCliente=@CODIGO";
                comando.Connection = oCnn;
                comando.Parameters.AddWithValue("@CODIGO", codigo);
                oCnn.Open();
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    clienteBE = new Cliente();
                    while (reader.Read())
                    {
                        clienteBE.IdCli = codigo;
                        clienteBE.NomCli01 = reader.GetString(0);
                        clienteBE.ApePat = reader.GetString(1);
                        clienteBE.ApeMat = reader.GetString(2);
                        clienteBE.NumIde = reader.GetString(3);
                        clienteBE.MailCli01 = reader.GetString(4);
                        clienteBE.TelCli01 = reader.GetString(5);
                    }
                    
                }
                reader.Close();
                oCnn.Close();
                comando.Dispose();
                
            }
            catch(Exception ex) {
                Console.WriteLine("Error: " + ex);
            }
            return clienteBE;

        }

        public Cliente actualizarCliente(Cliente cliente)
        {
            int responseCodde = 0;
            try
            {
                SqlConnection oCnn = new SqlConnection(this.SqlCnn());
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "update cliente set email=@mail, telefono=@telefono where IdCliente=@codigo";
                comando.Connection = oCnn;
                comando.Parameters.AddWithValue("@codigo",cliente.IdCli);
                comando.Parameters.AddWithValue("@mail", cliente.MailCli01);
                comando.Parameters.AddWithValue("@telefono", cliente.TelCli01);
                oCnn.Open();
                responseCodde = comando.ExecuteNonQuery();
                if (responseCodde > 0) {
                    responseCodde = 2;
                }
                oCnn.Close();
                comando.Dispose();                
            }
            catch(Exception ex) {
                Console.WriteLine("Error: "+ex);
            }
            return obtenerCliente(cliente.IdCli);
        }

        public bool verificarCorreo(String mailCli01)
        {
            

            Cliente clienteCorreo = null;
            SqlConnection oCnn = new SqlConnection(this.SqlCnn());
            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "Select IdCli From Cliente Where MailCli01=@MailCli01;";
            comando.Connection = oCnn;
            comando.Parameters.AddWithValue("@MailCli01", mailCli01);
            oCnn.Open();
          
            SqlDataReader reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                return false;
            }
            else
            {
                return true;
            }
       

}

        }
}
