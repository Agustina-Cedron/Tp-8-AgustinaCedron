using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4.modelo
{
    internal class Profesor
    {
        private string nombre;
        private string asignatura;
        private string direccion;


        public string Nombre { get => nombre; set => nombre = value; }
        public string Asignatura { get => asignatura; set => asignatura = value; }
        public string Direccion { get => direccion; set => direccion = value; }

        public Profesor() { }
        public Profesor(string nom,string dire) 
        {
            Nombre = nom;
            Direccion = dire;
        }
        public Profesor(string nom,string asigna,string dire) 
        {
            Nombre = nom;
            Asignatura = asigna;
            Direccion = dire;
        }
    }
}
