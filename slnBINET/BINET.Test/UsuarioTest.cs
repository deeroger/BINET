using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BINET.Test
{
    [TestClass]
    public class UsuarioTest
    {
        [TestMethod]
        public void Test_Usuario_Login_Ok()
        {
            UsuarioWS.UsuarioServiceClient client = new UsuarioWS.UsuarioServiceClient();
            //int responseCode = client.LogIn("promero", "123");
            //Assert.AreEqual(responseCode, 0);
        }

        [TestMethod]
        public void Test_Usuario_Login_CredencialesIncorrectas()
        {
            UsuarioWS.UsuarioServiceClient client = new UsuarioWS.UsuarioServiceClient();
            //int responseCode = client.LogIn("promero", "1234");
            //Assert.AreEqual(responseCode, 1);
        }

        [TestMethod]
        public void Test_Usuario_Login_UsuarioDesactivado()
        {
            UsuarioWS.UsuarioServiceClient client = new UsuarioWS.UsuarioServiceClient();
            //int responseCode = client.LogIn("luisa", "luisa");
            //Assert.AreEqual(responseCode, 2);
        }

    }
}
