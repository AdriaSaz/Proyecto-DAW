using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaJuego;



namespace CUI
{
    class Program
    {
        static void Main(string[] args)
        {
            char letra;
            bool acierto;
          
            string palabra;

            Console.WriteLine("Introduce una palabra a ocultar");
            palabra = Console.ReadLine();
            //Ocultamos palabra para mostrarla ocuulta
            Juego.OcultarPalabra(palabra);
            //recogemos la letra
            Juego.cargando();
            do
            {
                Console.WriteLine(Juego.intentos);
                Console.WriteLine("{0}", Juego.Oculto);
                Console.WriteLine("Introduce una letra");
                letra = Console.ReadLine()[0];
               acierto = Juego.ComprobarLetra(letra,palabra);
            } while (!Juego.fin && Juego.intentos != 7);
                
           
           
            Console.WriteLine(letra);
            Console.ReadKey();
        }
    }
}
