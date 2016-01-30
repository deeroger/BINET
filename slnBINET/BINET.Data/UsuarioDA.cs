using BINET.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BINET.Data.COM
{
    public class UsuarioDA : Conexion
    {

        public string ErrorMessage { get; set; }

        public Usuario LogIn(string uid, string pwd)
        {
            try 
            {
                Usuario usuarioBE = null;
                SqlConnection oCnn = new SqlConnection(this.SdgSqlCnn());
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select IdCli, UID, Password From Tb_Usuario Where Usuario=@Usuario And Password=@Password";
                comando.Connection = oCnn;
                comando.Parameters.AddWithValue("@Usuario", uid);
                comando.Parameters.AddWithValue("@Password", pwd);
                oCnn.Open();
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    usuarioBE = new Usuario();
                    while (reader.Read())
                    {
                        usuarioBE.IdCli = reader.GetInt32(0);
                        usuarioBE.UID = reader.GetString(1).Trim();
                        usuarioBE.Password = reader.GetString(2).Trim();
                    }
                }
                reader.Close();
                oCnn.Close();
                comando.Dispose();
                return usuarioBE;
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                return null;
            }
        }


    }
}
