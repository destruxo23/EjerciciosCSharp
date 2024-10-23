using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_diecisiete
{
    internal class Almacen
    {
        //Asociacion con la clase venta creando un atributo
        private Venta[] ventas;

        //Constructor
        public Almacen()
        {
            ventas = new Venta[100];
        }

        public void crearVenta(int tv, Cliente cte, Fecha f)
        {
            bool resultado = false;

            for(int i = 0; i < ventas.Length; i++)
            {
                if (ventas[i] == null)
                {
                    ventas[i] = new Venta(i + 1, tv, cte, f);

                    resultado = true;

                    break;
                }
            }

            if(resultado = true)
            {
                MessageBox.Show("La venta fue creada correctamente");
            }
            else
            {
                MessageBox.Show("No se pudo crear la venta");
            }
        }

        public Venta getUltimaVenta()
        {
            Venta venta = null;

            if (ventas[0] != null)
            {
                for (int i = 1; i < ventas.Length; i++)
                {
                    if(ventas[i] == null)
                    {
                        venta = ventas[i - 1];
                        break;
                    }
                }
            }
            return venta;
        }

        public Venta getVenta(int numVenta)
        {
            Venta v = null;

            for(int i = 0; i < ventas.Length; i++)
            {
                if(numVenta == ventas[i].getNumVenta())
                {
                    v = ventas[i];
                    break;
                }
            }
            return v;
        }
    }
}
