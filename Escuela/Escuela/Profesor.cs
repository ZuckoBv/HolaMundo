using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Escuela
{
    public enum Categoria
    {
        Titular,
        Suplente,
        Provisional 
    }
    public class Profesor : Persona
    {
        protected string materia;
        protected string titulo;
        protected Categoria categoria;
        public string Materia { get { return materia; } set { materia = value; } }
        public string Titulo { get { return titulo; } set { titulo = value; } }
        public string Tipo { 
            get {  
                switch(categoria)
                {
                    case Categoria.Titular:
                        return "Titular";
                    case Categoria.Suplente:
                        return "Suplente";
                    case Categoria.Provisional:
                        return "Provisional";
                    default:
                        return "";

                }
            } 
           private set { 
                    
            }
        }

        public Profesor(string mater, string titu, Categoria categ)
        {
            materia = mater;
            titulo = titu;
            categoria = categ;
        }
        public void SetTipo(Categoria nuevoTipo)
        {
            categoria = nuevoTipo;
        }
    }
}
