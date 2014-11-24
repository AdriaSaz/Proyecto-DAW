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
           ////// Persona p = new Persona("adria");

           ////// p.SetNombre("Rodolfo");


            Persona p3 = new Persona("Adria", "Saz");
           //////// Pruebas();
            Console.WriteLine(p3.NombreCompleto);
            Persona p2 = new Persona("Maria"); { Ape}
            
            Console.ReadKey();
        }

        //private static void Pruebas()
        //{
        //    Persona p;
        //    p = new Persona();

        //    Persona p2;
        //    p2 = p;
        //    p.Nombre = "pepito";

        //    Console.WriteLine(p.Nombre);
        //    string presentacion = p.Presentarse();
        //    Console.WriteLine(presentacion);
        //}

        static void TestPresentacion(  Persona p)
        {
           

            Console.WriteLine(p.Presentarse());
          

        }

      
    }
}
