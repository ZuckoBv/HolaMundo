using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escuela
{
    // Declara la clase hija "Alumno" y se declara como clase padre "Persona"
    internal class Alumno:Persona
    {
        // Se declaran los atributos y el tipo de dato que guarda
        protected int grupo;
        protected string curso;
        protected string division;
        // Se declaran las funciones para obtener el valor o asignar a cada atributo
        public int Grupo { get { return grupo; } set { grupo = value; } }
        public string Curso { get { return curso; } set { curso = value; } }
        public string Division { get { return division; } set { division = value; } }
        // Declara el objeto alumno y los valores dentro
        public Alumno(int grup, string curs, string divis)
        {
            // Guarda los valores de las variables de la funcion set y los guarda en variables dentro de Alumno
            grupo = grup;
            curso = curs;
            division = divis;
        }
    }
}
