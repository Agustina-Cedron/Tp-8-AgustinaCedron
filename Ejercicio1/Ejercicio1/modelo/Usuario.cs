using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.modelo
{
    internal class Usuario
    {
        private string nombre;
        private string apellido;
        private string direccion;


        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Direccion { get => direccion; set => direccion = value; }

        public Usuario() 
        {

        }
        public Usuario(string nom, string apell) 
        {
            Nombre = nom;
            Apellido = apell;
        }
        public Usuario(string nom, string apell, string direcc)
        {
            Nombre = nom;
            Apellido = apell;
            Direccion = direcc;
        }
    }
}
