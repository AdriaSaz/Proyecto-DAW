using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Persona
    {
        public String Nombre;
        public String Apellido;
        public string Email;

        public string Presentarse()
        {
            return "Hola, me llamo " + this.Nombre + " " + this.Apellido;
        }

    }
}
