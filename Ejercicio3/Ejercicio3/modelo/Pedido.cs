using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3.modelo
{
    internal class Pedido
    {
        private string identificador;
        private string fechapedido;
        private int preciototal;
        private int precio;
        private string usuario;

        public string Identificador { get => identificador; set => identificador = value; }
        public string Fechapedido { get => fechapedido; set => fechapedido = value; }
        public int Preciototal { get => preciototal; set => preciototal = value; }
        public int Precio { get => precio; set => precio = value; }
        internal string Usuario { get => usuario; set => usuario = value; }

        public Pedido() 
        { }
        public Pedido(string identifica,int precio) 
        { 
            Identificador = identifica;
            Precio = precio;
        }
        public Pedido(string identifica, string fecha,int precio, int preciot, string usuario) 
        {
            Identificador = identifica;
            Fechapedido = fecha;
            Precio = precio;
            Preciototal = preciot;
            Usuario = usuario;

        }
    }
}
