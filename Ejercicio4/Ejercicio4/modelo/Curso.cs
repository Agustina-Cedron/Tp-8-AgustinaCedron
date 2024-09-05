using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4.modelo
{
    internal class Curso
    {
        private int codigo;
        private string nombre;
        private string profesor;
        private string materia;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Profesor { get => profesor; set => profesor = value; }
        public string Materia { get => materia; set => materia = value; }

        public Curso() { }
        public Curso(int cod, String profe)
        {
            Codigo = cod;
            Profesor = profe;
        }
        public Curso(int cod,string nombre,string profe,string mate)
        {
            Codigo = cod;
            Nombre = nombre;
            Profesor = profe;
            Materia = mate;
        }
    }
}
