using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BINET.Data;
using BINET.Entities;

namespace BINET.Web.Services
{
    public class PrestamosService : IPrestamosService
    {
        private PrestamoDAO prestamoDAO = null;
        private PrestamoDAO PrestamoDAO
        {
            get
            {
                if (prestamoDAO == null)
                    prestamoDAO = new PrestamoDAO();
                return prestamoDAO;
            }
        }

        private CuentaDAO cuentaDAO = null;
        private CuentaDAO CuentaDAO
        {
            get
            {
                if (cuentaDAO == null)
                    cuentaDAO = new CuentaDAO();
                return cuentaDAO;    
            }
        }

        private MonedaDAO monedaDAO = null;
        private MonedaDAO MonedaDAO
        {
            get
            {
                if (monedaDAO == null)
                    monedaDAO = new MonedaDAO();
                return monedaDAO;
            }
        }

        private TarjetaDAO tarjetaDAO = null;
        private TarjetaDAO TarjetaDAO
        {
            get
            {
                if (tarjetaDAO == null)
                    tarjetaDAO = new TarjetaDAO();
                return tarjetaDAO;
            }
        }

        private ClienteDA clienteDAO = null;
        private ClienteDA ClienteDAO
        {
            get
            {
                if (clienteDAO == null)
                    clienteDAO = new ClienteDA();
                return clienteDAO;
            }
        }

        public Prestamo CrearPrestamo(int tarjeta, int cuentaorigen, int moneda, double monto, int cuotas, double tea, double tcea, double montoc, DateTime fechor, int cliente, int cuentadestino)
        {
            Tarjeta tarjetaExistente = TarjetaDAO.Obtener(tarjeta);
            Cuenta cuentaorigenExistente = CuentaDAO.Obtener(cuentaorigen);
            Moneda monedaExistente = MonedaDAO.Obtener(moneda);
            Cuenta cuentadestinoExistente = CuentaDAO.Obtener(cuentadestino);
            Cliente clienteExistente = ClienteDAO.obtenerCliente(cliente);
            Prestamo prestamo = null;

            Prestamo prestamoACrear = new Prestamo() 
            { 
                Tarjeta = tarjetaExistente,
                Cuentaorigen = cuentaorigenExistente,
                Moneda = monedaExistente,
                Monto   = monto,
                Cuotas  = cuotas,
                Tea     = tea,
                Tcea    = tcea,
                Montoc  = montoc,
                Fechor  = fechor,
                Cliente = clienteExistente,
                Cuentadestino  = cuentadestinoExistente
            };
            prestamo =  PrestamoDAO.Crear(prestamoACrear);
            if (prestamo != null)
            {
                //Genera el calendario
                CronogramaWS.CronogramasServiceClient client = new CronogramaWS.CronogramasServiceClient();
                Cronogramas[] lista = client.RegistrarCronograma(prestamo.Codigo, prestamo.Cliente.IdCli, prestamo.Cuotas, prestamo.Fechor, Convert.ToDecimal(prestamo.Montoc));
                if (lista != null)
                {
                    return prestamo;
                }
                else {
                    return null;
                }
                
            }
            else 
            {
                return null;
            }
            
        }

        public Prestamo ObtenerPrestamo(int codigo)
        {
            return PrestamoDAO.Obtener(codigo);
        }

        public Prestamo ModificarPrestamo(int codigo, int tarjeta, int cuentaorigen, int moneda, double monto, int cuotas, double tea, double tcea, double montoc, DateTime fechor, int cliente, int cuentadestino)
        {
            Tarjeta tarjetaExistente = TarjetaDAO.Obtener(tarjeta);
            Cuenta cuentaorigenExistente = CuentaDAO.Obtener(cuentaorigen);
            Cuenta cuentadestinoExistente = CuentaDAO.Obtener(cuentadestino);
            Moneda monedaExistente = MonedaDAO.Obtener(moneda);

            Cliente clienteExistente = ClienteDAO.obtenerCliente(cliente);

            Prestamo prestamoAModificar = new Prestamo()
            {
                Codigo  = codigo,
                Tarjeta = tarjetaExistente,
                Cuentaorigen = cuentaorigenExistente,
                Moneda = monedaExistente,
                Monto   = monto,                
                Cuotas  = cuotas,
                Tea     = tea,
                Tcea    = tcea,
                Montoc = montoc,
                Fechor  = fechor,
                Cliente = clienteExistente,
                Cuentadestino  = cuentadestinoExistente,
            };
            return PrestamoDAO.Modificar(prestamoAModificar);
        }

        public void EliminarPrestamo(int codigo)
        {
            Prestamo prestamoExistente = PrestamoDAO.Obtener(codigo);
            PrestamoDAO.Eliminar(prestamoExistente);
        }

        public List<Prestamo> ListarPrestamos()
        {
            return PrestamoDAO.ListarTodos().ToList(); 
         }

        public List<Prestamo> ListarHistorial(string codigo)
        {
            HistorialPrestamoDA servicio = new HistorialPrestamoDA();
            return servicio.listaPrestamo(codigo); 
        }

    }
    
   


}


