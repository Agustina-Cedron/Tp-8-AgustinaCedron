using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.modelo
{
    internal class Libro
    {
        private string fechadeprestamo;
        private string fechadedevolucion;
        private string nombredelibro;
        private string autor;

        public string Fechadeprestamo { get => fechadeprestamo; set => fechadeprestamo = value; }
        public string Fechadedevolucion { get => fechadedevolucion; set => fechadedevolucion = value; }
        public string Nombredelibro { get => nombredelibro; set => nombredelibro = value; }
        public string Autor { get => autor; set => autor = value; }

        public Libro() 
        { }
        public Libro(string fecha1, string fecha2)
        {
            Fechadeprestamo = fecha1;
            Fechadedevolucion = fecha2;
        }
        public Libro(string fecha1, string fecha2, string nombrelib, string aut) 
        {
            Fechadeprestamo = fecha1;
            Fechadedevolucion = fecha2;
            Nombredelibro = nombrelib;
            Autor = aut;
        }

    }
}
