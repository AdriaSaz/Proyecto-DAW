using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUI
{
    class Program
    {
        static void Main(string[] args)
        {
            int secreto = Logica_Juego.LogicaJuego.SecretoDeLaVida();
            Console.WriteLine(secreto);
            Console.ReadKey();
        }
    }
}
