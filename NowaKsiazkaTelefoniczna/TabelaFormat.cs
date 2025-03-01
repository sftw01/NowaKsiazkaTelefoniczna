﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NowaKsiazkaTelefoniczna
{

    //klasa do wyswietlania tabeli sformatowanych z danymi kontaktow
    public static class TabelaFormat
    {

        public static ConsoleColor KolorRamki { get; set; } = ConsoleColor.White;
        public static ConsoleColor KolorInfo { get; set; } = ConsoleColor.Yellow;
        public static ConsoleColor UlubionyKolor { get; set; } = ConsoleColor.Green;
        public static ConsoleColor ZablokowanyKolor { get; set; } = ConsoleColor.Red;
        public static ConsoleColor DomyslnyKolor { get; set; } = ConsoleColor.White;


       //wyswietl liste kontaktow
       public static void WyswietlTabele(Ksiazka ksiazka)
        {
            WyswietlNaglowek();
            WyswietlKontakt(ksiazka);
            WyswietlLinie(KolorRamki);
            WyswietlIloscKontaktow(ksiazka);
        }

        //wyswietl metode przeciazona WyswietlTabele o nazwe Tabeli
        public static void WyswietlTabele(Ksiazka ksiazka, string nazwaTabeli)
        {
            WyswietlInfo(nazwaTabeli);
            WyswietlNaglowekKrotka();
            WyswietlKontakt(ksiazka);
            WyswietlLinie(KolorRamki);
            WyswietlIloscKontaktow(ksiazka);
        }
        //wyswietl metode przeciazona WyswietlTabele o nazwe Tabeli i kolor nazwy
        public static void WyswietlTabele(Ksiazka ksiazka, string nazwaTabeli, ConsoleColor kolorNazwy)
        {
            WyswietlInfo(nazwaTabeli, kolorNazwy);
            WyswietlNaglowek();
            WyswietlKontakt(ksiazka);
            WyswietlLinie(KolorRamki);
            WyswietlIloscKontaktow(ksiazka);
        }

        //wyswietl tylko jeden kontakt i tabele info z wybranym kolorem - ktorkie wyswietlenie ibnfo taki messagebox
        public static void WyswietlTabeleKontakt(Ksiazka ksiazka, string nazwaTabeli, ConsoleColor kolorNazwy)
        {
            WyswietlInfo(nazwaTabeli, kolorNazwy);
            WyswietlNaglowekKrotka();
            WyswietlKontakt(ksiazka);
            WyswietlLinie(KolorRamki);

        }



        //funkcja wyswietla ramke info z informacja, przyjmuje arg tekst
        public static void WyswietlInfo(string tekst)
        {
            WyswietlLinie(KolorRamki);
            Funkcje.WyswietlTekstBezNowejLinii("|", KolorRamki);
            Funkcje.WyswietlTekstBezNowejLinii( Funkcje.WysrodkujTekt(tekst, 113), KolorInfo );
            Funkcje.WyswietlTekst("|", KolorRamki);
            WyswietlLinie(KolorRamki);
        }

        //funkcja wyswietla ramke info z informacja, przyjmuje arg tekst i kolor
        public static void WyswietlInfo(string tekst, ConsoleColor kolor)
        {
            WyswietlLinie(KolorRamki);
            Funkcje.WyswietlTekstBezNowejLinii("|", KolorRamki);
            Funkcje.WyswietlTekstBezNowejLinii(Funkcje.WysrodkujTekt(tekst, 113), kolor);
            Funkcje.WyswietlTekst("|", KolorRamki);
            WyswietlLinie(KolorRamki);
        }

        //funkcja wyswietla ramke informacyjna o zawartosci pol
        public static void WyswietlNaglowek()
        {
            WyswietlLinie(KolorRamki);
            Funkcje.WyswietlTekst("|        Imie     |     Nazwisko    | Numer telefonu |     Adres     |  Ulubiony  |  Zablokowany    |    ID Token   |   ", KolorRamki);
            WyswietlLinie(KolorRamki);
        }
        //funkcja wyswietla ramke informacyjna o zawartosci pol wrrsja skrocoa
        public static void WyswietlNaglowekKrotka()
        {


            Funkcje.WyswietlTekst("|        Imie     |     Nazwisko    | Numer telefonu |     Adres     |  Ulubiony  |  Zablokowany    |   ID Token  |   ", KolorRamki);
            WyswietlLinie(KolorRamki);
        }

        //funkcja wyswietla informacje o kontaktach w tabeli
        public static void WyswietlKontakt(Ksiazka ksiazka)
        {


            foreach (var kontakt in ksiazka.kontakty)
            {
                ConsoleColor ulubionyKolor = kontakt.Ulubiony ? UlubionyKolor : DomyslnyKolor; // Zielony, jeśli ulubiony, w przeciwnym razie biały
                ConsoleColor zablokowanyKolor = kontakt.Zablokowany ? ZablokowanyKolor : DomyslnyKolor; // Czerwony, jeśli zablokowany, w przeciwnym razie biały

                Funkcje.WyswietlTekstBezNowejLinii("| ", KolorRamki); Funkcje.WyswietlTekstBezNowejLinii(kontakt.Imie.PadRight(16), kontakt.Kolor);
                Funkcje.WyswietlTekstBezNowejLinii("| ", KolorRamki); Funkcje.WyswietlTekstBezNowejLinii(kontakt.Nazwisko.PadRight(16), kontakt.Kolor);
                Funkcje.WyswietlTekstBezNowejLinii("| ", KolorRamki); Funkcje.WyswietlTekstBezNowejLinii(kontakt.NumerTelefonu.PadRight(15), kontakt.Kolor);
                Funkcje.WyswietlTekstBezNowejLinii("| ", KolorRamki); Funkcje.WyswietlTekstBezNowejLinii(kontakt.Adres.PadRight(14), kontakt.Kolor);

                string ulubiony = kontakt.Ulubiony ? "   Tak" : "   Nie";
                string zablokowany = kontakt.Zablokowany ? "      Tak" : "      Nie";

                Funkcje.WyswietlTekstBezNowejLinii("| ", KolorRamki); Funkcje.WyswietlTekstBezNowejLinii(ulubiony.PadRight(11), ulubionyKolor);
                Funkcje.WyswietlTekstBezNowejLinii("| ", KolorRamki); Funkcje.WyswietlTekstBezNowejLinii(zablokowany.PadRight(16), zablokowanyKolor);

                Funkcje.WyswietlTekstBezNowejLinii("| ", KolorRamki); Funkcje.WyswietlTekstBezNowejLinii("  " + kontakt.idToken.PadRight(10), kontakt.Kolor);

                Funkcje.WyswietlTekst("| ", KolorRamki);
            }

        }


        //linia oddzielajaca
        public static void WyswietlLinie(ConsoleColor kolor)
        {
            Funkcje.WyswietlTekst("-------------------------------------------------------------------------------------------------------------------", kolor);
        }

        //wyswiet ilosc kontaktow - ramka sformatowana ILOSC KONTAKTOW
        public static void WyswietlIloscKontaktow(Ksiazka ksiazka)
        {
            string ilosc = ksiazka.kontakty.Count.ToString();
            WyswietlLinie(KolorRamki);
            Funkcje.WyswietlTekstBezNowejLinii("|", KolorRamki);
            Funkcje.WyswietlTekstBezNowejLinii(Funkcje.WysrodkujTekt($"                                                                                     ILOSC KONTAKTOW: {ilosc}", 113), KolorInfo);

            Funkcje.WyswietlTekst("|", KolorRamki);
            WyswietlLinie(KolorRamki);
        }


    }

}
