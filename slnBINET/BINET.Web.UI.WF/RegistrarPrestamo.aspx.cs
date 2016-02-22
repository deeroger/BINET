using BINET.Entities;
using BINET.Web.UI.WF.CampanaWS;
using BINET.Web.UI.WF.CuentaWS;
using BINET.Web.UI.WF.PrestamoWS;
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
    public partial class RegistrarPrestamo : System.Web.UI.Page
    {

        Usuario usuario = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            usuario = (Usuario)Session["Usuario"];
            if(!IsPostBack)
            {
                Session["Campana"] = null;
                CampanasServiceClient client = new CampanasServiceClient();
                Campana campana = client.ConsultarCampana(usuario.IdCli);
                if (campana != null)
                {
                    Session["Campana"] = campana;
                    DatosCliente();
                    DatosCuenta();
                    moneda1.Text = campana.monedades;
                    moneda2.Text = campana.monedades;
                    moneda3.Text = campana.monedades;
                    montotot1.Text = campana.montotot1.ToString();
                    montotot2.Text = campana.montotot2.ToString();
                    montotot3.Text = campana.montotot3.ToString();
                    cuotas1.Text = campana.cuotas1.ToString();
                    cuotas2.Text = campana.cuotas2.ToString();
                    cuotas3.Text = campana.cuotas3.ToString();
                    montoc1.Text = campana.montoc1.ToString();
                    montoc2.Text = campana.montoc2.ToString();
                    montoc3.Text = campana.montoc3.ToString();
                    tea1.Text = campana.tea.ToString();
                    tea2.Text = campana.tea.ToString();
                    tea3.Text = campana.tea.ToString();
                    tcea1.Text = campana.tcea.ToString();
                    tcea2.Text = campana.tcea.ToString();
                    tcea3.Text = campana.tcea.ToString();
                }
                divPromo.Visible = false;
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
            lbltelefono.Text = clienteObtenido.TelCli01;
            lblcorreo.Text = clienteObtenido.MailCli01;
        }

        public void DatosCuenta()
        {
            cboCuenta.Items.Clear();
            cboCuenta.Items.Add(new ListItem() { Value = "-1", Text="Seleccione una cuenta" });
            CuentasServiceClient client = new CuentasServiceClient();
            Cuenta[] lista = client.ObtenerCuentas(usuario.IdCli);
            foreach (var item in lista)
            {
                cboCuenta.Items.Add(new ListItem() { Value = item.Codigo.ToString(), Text = item.DesCuentaFinal });
            }
            cboCuenta.SelectedIndex = 0;
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Main.aspx");
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            Campana campana = (Campana) Session["Campana"];
            DateTime fechayhora = DateTime.Now;
            double monto=0, tea=0, tcea=0, montoc=0;
            int cuotas=0;
            if (rbOpc1.Checked) 
            {
                monto = Convert.ToDouble(montotot1.Text);
                tea = Convert.ToDouble(tea1.Text);
                tcea = Convert.ToDouble(tcea1.Text);
                montoc = Convert.ToDouble(montoc1.Text);
                cuotas = Convert.ToInt32(cuotas1.Text);
            }
            else if (rbOpc2.Checked) 
            {
                monto = Convert.ToDouble(montotot2.Text);
                tea = Convert.ToDouble(tea2.Text);
                tcea = Convert.ToDouble(tcea2.Text);
                montoc = Convert.ToDouble(montoc2.Text);
                cuotas = Convert.ToInt32(cuotas2.Text);
            }
            else if (rbOpc3.Checked)
            {
                monto = Convert.ToDouble(montotot3.Text);
                tea = Convert.ToDouble(tea3.Text);
                tcea = Convert.ToDouble(tcea3.Text);
                montoc = Convert.ToDouble(montoc3.Text);
                cuotas = Convert.ToInt32(cuotas3.Text);
            }
            else
            {
                MostrarMensaje("Seleccione una opción");
                return;
            }
            int cuenta = Convert.ToInt32(cboCuenta.SelectedValue);
            if (cuenta == -1)
            {
                MostrarMensaje("Seleccione cuenta de abono");
                return;
            }
            PrestamosServiceClient client = new PrestamosServiceClient();
            Prestamo prestamo = client.CrearPrestamo(Convert.ToInt32(campana.tarjeta), Convert.ToInt32(campana.cuenta), campana.moneda, monto, cuotas, tea, tcea, montoc, fechayhora, usuario.IdCli, cuenta);
            if(prestamo!=null){
                Session["Prestamo"] = prestamo;
                Response.Redirect("ConfirmarPrestamo.aspx");
            }
        }

        public void MostrarMensaje(string mensaje)
        {
            divPromo.Attributes["class"] = "mensaje-error";
            divPromo.InnerText = mensaje;
            divPromo.Visible = true;
        }
    }
}