using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BINET.Entities;

namespace BINET.Test
{
    [TestClass]
    public class PrestamoTest
    {
        int codigo = 9;

        //verificar la creación
        [TestMethod]
        public void T1_Crea()
        {
            // 1. Preparar la invocación(objeto, argumentos, etc )
            //MensajesWS.AsesoresClient proxy = new MensajesWS.AsesoresClient();
            PrestamoWS.PrestamosServiceClient proxy = new PrestamoWS.PrestamosServiceClient();
            
            // 2. Invocar la funcionalidad(Operación del servicio)            
            //SoapServiceTest.MensajesWS.Asesor asesor = proxy.CrearAsesor("Nuevo1","b",1);
            //SoapServiceTest.MensajesWS.Prestamo prestamo = proxy.CrearPrestamo(1500055, 4, 1);
            
                DateTime fechayhora = DateTime.Now;
                // Para Separar Fecha Y Hora
                var fecha = fechayhora.ToString("dd/MM/yyyy");

                var hora = fechayhora.ToString("hh:mm tt");
                var hora2 = fechayhora.ToString("hh:mm:ss tt");


                Prestamo prestamo = proxy.CrearPrestamo(1, 3, 1, 5000.99, 4, 12.50, 15.50, 100.99, fechayhora, 1, 1);

            // 3. Verificar/validar el resultado esperado
            //Assert.AreEqual("Nuevo1", prestamo.Nombre);
            Assert.AreEqual(5000.99, prestamo.Monto);
        }

        [TestMethod]
        public void T2_Obtener()
        {
            // 1. Preparar la invocación(objeto, argumentos, etc )
            //MensajesWS.AsesoresClient proxy = new MensajesWS.AsesoresClient();
            PrestamoWS.PrestamosServiceClient proxy = new PrestamoWS.PrestamosServiceClient();

            // 2. Invocar la funcionalidad(Operación del servicio)            
            // string resultado = proxy.ObtenerAsesor(1);
            //SoapServiceTest.MensajesWS.Asesor asesor  = proxy.ObtenerAsesor(1);
            Prestamo prestamo = proxy.ObtenerPrestamo(codigo);

            // 3. Verificar/validar el resultado esperado
            //Assert.AreEqual("Hector", prestamo.Nombre);
            Assert.AreEqual(codigo, prestamo.Codigo);
        }

        //verificar la modificación
        [TestMethod]
        public void T3_Modifica()
        {
            // 1. Preparar la invocación(objeto, argumentos, etc )
            //MensajesWS.AsesoresClient proxy = new MensajesWS.AsesoresClient();
            PrestamoWS.PrestamosServiceClient proxy = new PrestamoWS.PrestamosServiceClient();

            // 2. Invocar la funcionalidad(Operación del servicio)            
            //SoapServiceTest.MensajesWS.Asesor asesor = proxy.ModificarAsesor(9, "Nuevo9", "b", 1);
            //SoapServiceTest.MensajesWS.Asesor asesor2 = proxy.ObtenerAsesor(9);
            DateTime fechayhora = DateTime.Now;
            Prestamo prestamo = proxy.ModificarPrestamo(codigo, 1, 3, 1, 15000.55, 5, 12.50, 15.50, 100.99, fechayhora, 1, 1);
            Prestamo prestamo2 = proxy.ObtenerPrestamo(codigo);            
            
            // 3. Verificar/validar el resultado esperado
            //Assert.AreEqual(prestamo2.Nombre, prestamo.Nombre);
            Assert.AreEqual(prestamo2.Monto, prestamo.Monto);
        }

