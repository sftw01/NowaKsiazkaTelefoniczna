using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NowaKsiazkaTelefoniczna;

namespace NowaKsiazkaTelefoniczna
{
    

    //klasa kontakt przechowujaca podstawowe informacje o kontakcie
    internal class Kontakt
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string NumerTelefonu { get; set; }
        public string Adres { get; set; }
        
        public ConsoleColor Kolor { get; set; }                 //zmienna koloru dla konsoli


        //pusty konstruktor klasy Kontakt, wykonywany zawwse 
        public Kontakt() : this("", "", "", "")
        {
            Kolor = ConsoleColor.DarkYellow;                    //kolor domyslny dla nowego kontaktu
        }
        //konstruktor klasy Kontakt przyjmujacy 2 parametry, imie i numer telefonu
        public Kontakt(string imie, string numerTelefonu)
        {
            Imie = imie;
            NumerTelefonu = numerTelefonu;          
        }

        //konstruktor klasy Kontakt przyjmujacy 4 parametry
        public Kontakt(string imie, string nazwisko, string numerTelefonu, string adres)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            NumerTelefonu = numerTelefonu;
            Adres = adres;
        }

        //metada wyswietlajaca w konsoli info o kontakcie
        public void Wyswietl()
        {
            //Console.WriteLine($"Imie: {Imie}, Nazwisko: {Nazwisko}, Numer: {NumerTelefonu}, Adres: {Adres}");
            //Console.WriteLine($"Imie: {Imie,-10} Nazwisko: {Nazwisko,-10} Numer: {NumerTelefonu,-15} Adres: {Adres}");
            Funkcje.WyswietlTekst($"Imie: {Imie,-10} Nazwisko: {Nazwisko,-10} Numer: {NumerTelefonu,-15} Adres: {Adres}", Kolor);
        }
    }
}
