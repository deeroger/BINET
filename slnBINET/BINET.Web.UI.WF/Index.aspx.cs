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
                //if (usuario != null)
                //{
                //    Response.Redirect("Main.aspx");
                //}
                //else 
                //{
 
                //}
                //if (uid == "usuario" && pwd == "2016")
                //{
                    
                //}
                //else if (uid == "promero" || uid == "aromero")
                //{
                //    FailureText.Text = "El usuario se encuentra desactivado. Comuníquese con el Banco.";
                //    ErrorMessage.Visible = true;
                //}
                //else
                //{
                //    FailureText.Text = "El usuario y/o contraseña ingresado son inválidos.";
                //    ErrorMessage.Visible = true;
                //}
            }
        }

    }
}