using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaJuego
{
    
    public static class Juego
    {
        public static int largo;
        public static string Oculto;
        public static bool fin = false;
        public static int intentos = 0;


        public static void OcultarPalabra(string palabra)
        {
            largo = palabra.Length;
            
            for (int i = 0; i < largo; i++)
            {
                Oculto = Oculto + "*";
            }

        }

        public static bool ComprobarLetra(char letra, string palabra)
        {
            for(int i = 0; i < largo; i++)
            {
                if(palabra.Substring(i,1)[0] == letra)
                {
                    palabra.Substring(i,1).Replace('*',letra);
                    return true;
                }
            }
            intentos++;
            return false;
        }
    }
}
