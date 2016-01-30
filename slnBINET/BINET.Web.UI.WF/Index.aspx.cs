using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BINET.Web.UI.WF.UsuarioService;

namespace BINET.Web.UI
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                MainSite master = (MainSite)this.Master;
                master.HideUserData();
            }
        }

        protected void LogIn(object sender, EventArgs e)
        {
            if (IsValid)
            {
                // Validate the user password
                UsuarioServiceClient servicio = new UsuarioServiceClient();
                var uid = txtUserName.Text;
                var pwd = txtPassword.Text;
                int loginCode = servicio.LogIn(uid, pwd);
                switch (loginCode) 
                { 
                    case 0:
                        Response.Redirect("Main.aspx");
                        break;
                    case 1:
                        FailureText.Text = "Las credenciales ingresadas son incorrectas";
                        ErrorMessage.Visible = true;
                        break;
                    case 2:
                        FailureText.Text = "El usuario se encuentra desactivado. Comuníquese con el Banco.";
                        ErrorMessage.Visible = true;
                        break;
                    default:
                        FailureText.Text = "Error en el inicio de sesión. Comuníquese con el Banco.";
                        ErrorMessage.Visible = true;
                        break;
                }
            }
        }

    }
}