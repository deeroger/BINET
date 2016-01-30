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
        public int LogIn(string uid, string pwd)
        {
            int responseCode = -1;

            try 
            {
                Usuario usuarioBE = null;
                SqlConnection oCnn = new SqlConnection(this.SqlCnn());
                SqlCommand comando = new SqlCommand();
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select IdCli, UID, Password, FlaAct From Tb_Usuario Where UID=@UID And Password=@Password;";
                comando.Connection = oCnn;
                comando.Parameters.AddWithValue("@UID", uid);
                comando.Parameters.AddWithValue("@Password", pwd);
                oCnn.Open();
                //PARA UPDATES Y PARA DELETES
                //int res = comando.ExecuteNonQuery();
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    usuarioBE = new Usuario();
                    while (reader.Read())
                    {
                        usuarioBE.IdCli = reader.GetInt32(0);
                        usuarioBE.UID = reader.GetString(1).Trim();
                        usuarioBE.Password = reader.GetString(2).Trim();
                        usuarioBE.FlaAct = reader.GetBoolean(3);
                    }
                    //Reglas de Negocio
                    if (!usuarioBE.FlaAct)
                    {
                        responseCode = 2;
                    }
                    else {
                        responseCode = 0;
                    }
                }
                else 
                {
                    responseCode = 1;
                }
                reader.Close();
                oCnn.Close();
                comando.Dispose();
                return responseCode;
            }
            catch(Exception ex)
            {
                return responseCode;
            }
        }


    }
}
