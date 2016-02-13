using BINET.Data;
using BINET.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BINET.Web.Services
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ClientesService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ClientesService.svc o ClientesService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ClientesService : IClientesService
    {
        public Cliente ActualizarCliente(Cliente cliente)
        {
            ClienteDA servicio = new ClienteDA();
            return servicio.actualizarCliente(cliente);
        }

        public Cliente ObtenerCliente(int codigo)
        {
            ClienteDA servicio = new ClienteDA();
            return servicio.obtenerCliente(codigo);
        } 
    }
}
