using BINET.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BINET.Web.Services
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Prestamos" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Prestamos.svc o Prestamos.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Prestamos : IPrestamos
    {
      public Cliente RegistraPrestamo(string uid, int nCuota,  int nCuenta)
          {
              return null;
          }
      }
}
