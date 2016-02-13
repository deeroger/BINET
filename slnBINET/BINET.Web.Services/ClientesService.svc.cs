using BINET.Data;
using BINET.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Text.RegularExpressions;

namespace BINET.Web.Services
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ClientesService" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ClientesService.svc o ClientesService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ClientesService : IClientesService
    {
        public Cliente ActualizarCliente(Cliente cliente)
        {
            ClienteDA servicio = new ClienteDA();
            if (string.IsNullOrWhiteSpace(cliente.MailCli01) || string.IsNullOrWhiteSpace(cliente.TelCli01)) 
            {
                throw new WebFaultException<string>("El e-mail y el teléfono no pueden estar vacíos.", System.Net.HttpStatusCode.ExpectationFailed);
            }
            if (!servicio.verificarCorreo(cliente.MailCli01, cliente.IdCli))
            {
                throw new WebFaultException<string>("El correo ingresado ya se encuentra registrado para otro cliente. Ingrese uno diferente.", System.Net.HttpStatusCode.Conflict);
            }
            if (!Regex.IsMatch(cliente.MailCli01, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase)) 
            {
                throw new WebFaultException<string>("El correo ingresado no es válido. Ingrese uno diferente.", System.Net.HttpStatusCode.ExpectationFailed);
            }
            if (cliente.TelCli01.Length != 7 || !IsNumeric(cliente.TelCli01))
            {
                throw new WebFaultException<string>("El teléfono ingresado no es válido. Ingrese uno diferente.", System.Net.HttpStatusCode.ExpectationFailed);
            }
            return servicio.actualizarCliente(cliente);
        }

        public Cliente ObtenerCliente(string codigo)
        {
            ClienteDA servicio = new ClienteDA();
            return servicio.obtenerCliente(Convert.ToInt32(codigo));
        }

        public static bool IsNumeric(string valor)
        {
            int result;
            return int.TryParse(valor, out result);
        }

    }
}
