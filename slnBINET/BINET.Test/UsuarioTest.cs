using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BINET.Entities;
using System.ServiceModel;
using BINET.Test.UsuarioWS;

namespace BINET.Test
{
    [TestClass]
    public class UsuarioTest
    {

        UsuarioServiceClient client = new UsuarioServiceClient();
        [TestMethod]
        public void Test_Usuario_Login_Ok()
        {
            Usuario usuario = client.LogIn("promero", "123");
            Assert.AreEqual(usuario.UID, "promero");
        }

        [TestMethod]
        public void Test_Usuario_Login_CredencialesIncorrectas()
        {
            UsuarioServiceClient client = new UsuarioServiceClient();
            try
            {
                Usuario usuario = client.LogIn("promero", "1234");
            }
            catch (FaultException<ServiceException> ex)
            {
                Assert.AreEqual(ex.Detail.mensaje, "Las credenciales ingresadas son incorrectas");
            }
        }

        [TestMethod]
        public void Test_Usuario_Login_UsuarioDesactivado()
        {
            UsuarioServiceClient client = new UsuarioServiceClient();
            try
            {
                Usuario usuario = client.LogIn("luis", "luisa");
            }
            catch (FaultException<ServiceException> ex)
            {
                Assert.AreEqual(ex.Detail.mensaje, "El usuario se encuentra desactivado. Comuníquese con el Banco.");
            }
        }

    }
}
