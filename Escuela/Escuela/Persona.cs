using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escuela
{
    // Declaración de la clase padre "Persona" 
    public abstract class Persona
    {
        // Declara los atributos especificando el tipo de dato de cada uno
        protected string nombre;
        protected string apellido;
        protected int dni;
        protected string email;
        protected string domicilio;
        protected DateTime fechaNacimiento;
        // Declaración de funciones para obtener los valores y asignar en las funciones
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Apellido { get { return apellido; } set { apellido = value; } }
        public int Dni { get { return dni; } set { dni = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Domicilio { get { return domicilio; } set { domicilio = value; } }
        public DateTime FechaNacimiento { get { return fechaNacimiento; } set { fechaNacimiento = value; } }
    }
}
