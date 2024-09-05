using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.modelo
{
    internal class Vuelo
    {
        private int numerovuelo;
        private string fechavuelo;
        private string destino;
        private int precio;

        public int Numerovuelo { get => numerovuelo; set => numerovuelo = value; }
        public string Fechavuelo { get => fechavuelo; set => fechavuelo = value; }
        public string Destino { get => destino; set => destino = value; }
        public int Precio { get => precio; set => precio = value; }


        public Vuelo()
        { }
        public Vuelo(int numerov, string dest) 
        {
            Numerovuelo = numerov;
            Destino = dest;
        }
        public Vuelo(int numerov, string fecha, string dest, int prec) 
        { 
           
            Numerovuelo = numerov;
            Fechavuelo = fecha;
            Destino = dest;
            Precio = prec;
        }
    }
}
