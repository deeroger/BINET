using BINET.Entities;
using BINET.Web.UI.WF.CronogramaWS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BINET.Web.UI.WF
{
    public partial class MostrarCronograma : System.Web.UI.Page
    {

        Usuario usuario = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            usuario = (Usuario)Session["Usuario"];
            if(!IsPostBack)
            {
                int prestamo = Convert.ToInt32(Request.QueryString["prestamo"]);
                CronogramasServiceClient client = new CronogramasServiceClient();
                gvData.DataSource = client.ConsultarCronograma(prestamo, usuario.IdCli);
                gvData.DataBind();
            }
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("ConsultarHistorialPrestamo.aspx");
        }
    }
}