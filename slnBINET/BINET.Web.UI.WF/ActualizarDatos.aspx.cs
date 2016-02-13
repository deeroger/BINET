using BINET.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BINET.Web.UI.WF
{
    public partial class ActualizarDatos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
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
                txtApellidos.Text = clienteObtenido.ApePat + " " + clienteObtenido.ApeMat;
                txtNombres.Text = clienteObtenido.NomCli01;
                txtTelefono.Text = clienteObtenido.TelCli01;
                txtEmail.Text = clienteObtenido.MailCli01;
                divPromo.Visible = false;
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Main.aspx");
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            divPromo.Visible = false;
            Usuario usuario = (Usuario)Session["Usuario"];
            try 
            {
                string postdata = "{\"IdCli\":\"" + usuario.IdCli + "\",\"MailCli01\":\"" + txtEmail.Text + "\",\"TelCli01\":\"" + txtTelefono.Text + "\"}";
                byte[] data = Encoding.UTF8.GetBytes(postdata);
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://localhost:17982/ClientesService.svc/Clientes");
                req.Method = "PUT";
                req.ContentLength = data.Length;
                req.ContentType = "application/json";
                var reqStream = req.GetRequestStream();
                reqStream.Write(data, 0, data.Length);
                HttpWebResponse res = (HttpWebResponse)req.GetResponse();
                StreamReader reader = new StreamReader(res.GetResponseStream());
                string clienteJson = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                Cliente clienteActualizado = js.Deserialize<Cliente>(clienteJson);
                divPromo.InnerText = "Datos actualizados";
                divPromo.Attributes["class"] = "mensaje-success";
                divPromo.Visible = true;
            }
            catch (WebException ex)
            {
                HttpStatusCode code = ((HttpWebResponse)ex.Response).StatusCode;
                string message = ((HttpWebResponse)ex.Response).StatusDescription;
                StreamReader reader = new StreamReader(ex.Response.GetResponseStream());
                string error = reader.ReadToEnd();
                JavaScriptSerializer js = new JavaScriptSerializer();
                string mensaje = js.Deserialize<string>(error);
                divPromo.Attributes["class"] = "mensaje-error";
                divPromo.InnerText = mensaje;
                divPromo.Visible = true;
            }
        }

        
    }
}