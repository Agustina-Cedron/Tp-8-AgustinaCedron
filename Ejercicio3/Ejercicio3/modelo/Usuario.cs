using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.modelo
{
    internal class Usuario
    {
        private string nombre;
        private string direccion;
        private string correo;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Correo { get => correo; set => correo = value; }
        public Usuario() { }
        public Usuario(string nom, string dire)
        {
            Nombre = nom;
            Direccion = dire;
        }
        public Usuario(string nom,string dire,string correo) 
        {
            Nombre = nom;
            Direccion = dire;
            Correo = correo;
        }

    }
}
