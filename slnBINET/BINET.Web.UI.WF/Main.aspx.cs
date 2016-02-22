using BINET.Entities;
using BINET.Web.UI.WF.CampanaWS;
using BINET.Web.UI.WF.CuentaWS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BINET.Web.UI.WF
{
    public partial class Main : System.Web.UI.Page
    {

        Usuario usuario = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            usuario = (Usuario)Session["Usuario"];
            if(!IsPostBack)
            {
                CargarCuentas();
                CampanasServiceClient client = new CampanasServiceClient();
                Campana campana = client.ConsultarCampana(usuario.IdCli);
                if (campana != null)
                {
                    StringBuilder txt = new StringBuilder();
                    txt.Append("Tienes un Préstamo Efectivo Aprobado por S/ " + campana.monto);
                    txt.Append("<br />");
                    txt.Append(@"<a href=""RegistrarPrestamo.aspx"">Solicítalo aqui</a>");
                    divPromo.InnerHtml = txt.ToString();
                    divPromo.Visible = true;
                }
                else 
                {
                    divPromo.Visible = false;
                }
            }
        }

        public void CargarCuentas()
        {
            CuentasServiceClient client = new CuentasServiceClient();
            gvCuenta.DataSource = client.ObtenerCuentas(usuario.IdCli);
            gvCuenta.DataBind();
        }

    }
}