        //verificar lista
        [TestMethod]
        public void T4_Lista0()
        {
            // 1. Preparar la invocación(objeto, argumentos, etc )
            //MensajesWS.AsesoresClient proxy = new MensajesWS.AsesoresClient();
            PrestamoWS.PrestamosServiceClient proxy = new PrestamoWS.PrestamosServiceClient();
            
            // 2. Invocar la funcionalidad(Operación del servicio) 
      
            //SoapServiceTest.MensajesWS.Asesor asesor = proxy.ListarAsesores
            //SoapServiceTest.MensajesWS.Asesor List<Asesor> = proxy.ListarAsesores();
            //SoapServiceTest.MensajesWS.List<Asesor> = proxy.ListarAsesores();
            //SoapServiceTest.MensajesWS.AsesorDAO.ListarTodos().ToList() = proxy.ListarAsesores();
            //SoapServiceTest.MensajesWS.Asesor.ListarTodos().ToList() = proxy.ListarAsesores();
            //SoapServiceTest.MensajesWS.Asesor.List<Asesor>.ListarTodos().ToList() = proxy.ListarAsesores();
            //SoapServiceTest.MensajesWS.Asesor.List<Asesor>.ToList() = proxy.ListarAsesores();
            //List<Asesor> = proxy.ListarAsesores();
            //List<Asesor> = proxy.ListarAsesores();

            //SoapServiceTest.MensajesWS.Prestamo prestamo = proxy.ListarPrestamos
            //SoapServiceTest.MensajesWS.Prestamo List<Prestamo> = proxy.ListarPrestamos();
            //SoapServiceTest.MensajesWS.List<Prestamo> = proxy.ListarPrestamos();
            //SoapServiceTest.MensajesWS.PrestamoDAO.ListarTodos().ToList() = proxy.ListarPrestamos();
            //SoapServiceTest.MensajesWS.Prestamo.ListarTodos().ToList() = proxy.ListarPrestamos();
            //SoapServiceTest.MensajesWS.Prestamo.List<Prestamo>.ListarTodos().ToList() = proxy.ListarPrestamos();
            //SoapServiceTest.MensajesWS.Prestamo.List<Prestamo>.ToList() = proxy.ListarPrestamos();
            //List<Prestamo> = proxy.ListarPrestamos();
            //List<Prestamo> = proxy.ListarPrestamos();
            //proxy.ListarPrestamos();
            proxy.ListarPrestamos();        
            
        //    public List<Asesor> ListarAsesores()
        //{
        //    return AsesorDAO.ListarTodos().ToList(); 
        // }

            // 3. Verificar/validar el resultado esperado
            //Assert.AreEqual(asesor2.Nombre, asesor.Nombre);
        }
        
        [TestMethod]
        public void T4_Lista_EnBlanco()
        {
            //ClienteServiceClient client = new ClienteService.ClienteServiceClient();
            PrestamoWS.PrestamosServiceClient proxy = new PrestamoWS.PrestamosServiceClient();
            //client.CrearCliente("a", "b", "c", "d");
            //SoapServiceTest.MensajesWS.Prestamo prestamo = proxy.CrearPrestamo(5000, 5, 1234);

            //ClienteService.Cliente[] clientes = client.ListarClientes();
            Prestamo[] prestamos = proxy.ListarPrestamos();

            //Assert.IsTrue(clientes.Length > 0);
            //Assert.IsTrue(prestamos.Length > 0);            
            Assert.IsFalse(prestamos.Length > 0);
        }


        [TestMethod]
        public void T5_ListarHistorial()
        {
            PrestamoWS.PrestamosServiceClient proxy = new PrestamoWS.PrestamosServiceClient();
            Prestamo[] historialPrestamos = proxy.ListarHistorial("1");
            Assert.IsTrue(historialPrestamos.Length > 0);
        }

        ////verificar la eliminación
        //[TestMethod]
        //public void T3_Elimina()
        //{
        //    // 1. Preparar la invocación(objeto, argumentos, etc )
        //    //MensajesWS.AsesoresClient proxy = new MensajesWS.AsesoresClient();
        //    PrestamoWS.PrestamosServiceClient proxy = new PrestamoWS.PrestamosServiceClient();

        //    // 2. Invocar la funcionalidad(Operación del servicio)       
        //    //proxy.EliminarAsesor(10);
        //    proxy.EliminarPrestamo(codigo); 
        //    //SoapServiceTest.MensajesWS.Asesor asesor = proxy.EliminarAsesor(10);

        //    // 3. Verificar/validar el resultado esperado
        //    //Assert.AreEqual(asesor2.Nombre, asesor.Nombre);
        //}

        //[TestMethod]
        //public void T4_Lista1()
        //{
        //    //ClienteServiceClient client = new ClienteService.ClienteServiceClient();
        //    PrestamoWS.PrestamosServiceClient proxy = new PrestamoWS.PrestamosServiceClient();
        //    //client.CrearCliente("a", "b", "c", "d");
        //    DateTime fechayhora = DateTime.Now;
        //    Prestamo prestamo = proxy.CrearPrestamo(1, 3, 1, 5000.55, 5, 12.50, 15.50, 100.99, fechayhora, 1, 1);

        //    //ClienteService.Cliente[] clientes = client.ListarClientes();
        //    Prestamo[] prestamos = proxy.ListarPrestamos();

        //    //Assert.IsTrue(clientes.Length > 0);
        //    Assert.IsTrue(prestamos.Length > 0);
        //}

    }
}

