using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_dieciocho
{
    internal class Persona
    {

        private string nombres;
        private string apellidos;
        private string numId;
        private string direccion;
        private string telefono;

        public Persona(string nom, string ape, string nId, string dire, string tel)
        {
            nombres = nom;
            apellidos = ape;
            numId = nId;
            direccion = dire;
            telefono = tel;
        }

        public string getNombres()
        {
            return nombres;
        }

        public string getApellidos()
        {
            return apellidos;
        }

        public string getNumId()
        {
            return numId;
        }

        public string getDireccion()
        {
            return direccion;
        }

        public string getTelefono()
        {
            return telefono;
        }

        public virtual void darDescripcion()
        {
            MessageBox.Show("Nombres: " + nombres + ", Apellidos: " + apellidos + ", NumID: " + numId + ", Direccion: " + direccion + ", Telefono: " + telefono);
        }
    }
}