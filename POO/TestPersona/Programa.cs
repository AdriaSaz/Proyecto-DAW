using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace TestPersona
{
    static class Programa
    {
        static void Main()
        {

           // Pruebas();
            TestPresentacion();
            Console.ReadKey();
        }

        private static void Pruebas()
        {
            Persona p;
            p = new Persona();

            Persona p2;
            p2 = p;
            p.Nombre = "pepito";

            Console.WriteLine(p.Nombre);
            string presentacion = p.Presentarse();
            Console.WriteLine(presentacion);
        }

        static void TestPresentacion()
        {
            Persona p1 = new Persona();
            p1.Nombre = "Roberto";
            p1.Apellido = "Perez";

            Persona p2 = new Persona();
            p2.Nombre = "Rodolfo";
            p2.Apellido = "Gomez";

            Console.WriteLine(p1.Presentarse());
            Console.WriteLine(p2.Presentarse());

        }
    }
}
