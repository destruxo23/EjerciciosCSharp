using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_diecisiete
{
    internal class Venta
    {
        private int numVenta;
        private double totalVenta;

        //Asociaciones
        private Cliente cliente;
        private Fecha fechaVenta;


        //Metodos constructores
        public Venta(int nv, double tv, Cliente cte, Fecha f)
        {
            numVenta = nv;
            totalVenta = tv;
            cliente = cte;
            fechaVenta = f;
        }

        //Metodos Setters
        public void setNumVenta(int nv)
        {
            numVenta = nv;
        }

        public void setTotalVenta(int tv)
        {
            totalVenta = tv;
        }
        public void setCliente(Cliente cte)
        {
            cliente = cte;
        }
        public void setFechaVenta(Fecha f)
        {
            fechaVenta = f;
        }

        //Metodos getters
        public int getNumVenta()
        {
            return numVenta;
        }

        public double getTotalVenta()
        {
            return totalVenta;
        }
        public Cliente getCliente()
        {
            return cliente;
        }
        public Fecha getFechaVenta()
        {
            return fechaVenta;
        }
    }
}
