using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4.modelo
{
    internal class Estudiante
    {
        private string nombre;
        private int numeromatricula;
        private int aniocursado;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Numeromatricula { get => numeromatricula; set => numeromatricula = value; }
        public int Aniocursado { get => aniocursado; set => aniocursado = value; }

        public Estudiante() { }
        public Estudiante(string nom, int matricula) 
        {
            Nombre = nom;
            Numeromatricula = matricula;
        }
        public Estudiante(string nom, int matricula, int anio) 
        {
            Nombre = nom;
            Numeromatricula = matricula;
            Aniocursado = anio;
        }
    }
}
