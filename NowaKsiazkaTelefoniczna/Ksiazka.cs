using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using NowaKsiazkaTelefoniczna;

namespace NowaKsiazkaTelefoniczna 
{
    //klasa ksiazka przechowujaca kontakty
    public  class Ksiazka 
    {
        //lista kontaktow
        public List<Kontakt> kontakty = new List<Kontakt>();

        public string idToken { get; } = TokenGenerator.GenerateToken();

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
            //zdefiniowane na stale kolory dla ulubionego i zablokowanego
            ConsoleColor ulubionyKolorDEF = ConsoleColor.Green;
            ConsoleColor zablokowanyKolorDEF = ConsoleColor.Red;
            
            ConsoleColor domyslnyKolorDEF = ConsoleColor.White;
            ConsoleColor kolorRamkiDEF = ConsoleColor.White;


            Funkcje.WyswietlTekst("-----------------------------------------------------------------------------------------------------------", kolorRamkiDEF);
            Funkcje.WyswietlTekst("|        Imie       |     Nazwisko      |  Numer telefonu  |     Adres     |  Ulubiony  |  Zablokowany  |", kolorRamkiDEF);
            Funkcje.WyswietlTekst("-----------------------------------------------------------------------------------------------------------", kolorRamkiDEF);

            foreach (var kontakt in kontakty)
            {
                ConsoleColor ulubionyKolor = kontakt.Ulubiony ? ulubionyKolorDEF : domyslnyKolorDEF; // Zielony, jeśli ulubiony, w przeciwnym razie biały
                ConsoleColor zablokowanyKolor = kontakt.Zablokowany ? zablokowanyKolorDEF : domyslnyKolorDEF; // Czerwony, jeśli zablokowany, w przeciwnym razie biały

                // Wyświetlanie danych kontaktu z odpowiednimi kolorami
                Funkcje.WyswietlTekstBezNowejLinii("| " , kolorRamkiDEF); Funkcje.WyswietlTekstBezNowejLinii(kontakt.Imie.PadRight(18), kontakt.Kolor);
                Funkcje.WyswietlTekstBezNowejLinii("| ", kolorRamkiDEF); Funkcje.WyswietlTekstBezNowejLinii(kontakt.Nazwisko.PadRight(18), kontakt.Kolor);
                Funkcje.WyswietlTekstBezNowejLinii("| ", kolorRamkiDEF); Funkcje.WyswietlTekstBezNowejLinii(kontakt.NumerTelefonu.PadRight(17), kontakt.Kolor);
                Funkcje.WyswietlTekstBezNowejLinii("| ", kolorRamkiDEF); Funkcje.WyswietlTekstBezNowejLinii(kontakt.Adres.PadRight(14), kontakt.Kolor);

                string ulubiony = kontakt.Ulubiony ? "   Tak" : "   Nie";
                string zablokowany = kontakt.Zablokowany ? "     Tak" : "     Nie";

                Funkcje.WyswietlTekstBezNowejLinii("| ", kolorRamkiDEF); Funkcje.WyswietlTekstBezNowejLinii(ulubiony.PadRight(11), ulubionyKolor);
                Funkcje.WyswietlTekstBezNowejLinii("| ", kolorRamkiDEF); Funkcje.WyswietlTekstBezNowejLinii(zablokowany.PadRight(14), zablokowanyKolor);

                Funkcje.WyswietlTekst("| ", kolorRamkiDEF);

            }

            Funkcje.WyswietlTekst("------------------------------------------------------------------------------------------------------------------", ConsoleColor.White);
        }


