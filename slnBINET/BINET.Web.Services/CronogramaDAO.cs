using BINET.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BINET.Web.Services
{
    public class CronogramaDAO
    {

        ArrayList ListaCronogramas;

    public CronogramaDAO()
    {
        ListaCronogramas = new ArrayList();
        Cronogramas _busqueda = new Entities.Cronogramas();
        // 3 usuarios -------
        _busqueda.NroCuenta = 1111;
        _busqueda.FecDesem = DateTime.Today;
        _busqueda.MontoPrest = 1500;
        _busqueda.NroCuotas = 12;

        ListaCronogramas.Add(_busqueda);
        //-------------------------------------
        _busqueda.NroCuenta = 2222;
        _busqueda.FecDesem = DateTime.Today;
        _busqueda.MontoPrest = 1200;
        _busqueda.NroCuotas = 24;

        ListaCronogramas.Add(_busqueda);
        //------------------------------------
        _busqueda.NroCuenta = 3333;
        _busqueda.FecDesem = DateTime.Today;
        _busqueda.MontoPrest = 1000;
        _busqueda.NroCuotas = 8;

        ListaCronogramas.Add(_busqueda);
    }

    public Cronogramas Agregar(Cronogramas CCronograma)
    {
        ListaCronogramas.Add(CCronograma);
        return CCronograma;

    }
    public Cronogramas buscarCronograma(int codigo)
    {
        Cronogramas busqueda = new Cronogramas();
        int indice = ListaCronogramas.Count;
        foreach (Cronogramas item in ListaCronogramas)
        {
            if (item.NroCuenta == codigo)
            {
                busqueda.NroCuenta = item.NroCuenta;
                busqueda.FecDesem = item.FecDesem;
                busqueda.MontoPrest = item.MontoPrest;
                busqueda.NroCuotas = item.NroCuotas;
            }
        }
        return busqueda;

    }
}
}