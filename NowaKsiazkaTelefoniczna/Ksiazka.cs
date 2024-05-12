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
        public void DodajKontakty(List<Kontakt> kontakty)
        {
            this.kontakty.AddRange(kontakty);
        }

        //metoda wyswietlajaca kontakty z ksiazki
        public void WyswietlKontakty()
        {
            foreach (var kontakt in kontakty)
            {
                kontakt.Wyswietl();
                //Console.WriteLine();
            }
        }
    }
}
