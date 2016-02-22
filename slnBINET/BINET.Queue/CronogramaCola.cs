using BINET.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BINET.Queue
{
    public class CronogramaCola
    {

        public void Enviar(string ruta, Prestamo prestamo)
        {
            if (!MessageQueue.Exists(ruta))
            {
                MessageQueue.Create(ruta);
            }
            MessageQueue cola = new MessageQueue(ruta);
            Message mensaje = new Message();
            mensaje.Label = "Cronograma Offline";
            mensaje.Body = prestamo;
            cola.Send(mensaje);
        }

        public List<Prestamo> Recibir(string ruta)
        {
            List<Prestamo> lista = new List<Prestamo>();
            Prestamo prestamo = null;
           
            if (!MessageQueue.Exists(ruta))
            {
                MessageQueue.Create(ruta);
            }
            MessageQueue cola = new MessageQueue(ruta);
            cola.Formatter = new XmlMessageFormatter(new Type[] { typeof(Prestamo) });
            Message[] mensajes = cola.GetAllMessages();
            foreach (var item in mensajes)
            {
                prestamo = (Prestamo)item.Body;
                lista.Add(prestamo);
            }
            return lista;
        }

    }
}
