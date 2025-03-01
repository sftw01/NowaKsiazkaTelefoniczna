﻿using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NowaKsiazkaTelefoniczna;

namespace NowaKsiazkaTelefoniczna
   
{
    internal class Program
    {
        //sort a list of contacts by name using LINQ
        private static IEnumerable<Kontakt> sortujLinq(List<Kontakt> kontakty)
        {
            var posortowanaKsiazka = kontakty.OrderBy(k => k.Imie).OrderBy(k => k.Nazwisko);        //sorted by name and surnname as second parameter, 
            posortowanaKsiazka.ToList().ForEach(k => k.Wyswietl());
            return posortowanaKsiazka;

        }

        //get ienumerable of contact contain adress as parameter
        private static IEnumerable<Kontakt> WyszukajPoMiescie(List<Kontakt> kontakty, string miasto)
        {
            var posortowanaKsiazka = kontakty.Where(k => k.Adres == miasto);
            posortowanaKsiazka.ToList().ForEach(k => k.Wyswietl());
            return posortowanaKsiazka;

        }

        static IEnumerable<Ksiazka> sortujPoImieniuLINQ( IEnumerable<Ksiazka>ksiazka)
        {
            var posortowanaKsiazka = ksiazka.OrderBy(k => k.kontakty[0].Imie);
            posortowanaKsiazka.ToList().ForEach(k => k.WyswietlKontakty());
            return posortowanaKsiazka;

        }

        //funkcja zwraca obiekt ksiazka z przykladowymi kontaktami do testow, 20 kontaktow, numer tele 3 cyfry
        private static Ksiazka PrzykladoweKontakty()
        {
            var ksiazka = new Ksiazka();

            ksiazka.DodajKontakt(new Kontakt("Jan", "Kowalski", "123", "Warszawa"));
            ksiazka.DodajKontakt(new Kontakt("Anna", "Nowak", "761", "Krakow"));
            ksiazka.DodajKontakt(new Kontakt("Piotr", "Kowalczyk", "189", "Gdansk"));
            ksiazka.DodajKontakt(new Kontakt("Krzysztof", "Nowak", "931", "Wroclaw"));
            ksiazka.DodajKontakt(new Kontakt("Marek", "Kowalski", "129", "Warszawa"));
            ksiazka.DodajKontakt(new Kontakt("Agnieszka", "Nowak", "921", "Krakow"));
            ksiazka.DodajKontakt(new Kontakt("Katarzyna", "Kowalczyk", "679", "Gdansk"));
            ksiazka.DodajKontakt(new Kontakt("Tomasz", "Nowak", "921", "Wroclaw"));
            ksiazka.DodajKontakt(new Kontakt("Michal", "Kowalski", "179", "Warszawa"));
            ksiazka.DodajKontakt(new Kontakt("Karolina", "Nowak", "321", "Krakow"));
            ksiazka.DodajKontakt(new Kontakt("Kamil", "Kowalczyk", "129", "Gdansk"));
            ksiazka.DodajKontakt(new Kontakt("Krzysztof", "Nowak", "541", "Wroclaw"));
            ksiazka.DodajKontakt(new Kontakt("Marek", "Kowalski", "248", "Warszawa"));
            ksiazka.DodajKontakt(new Kontakt("Agnieszka", "Nowak", "541", "Krakow"));

            ksiazka.kontakty[0].Ulubiony = true;

            ksiazka.kontakty[1].Ulubiony = true;

            ksiazka.kontakty[2].Zablokowany = true;
            return ksiazka;


        }



