using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_dieciseis
{
    internal class AireAcondicionado
    {
        //Atributos
        private string marca;
        private string modelo;
        private string color;
        private int voltaje;
        private int btu;
        private int temperatura;

        //Metodo Constructor
        public AireAcondicionado(string m, string mo, string co, int vol, int b, int t)
        {
            marca = m;
            modelo = mo;
            color = co;
            voltaje = vol;
            btu = b;
            temperatura = t;
        }

        public AireAcondicionado(string m, string mo, string co, int vol, int b)
        {
            marca = m;
            modelo = mo;
            color = co;
            voltaje = vol;
            btu = b;
        }

        public AireAcondicionado(string m, string mo, string co, int vol)
        {
            marca = m;
            modelo = mo;
            color = co;
            voltaje = vol;
        }

        //Metodos Set
        public void setMarca(string m)
        {
            marca = m;
        }

        public void setModelo(string mo)
        {
            modelo = mo;
        }

        public void setColor(string c)
        {
            color = c;
        }

        public void setVoltaje(int vol)
        {
            voltaje = vol;
        }

        public void setBtu(int b)
        {
            btu = b;
        }

        //Metodos Get

        public string getMarca()
        {
            return marca;
        }

        public string getModelo()
        {
            return modelo;
        }

        public string getColor()
        {
            return color;
        }

        public int getVoltaje()
        {
            return voltaje;
        }

        public int getBtu()
        {
            return btu;
        }

        //Metodos 
        public void subirTemperatura()
        {
            if(temperatura < 30) 
            {
            temperatura++;
            }
        }

        public void subirTemperatura(int grados)
        {
            int temperaturaActual = temperatura + grados;

            if (temperaturaActual > 30)
            {
                temperatura = 30;
            }
            else
            {
                temperatura = temperaturaActual;
            }
        }

        public void bajarTemperatura()
        {
            if(temperatura > 16)
            {
                temperatura--;
            }
        }

        public void bajarTemperatura(int grados)
        {
            int temperaturaActual = temperatura - grados;

            if (temperaturaActual < 16)
            {
                temperatura = 16;
            }
            else
            {
                temperatura = temperaturaActual;
            }
        }

        public int darTemperaturaActual()
        {
            return temperatura;
        }
    }
}
