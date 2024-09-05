using Ejercicio2.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {/*Una compañía aérea desea implementar un sistema de gestión de vuelos. Los vuelos tienen un
número, una fecha de salida, un destino y un precio. Los pasajeros tienen un nombre, número
de pasaporte y nacionalidad. Se requiere un programa que permita gestionar los vuelos,
incluyendo la adición y eliminación de vuelos, así como la gestión de los pasajeros en cada
vuelo. Identifica los posibles objetos, atributos y métodos necesarios para implementar este
sistema.*/
            Vuelo vuelo1 = new Vuelo();
            Vuelo vuelo2 = new Vuelo(234,"Francia");
            Vuelo vuelo3 = new Vuelo(234,"24/07/24", "Francia", 6000000);
            Console.WriteLine("Numero de vuelo: "+vuelo3.Numerovuelo);
            Console.WriteLine("Fecha de vuelo: " + vuelo3.Fechavuelo);
            Console.WriteLine("Destino: " + vuelo3.Destino);
            Console.WriteLine("Precio:$ " + vuelo3.Precio);
            Console.WriteLine("-------------------------------------------------");
            Pasajero pasajero1 = new Pasajero();
            Pasajero pasajero2 = new Pasajero("lorenzo Beltran",30);
            Pasajero pasajero3 = new Pasajero("Lorenzo Beltran","Argentino",30,2032);
            Console.WriteLine("Pasajero: "+pasajero3.Nombrep);
            Console.WriteLine("Nacionalidad: "+pasajero3.Nacionalidad);
            Console.WriteLine("Edad: "+pasajero3.Edad);
            Console.WriteLine("Numero de pasajero: "+pasajero3.Numerop);

            Console.ReadKey();
        }
    }
}
