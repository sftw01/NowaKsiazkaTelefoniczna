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
        //funkcja wyswietlajaca w konsoli tekst w wybranym kolorze + cr+lf
        public static void WyswietlTekst(string tekst, ConsoleColor kolor)
        {
            Console.ForegroundColor = kolor;
            Console.WriteLine(tekst);
            Console.ResetColor();
        }

        //funkcja wyswietlajaca w konsoli tekst w wybranym kolorze bez cr+lf
        public static void WyswietlTekstBezNowejLinii(string tekst, ConsoleColor kolor)
        {
            Console.ForegroundColor = kolor;
            Console.Write(tekst);
            Console.ResetColor(); 

        }

        //funcja jako argument przyjmuje tekst i dlugosc jaki ma byc zwrocony string, zwraca tekst skrocony z wysrodkowanym tekstem
        public static string WysrodkujTekt(string tekst, int dlugosc)
        {
            if (tekst.Length > dlugosc)
            {
                return tekst.Substring(0, dlugosc);
            }
            else
            {
                int roznica = dlugosc - tekst.Length;
                int lewa = roznica / 2;
                int prawa = roznica - lewa;
                return new string(' ', lewa) + tekst + new string(' ', prawa);
            }
        }
        //funkcja wyswietlania kolorowej tabeli z danymi kontaktow
        public static void WyswietlTabele(Ksiazka ksiazka)
        {

 
        }
    }
}
