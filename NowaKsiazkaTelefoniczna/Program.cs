using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NowaKsiazkaTelefoniczna;

namespace NowaKsiazkaTelefoniczna
   
{
    internal class Program
    {
        

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

            return ksiazka;

        }



        static void Main(string[] args)
        {


            //funkcja zwraca obiekt typu Kontakt jesli validacja poprawna lub null
            Kontakt DodajKontakt(Kontakt kontakt)
            {



                if (string.IsNullOrEmpty(kontakt.Imie) || string.IsNullOrEmpty(kontakt.NumerTelefonu))
                {
                    Console.WriteLine("Imie i numer telefonu nie moga byc puste");
                    return null;
                }

                return kontakt;
            }




            Console.WriteLine("Nowa Ksiazka Telefoniczna");

            Console.WriteLine("1: Dodaj nowy kontakt");
            Console.WriteLine("2: Wyswietl kontakty");
            Console.WriteLine("3: Zakoncz");

            var wybor = Console.ReadLine();



            //moj obiekt ksiazki
            var ksiazka_przykladowa = PrzykladoweKontakty();

            var ksiazka = new Ksiazka();

            while (wybor != "3")
            {
                switch (wybor)
                {
                    case "1":
                        string imie, nazwisko, numerTelefonu, adres;
                        wyswietlKonsoleDodajKontakt(out imie, out nazwisko, out numerTelefonu, out adres); //funkcja wyswietlajaca w konsoli info o kontakcie

                        Kontakt temp_kontakt = null;                                        //tymczasowy obiekt kontaktu z wprowadzonych danych
                        temp_kontakt = new Kontakt(imie, nazwisko, numerTelefonu, adres);

                        Kontakt temp2_kontakt = DodajKontakt(temp_kontakt); //dodanie kontaktu do ksiazki, metoda dodajaca kontakt zwraca obiekt typu Kontakt jesli validacja poprawna lub null
                        if (temp2_kontakt != null)                          //jesli kontakt nie jest nullem dodajemy go do ksiazki
                        {                  
                            ksiazka.DodajKontakt(temp2_kontakt);
                            
                            //Console.WriteLine("Pomyślnie dodano kontakt");
                            Funkcje.WyswietlTekst("Pomyślnie dodano kontakt", ConsoleColor.Green);

                            temp2_kontakt.Wyswietl();                       //wyswietl dane utworzonego kontaktu
                        }
                        else
                        {
                            //jesli kontakt jest nullem wyswietlamy komunikat - bledne dane wprowadzone do kontaktu
                            //Console.WriteLine("Nie dodano kontaktu - walidacja niepoprawnio");
                            Funkcje.WyswietlTekst("Nie dodano kontaktu - walidacja niepoprawnio", ConsoleColor.Red);
                        }

                        //wyswietlenie kontaktow


                       // ksiazka.WyswietlKontakty();

                        break;
                    case "2":
                        ksiazka.WyswietlKontakty();


                        break;
                    case "3":
                        break;
                    default:
                        Console.WriteLine("Niepoprawny wybor");
                        break;
                }
                Console.WriteLine("1: Dodaj nowy kontakt");
                Console.WriteLine("2: Wyswietl kontakty");
                Console.WriteLine("3: Zakoncz");
                wybor = Console.ReadLine();
            }
            Console.WriteLine("Koniec programu");

        }

        private static void wyswietlKonsoleDodajKontakt(out string imie, out string nazwisko, out string numerTelefonu, out string adres)
        {
            Console.WriteLine("Podaj imie:");
            imie = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko:");
            nazwisko = Console.ReadLine();
            Console.WriteLine("Podaj numer telefonu:");
            numerTelefonu = Console.ReadLine();
            Console.WriteLine("Podaj adres:");
            adres = Console.ReadLine();
        }
    }
}