        //metoda wyswietlajaca wszystkie informacje i ilosc kontaktow w ksiazce z wybrana nazwa tabeli
        public void WyswietlKontakty(string nazwaTabeli)
        {
            //zdefiniowane na stale kolory dla ulubionego i zablokowanego
            ConsoleColor ulubionyKolorDEF = ConsoleColor.Green;
            ConsoleColor zablokowanyKolorDEF = ConsoleColor.Red;

            ConsoleColor domyslnyKolorDEF = ConsoleColor.White;
            ConsoleColor kolorRamkiDEF = ConsoleColor.White;

            ConsoleColor kolorInfo = ConsoleColor.Yellow;

            Funkcje.WyswietlTekst("-----------------------------------------------------------------------------------------------------------", kolorRamkiDEF);
            Funkcje.WyswietlTekstBezNowejLinii("|", kolorRamkiDEF);
            Funkcje.WyswietlTekstBezNowejLinii(Funkcje.WysrodkujTekt(nazwaTabeli, 105), kolorInfo);
            Funkcje.WyswietlTekst("|", kolorRamkiDEF);
            //Funkcje.WyswietlTekst("-----------------------------------------------------------------------------------------------------------", kolorRamkiDEF);

            Funkcje.WyswietlTekst("-----------------------------------------------------------------------------------------------------------", kolorRamkiDEF);
            Funkcje.WyswietlTekst("|        Imie       |     Nazwisko      |  Numer telefonu  |     Adres     |  Ulubiony  |  Zablokowany    |", kolorRamkiDEF);
            Funkcje.WyswietlTekst("-----------------------------------------------------------------------------------------------------------", kolorRamkiDEF);

            foreach (var kontakt in kontakty)
            {
                ConsoleColor ulubionyKolor = kontakt.Ulubiony ? ulubionyKolorDEF : domyslnyKolorDEF; // Zielony, jeśli ulubiony, w przeciwnym razie biały
                ConsoleColor zablokowanyKolor = kontakt.Zablokowany ? zablokowanyKolorDEF : domyslnyKolorDEF; // Czerwony, jeśli zablokowany, w przeciwnym razie biały

                // Wyświetlanie danych kontaktu z odpowiednimi kolorami
                Funkcje.WyswietlTekstBezNowejLinii("| ", kolorRamkiDEF); Funkcje.WyswietlTekstBezNowejLinii(kontakt.Imie.PadRight(18), kontakt.Kolor);
                Funkcje.WyswietlTekstBezNowejLinii("| ", kolorRamkiDEF); Funkcje.WyswietlTekstBezNowejLinii(kontakt.Nazwisko.PadRight(18), kontakt.Kolor);
                Funkcje.WyswietlTekstBezNowejLinii("| ", kolorRamkiDEF); Funkcje.WyswietlTekstBezNowejLinii(kontakt.NumerTelefonu.PadRight(17), kontakt.Kolor);
                Funkcje.WyswietlTekstBezNowejLinii("| ", kolorRamkiDEF); Funkcje.WyswietlTekstBezNowejLinii(kontakt.Adres.PadRight(14), kontakt.Kolor);

                string ulubiony = kontakt.Ulubiony ? "   Tak" : "   Nie";
                string zablokowany = kontakt.Zablokowany ? "     Tak" : "     Nie";

                Funkcje.WyswietlTekstBezNowejLinii("| ", kolorRamkiDEF); Funkcje.WyswietlTekstBezNowejLinii(ulubiony.PadRight(11), ulubionyKolor);
                Funkcje.WyswietlTekstBezNowejLinii("| ", kolorRamkiDEF); Funkcje.WyswietlTekstBezNowejLinii(zablokowany.PadRight(14), zablokowanyKolor);

                Funkcje.WyswietlTekst("| ", kolorRamkiDEF);

            }

            Funkcje.WyswietlTekst("--------------------------------------------------------------------------------------------------------------", ConsoleColor.White);
        }

        //metoda sortuje ksiazke po imieniu
        public void SortujPoImieniu(Ksiazka ksiazka)
        {
            ksiazka.kontakty.Sort((x, y) => string.Compare(x.Imie, y.Imie));
        }

        //metoda wyszukuje kontakty po miastu i zwraca nowa ksiazke z tymi kontaktami
        public Ksiazka WyszukajPoMiescie(string miasto)
        {
            Ksiazka ksiazka = new Ksiazka();
            foreach (var kontakt in kontakty)
            {
                if (kontakt.Adres.Contains(miasto))
                {
                    ksiazka.DodajKontakt(kontakt);
                }
            }

            return ksiazka;
        }

        //metoda zwraca ilosc kontaktow w ksiazce
        public int IloscKontaktow()
        {
            return kontakty.Count;
        }
    }
}
