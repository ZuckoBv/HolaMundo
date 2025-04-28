using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escuela
{
    internal class Alumno:Persona
    {
        protected int grupo;
        protected string curso;
        protected string division;
        public int Grupo { get { return grupo; } set { grupo = value; } }
        public string Curso { get { return curso; } set { curso = value; } }
        public string Division { get { return division; } set { division = value; } }
        public Alumno(int grup, string curs, string divis)
        {
            grupo = grup;
            curso = curs;
            division = divis;
        }
    }
}