        static void Main(string[] args)
        {
            string sciezka = @"C:\Users\admin\Desktop\Moje C#\NowaKsiazkaTelefoniczna\NowaKsiazkaTelefoniczna\EkranPowitalny.txt";


            string tekst = System.IO.File.ReadAllText(sciezka);
            Console.WriteLine(tekst);

            //funkcja zwraca obiekt typu Kontakt jesli validacja poprawna lub null
            Kontakt DodajKontakt(Kontakt kontakt)
            {



                if (string.IsNullOrEmpty(kontakt.Imie) || string.IsNullOrEmpty(kontakt.NumerTelefonu))      //przeprowadz walidacje, jesli imie lub numer telefonu jest puste to zwroc null
                {
                    Console.WriteLine("Imie i numer telefonu nie moga byc puste");
                    return null;
                }

                return kontakt;
            }
            string wybor = null;
            wyswietlKonsoleGlowna(out wybor); //wyswietl menu glowne i w wybor mam wybor

            

            var ksiazka_przykladowa = PrzykladoweKontakty();  //moj obiekt ksiazki z przykladowymi kontaktami
            var ksiazka = new Ksiazka();                       //glowna ksiazka kontaktow

            

            ksiazka.DodajKontakty(ksiazka_przykladowa); //dodanie kontaktow z ksiazki przykladowej do glownej ksiazki

           ksiazka.DodajKontakt(new Kontakt("JanWielki", "001", ConsoleColor.Blue ));
            ksiazka.DodajKontakt(new Kontakt("Jappp", "002" , ConsoleColor.Blue));
            ksiazka.DodajKontakt(new Kontakt("Anna", "Nowak", "761", "Krakow", ConsoleColor.Blue));
            ksiazka.DodajKontakt(new Kontakt("Piotr", "K", ConsoleColor.Blue));
            ksiazka.DodajKontakt(new Kontakt("Krzysztof", "Nowak", "931", "Wroclaw", ConsoleColor.Blue));

            ksiazka.kontakty[0].Wyswietl();

            var posortowana = sortujLinq(ksiazka.kontakty);
            Ksiazka ksiazka2 = new Ksiazka(posortowana);        //create new book with sorted contacts
            //ksiazka2.WyswietlKontakty("Posortowana ksiazka");
            TabelaFormat.WyswietlTabeleKontakt(ksiazka2, "Posortowana ksiazka przez sysLINQ", ConsoleColor.Green);

            posortowana = WyszukajPoMiescie(ksiazka.kontakty, "Warszawa");
            Ksiazka ksiazka3 = new Ksiazka(posortowana);        //create new book with sorted contacts
            TabelaFormat.WyswietlTabeleKontakt(ksiazka3, "Kontakty z Warszawy", ConsoleColor.Green);

            //TabelaFormat.WyswietlTabele(ksiazka, "zawartsc ksiazki telefonicznej   jjj", ConsoleColor.Magenta);

            while (wybor != "0")
            {
                switch (wybor)
                {
                    case "1":
                        string imie, nazwisko, numerTelefonu, adres;
                        wyswietlKonsoleDodajKontakt(out imie, out nazwisko, out numerTelefonu, out adres); //funkcja wyswietlajaca w konsoli info o kontakcie

                        Kontakt temp_kontakt = null;                                        //tymczasowy obiekt kontaktu z wprowadzonych danych
                        temp_kontakt = new Kontakt(imie, nazwisko, numerTelefonu, adres);
    

                        Kontakt temp2_kontakt = DodajKontakt(temp_kontakt); //dodanie kontaktu do ksiazki, metoda dodajaca kontakt zwraca obiekt typu Kontakt jesli validacja poprawna lub null jesli cos wpisalismy zle
                       
                        if (temp2_kontakt != null)                          //jesli kontakt nie jest nullem dodajemy go do ksiazki
                        {
                            temp2_kontakt.Kolor = ConsoleColor.Blue;            //ustawienie koloru niebieskiego dla dla kontaktu wpisanego z reki
                            ksiazka.DodajKontakt(temp2_kontakt);
                      
                            Ksiazka temp = new Ksiazka();
                            temp.DodajKontakt(temp2_kontakt);
                            TabelaFormat.WyswietlTabeleKontakt(temp, "Dodano kontakt", ConsoleColor.Green);

                            //temp2_kontakt.Wyswietl();                       //wyswietl dane utworzonego kontaktu
                            //TabelaFormat.WyswietlTabele
                            Console.WriteLine();
                        }
                        else
                        {
                            //jesli kontakt jest nullem wyswietlamy komunikat - bledne dane wprowadzone do kontaktu
                            //Console.WriteLine("Nie dodano kontaktu - walidacja niepoprawnio");
                            Funkcje.WyswietlTekst("Nie dodano kontaktu - walidacja niepoprawnio", ConsoleColor.Red);
                        }                       

                        break;

                    case "2":
                        
                        string _wybor = null;

                        wyswietlKonsoleWyswietlKontakty(out _wybor);            //wyswietl menu wyboru dla wyswietlania kontaktow i w _wybor mam wybor

                        // ksiazka.WyswietlKontakty();                             //wyswietl wszystkie kontakty
                        while (_wybor != "0")
                        {
                            switch (_wybor)
                            {
                                case "1":
                                    //ksiazka.WyswietlKontakty();
                                    TabelaFormat.WyswietlTabele(ksiazka, "Wszystkie kontaktyw ksiazce.");
                                    break;

                                case "2":                                                       //wyszukiwanie po miescie
                                    string wyborMiasta = null;
                                    wyswietlWpiszMiasto(out wyborMiasta);
                                    Ksiazka ksiazka1 = ksiazka.WyszukajPoMiescie(wyborMiasta);
                                    ksiazka1.WyswietlKontakty("Kontakty z miasta "+ wyborMiasta );

                                    break;

                                case "6":
                                    ksiazka.SortujPoImieniu(ksiazka);
                                    TabelaFormat.WyswietlTabele(ksiazka, "Wszystkie kontaktyw ksiazce. Sortowanie imie.");
                                    break;

                                case "7":
                                    ksiazka.SortujPoNazwisku(ksiazka);
                                    TabelaFormat.WyswietlTabele(ksiazka, "Wszystkie kontaktyw ksiazce. Sortowanie nazwisko.1");
                                    break;

                                default:
                                    Console.WriteLine("Niepoprawny wybor");
                                    break;
                            }

                            wyswietlKonsoleWyswietlKontakty(out _wybor);            //wyswietl menu wyboru dla wyswietlania kontaktow i w _wybor mam wybor
                        }



                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Niepoprawny wybor");
                        //kolorowanie kazdej obiektyu w ksiazce
                        foreach (var kontakt in ksiazka.kontakty)
                        {                        
                            kontakt.Kolor = ConsoleColor.Red;
                           
                        }
                        ksiazka.WyswietlKontakty();
                        break;
                }

                wyswietlKonsoleGlowna(out wybor);
                
            }
            Console.WriteLine("Koniec programu");

            

 
        }

