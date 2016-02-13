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
        public Usuario LogIn(string uid, string pwd)
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
                if (!usuarioBE.FlaAct)
                {
                    throw new CustomException() { codigo = 2, mensaje = "El usuario se encuentra desactivado. Comuníquese con el Banco." };
                }
            }
            else 
            {
                throw new CustomException() { codigo = 1, mensaje = "Las credenciales ingresadas son incorrectas" };
            }
            reader.Close();
            oCnn.Close();
            comando.Dispose();
            return usuarioBE;
            
        }


    }
}
