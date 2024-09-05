using Ejercicio1.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {/*Una biblioteca digital ofrece una amplia variedad de libros a sus usuarios registrados. Los
usuarios pueden buscar libros, leer descripciones, ver la disponibilidad y, si están registrados,
pueden pedir prestados los libros. Los libros pueden estar disponibles en formato digital o físico.
Cada vez que un usuario pide prestado un libro, se registra la fecha de préstamo y la fecha de
devolución prevista. Además, la biblioteca tiene un sistema para enviar recordatorios a los
usuarios cuando se acerca la fecha de devolución de un libro.*/
            Usuario usuario1 = new Usuario();
            Usuario usuario2 = new Usuario("Luciano "," Baldosa");
            Usuario usuario3 = new Usuario("Luciano "," Baldosa"," Av. 9 de julio");
            Console.WriteLine(usuario3.Nombre + usuario3.Apellido + usuario3.Direccion);
            Libro libro = new Libro();
            Libro libro2= new Libro("12/06/24","21/07/24");
            Libro libro3 = new Libro("12/06/24 ","21/07/24","Bajo la misma estrella", "Jhoon Green");
            Console.WriteLine("Fecha de prestamo: "+libro3.Fechadeprestamo);
            Console.WriteLine("Fecha de devolucion: "+libro3.Fechadedevolucion);
            Console.WriteLine("Fecha de prestamo: "+libro3.Nombredelibro);
            Console.WriteLine("Fecha de prestamo: "+libro3.Autor);

            Console.ReadKey();


        }
    }
}