        private static void wyswietlWpiszMiasto(out string _wybor)
        {
            Console.Write("Podaj miasto: ");
            _wybor = Console.ReadLine();
        }

        private static void wyswietlKonsoleGlowna( out string _wybor )
        {
            Console.WriteLine("1: Dodaj nowy kontakt");
            Console.WriteLine("2: Wyswietl kontakty");
            Console.WriteLine("0: Zakoncz");
            _wybor = Console.ReadLine();                                             //zwroc wartosc wpisana przez uzytkownika
        }

        private static void wyswietlKonsoleDodajKontakt(out string imie, out string nazwisko, out string numerTelefonu, out string adres)
        {
            Console.Write("Podaj imie: ");
            imie = Console.ReadLine();
            Console.Write("Podaj nazwisko: ");
            nazwisko = Console.ReadLine();
            Console.Write("Podaj numer telefonu: ");
            numerTelefonu = Console.ReadLine();
            Console.Write("Podaj adres: ");
            adres = Console.ReadLine();
        }

        private static void wyswietlKonsoleWyswietlKontakty(out string wybor)
        {
            Console.WriteLine("1: Wyswietl wszystkie kontakty");
            Console.WriteLine("2: Wyswietl kontakty z danego miasta");
            Console.WriteLine("3: Wyswietl kontakty z danego numeru");
            Console.WriteLine("4: Wyswietl kontakty z danego przedzialu numerow");
            Console.WriteLine("5: Wyswietl kontakty z danego przedzialu nazwisk");
            Console.WriteLine("6: Sortuj alfabetycznie wg imienia");
            Console.WriteLine("7: Sortuj alfabetycznie wg nazwiska");
            Console.WriteLine("8: Sortuj wg numeru");
            Console.WriteLine("0: Powrot");
            
            wybor = Console.ReadLine();                                             //zwroc wartosc wpisana przez uzytkownika
           
        }

        
    }
}
