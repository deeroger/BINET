using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BINET.Web.UI.WF.UsuarioService;
using BINET.Entities;
using System.ServiceModel;

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
                try
                {
                    Usuario usuario = servicio.LogIn(uid, pwd);
                    Session.Add("Usuario", usuario);
                    Response.Redirect("Main.aspx");
                }
                catch (FaultException<ServiceException> ex)
                {
                    FailureText.Text = ex.Detail.mensaje;
                    ErrorMessage.Visible = true;
                }

            }
        }

    }
}