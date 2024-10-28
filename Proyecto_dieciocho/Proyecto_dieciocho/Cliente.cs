using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_dieciocho
{
    internal class Cliente : Persona
    {
        private int puntos;
        //Constructor 
        public Cliente(string nom, string ape, string nId, string dire, string tel, int pts) : base(nom, ape, nId, dire, tel)
        { 
            puntos = pts;
        }

        public int getPuntos()
        {
            return puntos;
        }
    }
}
