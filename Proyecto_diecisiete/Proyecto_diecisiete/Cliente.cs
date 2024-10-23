using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_diecisiete
{
    internal class Cliente
    {
        //Atributos
        private string nombres;
        private string apellidos;
        private string numID;
        private string celular;

        //Metodos constructores
        public Cliente()
        {

        }

        public Cliente(string nom, string ape, string ni, string cel)
        {
            nombres = nom;
            apellidos = ape;
            numID = ni;
            celular = cel;
        }

        //Metodos Setters
        public void setNombres(string nom)
        {
            nombres = nom;
        }
        public void setApellidos(string ape)
        {
            apellidos = ape;
        }
        public void setNumID(string ni)
        {
            numID = ni;
        }
        public void setCelular(string cel)
        {
            celular = cel;
        }
        //Metodos Getter
        public string getNombres()
        {
            return nombres;
        }
        public string getApellidos()
        {
            return apellidos;
        }
        public string getNumID()
        {
            return numID;
        }
        public string getCelular()
        {
            return celular;
        }
    }
}
