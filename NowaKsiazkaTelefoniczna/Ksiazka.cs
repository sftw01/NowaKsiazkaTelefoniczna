using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NowaKsiazkaTelefoniczna 
{
    //klasa ksiazka przechowujaca kontakty
    internal class Ksiazka 
    {
        //lista kontaktow
        private List<Kontakt> kontakty = new List<Kontakt>();

        //metoda dodajaca kontakt do ksiazki
        public void DodajKontakt(Kontakt kontakt)
        {
            kontakty.Add(kontakt);
        }

        //metoda dodajaca liste ksiazke do ksiazki
        public void DodajKontakty(Ksiazka ksiazkaDodawana)
        {
            foreach (var kontakt in ksiazkaDodawana.kontakty)           //przelatuje cala ksiazke i dfodaje do obecnej
            {
                kontakty.Add(kontakt);
            }
        }

        //metoda wyswietlajaca wszystkie informacje i ilosc kontaktow w ksiazce
        public void WyswietlKontakty()
        {
            Console.WriteLine($"------------        Lista kontaktow        ------------------");
            foreach (var kontakt in kontakty)
            {
                kontakt.Wyswietl();
                //Console.WriteLine();
            }
            Console.WriteLine($" ----------- Ilosc kontaktow: {kontakty.Count} -----------");
  
        }
    }
}
