using System;
using System.Text;
using System.Net;
using System.IO;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Script.Serialization;
using BINET.Entities;


namespace BINET.Test
{


    [TestClass]
    public class ClienteTest
    {
        [TestMethod]
        public void TestObtenerCliente()
        {
            Cliente clienteObtenido = null;
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create("http://localhost:17982/ClientesService.svc/Clientes/1");
            req.Method = "GET";
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            StreamReader reader = new StreamReader(res.GetResponseStream());
            string clienteJSON = reader.ReadToEnd();
            JavaScriptSerializer js = new JavaScriptSerializer();
            clienteObtenido = js.Deserialize<Cliente>(clienteJSON);
            Assert.AreEqual("1", clienteObtenido.IdCli);
            Assert.AreEqual("Hugo", clienteObtenido.NomCli01);
        }

        [TestMethod]
        public void TestActualizarCliente()
        {
            string postdata = "{\"IdCli\":\"1\",\"MailCli01\":\"alexander@hotmail.com\",\"TelCli01\":\"999999999\"}";
            byte[] data = Encoding.UTF8.GetBytes(postdata);
            HttpWebRequest req = (HttpWebRequest)WebRequest
                .Create("http://localhost:17982/ClientesService.svc/Clientes");
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
            Assert.AreEqual("1", clienteActualizado.IdCli);
            Assert.AreEqual("alexander@hotmail.com", clienteActualizado.MailCli01);
            Assert.AreEqual("999999999", clienteActualizado.TelCli01);
        }
    }
}
