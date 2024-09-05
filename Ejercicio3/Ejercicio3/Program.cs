using Ejercicio3.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {/*Una tienda en línea desea desarrollar un sistema para gestionar sus productos y pedidos. Cada
producto tiene un nombre, precio, descripción y cantidad en stock. Los pedidos incluyen un
identificador de pedido, fecha de pedido, cliente y el precio total del pedido. Los clientes tienen
un nombre, dirección de envío y dirección de correo electrónico. Diseña un programa que
permita agregar productos, gestionar el stock, y procesar pedidos. Identifica los objetos,
atributos y métodos necesarios para este sistema.*/
            Pedido pedido1 = new Pedido();
            Pedido pedido2 = new Pedido("353465",4500);
            Pedido pedido3 = new Pedido("353465","01/07/2024",500,4500,"Sandra Gonzalez");
            Console.WriteLine("Identificador: " + pedido3.Identificador);
            Console.WriteLine("Fecha del pedido: " + pedido3.Fechapedido);
            Console.WriteLine("Precio:$ " + pedido3.Precio);
            Console.WriteLine("Precio total:$ " + pedido3.Preciototal);
            Console.WriteLine("Cliente: " + pedido3.Usuario);
            Console.WriteLine("--------------------------------------------");
            Producto producto1 = new Producto();
            Producto producto2 = new Producto("Chocolate Arcor",2);
            Producto producto3 = new Producto("Chocolate Arcor",4500,"Chocolate blanco 95gr",9);
            Console.WriteLine("Producto: "+producto3.Nombre);
            Console.WriteLine("Precio:$ "+producto3.Precio);
            Console.WriteLine("Descripcion: "+producto3.Descripcion);
            Console.WriteLine("Cantidad: "+producto3.Cantidad);
            Console.WriteLine("--------------------------------------------");
            Usuario usuario1 = new Usuario();
            Usuario usuario2 = new Usuario("Sandra Gonzalez","Av. 1ro de Mayo");
            Usuario usuario3 = new Usuario("Sandra Gonzalez","Av. 1ro de Mayo","SandraGon@gmail.com");
            Console.WriteLine("Cliente: "+usuario3.Nombre);
            Console.WriteLine("Direccion: "+usuario3.Direccion);
            Console.WriteLine("Correo electronico: "+usuario3.Correo);

            Console.ReadKey();
        }
    }
}
