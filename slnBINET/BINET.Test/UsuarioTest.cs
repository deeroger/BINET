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
            UsuarioService.UsuarioServiceClient client = new UsuarioService.UsuarioServiceClient();
            int responseCode = client.LogIn("promero", "123");
            Assert.AreEqual(responseCode, 0);
        }

        [TestMethod]
        public void Test_Usuario_Login_CredencialesIncorrectas()
        {
            UsuarioService.UsuarioServiceClient client = new UsuarioService.UsuarioServiceClient();
            int responseCode = client.LogIn("promero", "1234");
            Assert.AreEqual(responseCode, 1);
        }

        [TestMethod]
        public void Test_Usuario_Login_UsuarioDesactivado()
        {
            UsuarioService.UsuarioServiceClient client = new UsuarioService.UsuarioServiceClient();
            int responseCode = client.LogIn("luisa", "luisa");
            Assert.AreEqual(responseCode, 2);
        }

    }
}
