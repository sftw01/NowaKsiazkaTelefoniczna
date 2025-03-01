﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NowaKsiazkaTelefoniczna;

namespace NowaKsiazkaTelefoniczna
{


    //klasa kontakt przechowujaca podstawowe informacje o kontakcie
    public  class Kontakt
    {
        public string Imie { get; set; } = "";
        public string Nazwisko { get; set; } = "";
        public string NumerTelefonu { get; set; } = "";
        public string Adres { get; set; } = "";
        public ConsoleColor Kolor  { get; set; }                 //zmienna koloru dla konsoli

        public bool Ulubiony { get; set; } = false;             //czy kontakt jest ulubiony
        public bool Zablokowany { get; set; } = false;          //czy kontakt jest zablokowany, ochrona przed usunieciem

        public string idToken { get; } = TokenGenerator.GenerateToken();               //token do identyfikacji kontaktu



        public Kontakt()
        {
            Kolor = ConsoleColor.DarkYellow; // kolor domyślny dla nowego kontaktu
        }

        public Kontakt(ConsoleColor kolor) : this()
        {
            Kolor = kolor;
        }

        public Kontakt(string imie, string numerTelefonu) : this(ConsoleColor.DarkYellow)
        {
            Imie = imie;
            NumerTelefonu = numerTelefonu;
        }

        public Kontakt(string imie, string numerTelefonu, ConsoleColor kolor) : this(kolor)
        {
            Imie = imie;
            NumerTelefonu = numerTelefonu;
        }

        public Kontakt(string imie, string nazwisko, string numerTelefonu, string adres) : this(imie, numerTelefonu)
        {
            Nazwisko = nazwisko;
            Adres = adres;
        }

        public Kontakt(string imie, string nazwisko, string numerTelefonu, string adres, ConsoleColor kolor) : this(imie, nazwisko, numerTelefonu, adres)
        {
            Kolor = kolor;
        }


        //metada wyswietlajaca w konsoli info o kontakcie
        public void Wyswietl()
        {
            //Console.WriteLine($"Imie: {Imie}, Nazwisko: {Nazwisko}, Numer: {NumerTelefonu}, Adres: {Adres}");
            //Console.WriteLine($"Imie: {Imie,-10} Nazwisko: {Nazwisko,-10} Numer: {NumerTelefonu,-15} Adres: {Adres}");
            string ulubiony = Ulubiony ? "TAK" : "NIE";
            string zablokowany = Zablokowany ? "TAK" : "NIE";

            Funkcje.WyswietlTekst($"Imie: {Imie,-10} Nazwisko: {Nazwisko,-10} Numer: {NumerTelefonu,-15} Adres: {Adres,-10} Ulubiony: {ulubiony,-5} Zablokowany: {zablokowany,-5} ID Token: {idToken, -10}", Kolor);


        }
    }
}
