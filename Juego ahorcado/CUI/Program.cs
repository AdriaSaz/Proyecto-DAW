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
            int secreto = Juego.SecretoDeLaVida();
            Console.WriteLine(secreto+2);

            Console.ReadKey();
        }
    }
}
