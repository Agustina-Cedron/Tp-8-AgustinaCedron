using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.modelo
{
    internal class Producto
    {

        private string nombre;
        private int precio;
        private string descripcion;
        private int cantidad;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Precio { get => precio; set => precio = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }

        public Producto() { }
        public Producto(string nombre, int cantidad)
        {
            Nombre = nombre;
            Cantidad = cantidad;
        }
        public Producto(string nombre, int prec, string descrip, int cant)
        {
            Nombre = nombre;
            Precio = prec;
            Descripcion = descrip;
            Cantidad = cant;
        }
    }
}
