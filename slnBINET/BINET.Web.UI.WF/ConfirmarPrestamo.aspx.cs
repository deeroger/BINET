using BINET.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BINET.Web.UI.WF
{
    public partial class ConfirmarPrestamo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                DatosCliente();
                Prestamo prestamo = (Prestamo) Session["Prestamo"];
                lblcuentadestino.Text = prestamo.Cuentadestino.Codigo.ToString();
                lblcuentaorigen.Text = prestamo.Cuentaorigen.Codigo.ToString();
                lblcuota.Text = prestamo.Montoc.ToString();
                lblcuotas.Text = prestamo.Cuotas.ToString();
                lblmonto.Text = prestamo.Monto.ToString();
                lblprestamo.Text = prestamo.Codigo.ToString();
                lbltarjeta.Text = prestamo.Tarjeta.Codigo.ToString();
                lbltea.Text = prestamo.Tea.ToString();
                lblfecha.Text = prestamo.Fechor.ToString();
            }
        }
        public void DatosCliente()
        {
            Usuario usuario = (Usuario)Session["Usuario"];
            Cliente clienteObtenido = null;
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://localhost:17982/ClientesService.svc/Clientes/" + usuario.IdCli);
            req.Method = "GET";
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());
            string clienteJSON = reader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            clienteObtenido = js.Deserialize<Cliente>(clienteJSON);
            lblcliente.Text = clienteObtenido.ApePat + " " + clienteObtenido.ApeMat + " " + clienteObtenido.NomCli01;
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Main.aspx");
        }
    }
}