using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BINET.Web.UI
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                MainSite master = (MainSite)this.Master;
                master.HideUserData();
            }
        }

        protected void LogIn(object sender, EventArgs e)
        {
            if (IsValid)
            {
                // Validate the user password
                var uid = txtUserName.Text;
                var pwd = txtPassword.Text;
                if (uid=="usuario" && pwd=="2016")
                {
                    Response.Redirect("Main.aspx");
                }
                else
                {
                    FailureText.Text = "El usuario y/o contraseña ingresado son inválidos.";
                    ErrorMessage.Visible = true;
                }
            }
        }

    }
}