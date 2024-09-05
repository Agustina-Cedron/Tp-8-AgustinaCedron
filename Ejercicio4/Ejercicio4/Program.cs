using Ejercicio4.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {/*Una universidad desea crear un sistema para la gestión de cursos y estudiantes. Cada curso
tiene un código, nombre, profesor y la materia que dicta. Los estudiantes tienen un nombre,
número de matrícula y el año de cursado. El sistema debe permitir la inscripción y des
inscripción de estudiantes en cursos, así como la visualización de la lista de estudiantes por
curso. Identifica los objetos, atributos y métodos necesarios para implementar este sistema.*/
            Estudiante estudiante1= new Estudiante();
            Estudiante estudiante2 = new Estudiante("Xiomara Castillo", 2324);
            Estudiante estudiante3 = new Estudiante("Xiomara Castillo",2324,2024);
            Console.WriteLine("Estudiante: "+estudiante2.Nombre);
            Console.WriteLine("Matricula: "+estudiante2.Numeromatricula);
            Console.WriteLine("Año cursado: "+estudiante3.Aniocursado);
            Console.WriteLine("--------------------------------");
            Curso curso1 = new Curso();
            Curso curso2 = new Curso(8888,"Mariano Bazques");
            Curso curso3 = new Curso(8888,"6to 1ra","Mariano Bazques","Lengua y Literatura");
            Console.WriteLine("codigo: "+curso2.Codigo);
            Console.WriteLine("Profesor: "+curso2.Profesor);
            Console.WriteLine("Nombre del curso: "+curso3.Nombre);
            Console.WriteLine("Asignatura: "+curso3.Materia);
            Console.WriteLine("---------------------------------");
            Profesor profe1 = new Profesor();
            Profesor profe2 = new Profesor("Mariano Bazques", "Italia 260");
            Profesor profe3 = new Profesor("Mariano Bazquez","Lengua y Literatura","Italia 260");
            Console.WriteLine("Profesor: "+profe3.Nombre);
            Console.WriteLine("Asignatura: "+profe3.Asignatura);
            Console.WriteLine("Direccion: "+profe3.Direccion);
            Console.ReadKey();
        }
    }
}
