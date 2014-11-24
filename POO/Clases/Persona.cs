using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Persona
    {
        public readonly DateTime Creacion;
        public String Apellido {get; set;}
        public string Email;

        public string Presentarse()
        {
            return "Hola, me llamo " + this.Nombre + " " + this.Apellido;
        }

        public Persona(string nombre)
        {
            this.Nombre = nombre;
        }
        String nombre;

        public string Nombre
        {
            get { return this.nombre; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentException("El nombre no es valido");
                this.nombre = value;
            }
        }

        // Constructor personas nombre + apellido
        public Persona(string nombre, string apellido) : this(nombre) // llama al constructor persona(nombre)
        {
            this.Apellido = apellido;
            this.Creacion = DateTime.Now;
        }

        public string NombreCompleto
        {
            get {  return this.Nombre + " " + this.Apellido; }
        }

        public DateTime FechaNacimiento { get; set; } 
    }
}
