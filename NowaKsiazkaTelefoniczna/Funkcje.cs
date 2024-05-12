using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NowaKsiazkaTelefoniczna
{
    // funkcje pomocnicze dla ksiazki telefonicznej
    internal class Funkcje
    {
        //funkcja wyswietlajaca w konsoli tekst w wybranym kolorze
        public static void WyswietlTekst(string tekst, ConsoleColor kolor)
        {
            Console.ForegroundColor = kolor;
            Console.WriteLine(tekst);
            Console.ResetColor();
        }
    }
}
