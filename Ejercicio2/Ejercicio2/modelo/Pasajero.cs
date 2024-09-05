using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.modelo
{
    internal class Pasajero
    {

        private string nombrep;
        private string nacionalidad;
        private int edad;
        private int numerop;

        public string Nombrep { get => nombrep; set => nombrep = value; }
        public string Nacionalidad { get => nacionalidad; set => nacionalidad = value; }
        public int Numerop { get => numerop; set => numerop = value; }

        public int Edad { get => edad; set => edad = value; }

        public Pasajero() { }
        public Pasajero(string nombre,int edad) 
        {
            Nombrep = nombre;
            Edad = edad;
        }
        public Pasajero(string nombre,string nacional,int eda,int numero) 
        {
            Nombrep = nombre;
            Nacionalidad = nacional;
            Edad = eda;
            Numerop = numero;
        }



    }
}
