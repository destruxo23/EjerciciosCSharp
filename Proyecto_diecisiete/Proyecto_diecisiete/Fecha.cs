using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_diecisiete
{
    internal class Fecha
    {
        private int dia;
        private int mes;
        private int anio;

         //Metodo constructor
        public Fecha(int d, int m, int anio)
         {
             this.dia = d;
             this.mes = m;
             this.anio = anio;
         }
        //Devuelve la fecha como string en el formato aaaa/mm/dd

        public string darFormatoFecha()
        {
            return anio+"/"+mes+"/" + dia;
        }
    }
}
