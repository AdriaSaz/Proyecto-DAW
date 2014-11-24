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

            bool acierto;
            int intento = 0;
            string palabra;

            Console.WriteLine("Introduce una palabra a ocultar");
            palabra = Console.ReadLine();
            //Ocultamos palabra para mostrarla ocuulta
            Juego.OcultarPalabra(palabra);
            //recogems la letra
            do
            {
                Console.WriteLine("Introduce una letra");
                char letra = Console.ReadLine()[0];
               acierto = Juego.ComprobarLetra(letra, palabra);
            } while (!Juego.fin && Juego.intentos != 7);
                
           
            Console.WriteLine("{0}",Juego.Oculto);
            Console.WriteLine(letra);
            Console.ReadKey();
        }
    }
}
