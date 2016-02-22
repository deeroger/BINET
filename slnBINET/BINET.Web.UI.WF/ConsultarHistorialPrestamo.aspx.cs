using BINET.Entities;
using BINET.Web.UI.WF.PrestamoWS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BINET.Web.UI.WF
{
    public partial class ConsultarHistorialPrestamo : System.Web.UI.Page
    {
        Usuario usuario = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            usuario = (Usuario)Session["Usuario"];
            if(!IsPostBack)
            {
                PrestamosServiceClient client = new PrestamosServiceClient();
                Prestamo[] prestamo = client.ListarHistorial(usuario.IdCli.ToString());
                if (prestamo == null || prestamo.Length == 0)
                {
                    divPromo.InnerText = "Estimado Cliente, hasta la fecha Ud. no ha adquirido préstamos";
                    divPromo.Visible = true;
                }
                else 
                {
                    gvData.DataSource = prestamo;
                    gvData.DataBind();
                    divPromo.Visible = false;
                }
            }
        }

        protected void btnRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Main.aspx");
        }

        protected void gvData_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int row = Convert.ToInt32(e.CommandArgument);
            int prestamo = Convert.ToInt32(gvData.DataKeys[row].Values[0]);
            Response.Redirect("MostrarCronograma.aspx?prestamo="+prestamo);
        }
    }
}