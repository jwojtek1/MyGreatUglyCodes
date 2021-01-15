using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Xml.Linq;
using System.Xml;
using System.Security.Cryptography.X509Certificates;

namespace TcpCommunication
{
    public class RejestrOsob
    {
        public static void Osoby()
        {


            for (; ; )
            {
                Console.Clear();
                Console.WriteLine("TWORZENIE KONTA\nWybierz jedną z opcji klikając cyfrę od 1 do 4:");
                Console.WriteLine("");

                Console.WriteLine("1. Znajdź konto");
                Console.WriteLine("2. Utwórz nowego użytkownika");
                Console.WriteLine("3. Wyświetl pełną listę użytkowników");
                Console.WriteLine("4. Zakończ program \n");

                string menu;
                menu = Console.ReadLine();

                if (menu == "1") //Szukanie i edycja użytkowników
                {

                    Console.Clear();
                    Console.WriteLine("Wybierz szukaną informację klikając cyfrę od 1 do 6 \n");
                    Console.WriteLine("1. Imię");
                    Console.WriteLine("2. Nazwisko");
                    Console.WriteLine("3. Wiek");
                    Console.WriteLine("4. Płeć");
                    Console.WriteLine("5. Dane adresowe");
                    Console.WriteLine("6. <-- Wróć do poprzedniego menu");

                    string wyszukaj;
                    wyszukaj = Console.ReadLine();

                    if (wyszukaj == "1")
                    {
                        XElement po = XElement.Load(@"I:\Studia semestr 5 notatki i materiały\Programowanie zaawansowane Ć\Rejestr\RejestrOsob\RejestrOsob.xml");
                        IEnumerable<XElement> RejestrOsob =
                            from el in po.Descendants("imię")
                            select el;
                        foreach (XElement Imie in RejestrOsob)
                            Console.WriteLine(Imie.Name + ":" + (string)Imie);
                        Console.ReadLine();
                    }
                    else if (wyszukaj == "2")
                    {
                        XElement po = XElement.Load(@"I:\Studia semestr 5 notatki i materiały\Programowanie zaawansowane Ć\Rejestr\RejestrOsob\RejestrOsob.xml");
                        IEnumerable<XElement> RejestrOsob =
                            from el in po.Descendants("nazwisko")
                            select el;
                        foreach (XElement Nazwisko in RejestrOsob)
                            Console.WriteLine(Nazwisko.Name + ":" + (string)Nazwisko);
                        Console.ReadLine();
                    }
                    else if (wyszukaj == "3")
                    {
                        XElement po = XElement.Load(@"I:\Studia semestr 5 notatki i materiały\Programowanie zaawansowane Ć\Rejestr\RejestrOsob\RejestrOsob.xml");
                        IEnumerable<XElement> RejestrOsob =
                            from el in po.Descendants("wiek")
                            select el;
                        foreach (XElement Wiek in RejestrOsob)
                            Console.WriteLine(Wiek.Name + ":" + (string)Wiek);
                        Console.ReadLine();
                    }
                    else if (wyszukaj == "4")
                    {
                        XElement po = XElement.Load(@"I:\Studia semestr 5 notatki i materiały\Programowanie zaawansowane Ć\Rejestr\RejestrOsob\RejestrOsob.xml");
                        IEnumerable<XElement> RejestrOsob =
                            from el in po.Descendants("płeć")
                            select el;
                        foreach (XElement Plec in RejestrOsob)
                            Console.WriteLine(Plec.Name + ":" + (string)Plec);
                        Console.ReadLine();
                    }
                    else if (wyszukaj == "5") //dane adresowe rozbite na poszczególne wartości
                    {
                        Console.Clear();
                        Console.WriteLine("Wybierz szukaną informację klikając cyfrę od 1 do 6 \n");
                        Console.WriteLine("1. Kod pocztowy");
                        Console.WriteLine("2. Miasto");
                        Console.WriteLine("3. Ulica");
                        Console.WriteLine("4. Nr domu");
                        Console.WriteLine("5. Nr mieszkania \n");
                        Console.WriteLine("6. <-- Wróć do poprzedniego menu");

                        string daneadresowe;
                        daneadresowe = Console.ReadLine();

                        if (daneadresowe == "1")
                        {
                            XElement po = XElement.Load(@"I:\Studia semestr 5 notatki i materiały\Programowanie zaawansowane Ć\Rejestr\RejestrOsob\RejestrOsob.xml");
                            IEnumerable<XElement> RejestrOsob =
                                from el in po.Descendants("kod_pocztowy")
                                select el;
                            foreach (XElement KodPocztowy in RejestrOsob)
                                Console.WriteLine(KodPocztowy.Name + ":" + (string)KodPocztowy);
                            Console.ReadLine();
                        }
                        else if (daneadresowe == "2")
                        {
                            XElement po = XElement.Load(@"I:\Studia semestr 5 notatki i materiały\Programowanie zaawansowane Ć\Rejestr\RejestrOsob\RejestrOsob.xml");
                            IEnumerable<XElement> RejestrOsob =
                                from el in po.Descendants("miasto")
                                select el;
                            foreach (XElement Miasto in RejestrOsob)
                                Console.WriteLine(Miasto.Name + ":" + (string)Miasto);
                            Console.ReadLine();
                        }
                        else if (daneadresowe == "3")
                        {
                            XElement po = XElement.Load(@"I:\Studia semestr 5 notatki i materiały\Programowanie zaawansowane Ć\Rejestr\RejestrOsob\RejestrOsob.xml");
                            IEnumerable<XElement> RejestrOsob =
                                from el in po.Descendants("ulica")
                                select el;
                            foreach (XElement Ulica in RejestrOsob)
                                Console.WriteLine(Ulica.Name + ":" + (string)Ulica);
                            Console.ReadLine();
                        }
                        else if (daneadresowe == "4")
                        {
                            XElement po = XElement.Load(@"I:\Studia semestr 5 notatki i materiały\Programowanie zaawansowane Ć\Rejestr\RejestrOsob\RejestrOsob.xml");
                            IEnumerable<XElement> RejestrOsob =
                                from el in po.Descendants("numer_domu")
                                select el;
                            foreach (XElement NrDomu in RejestrOsob)
                                Console.WriteLine(NrDomu.Name + ":" + (string)NrDomu);
                            Console.ReadLine();
                        }
                        else if (daneadresowe == "5")
                        {
                            XElement po = XElement.Load(@"I:\Studia semestr 5 notatki i materiały\Programowanie zaawansowane Ć\Rejestr\RejestrOsob\RejestrOsob.xml");
                            IEnumerable<XElement> RejestrOsob =
                                from el in po.Descendants("numer_mieszkania")
                                select el;
                            foreach (XElement NrMieszkania in RejestrOsob)
                                Console.WriteLine(NrMieszkania.Name + ":" + (string)NrMieszkania);
                            Console.ReadLine();
                        }
                        else if (daneadresowe == "6")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Proszę wybrać cyfrę od 1 do 6!");
                        }



                    }
                    else if (wyszukaj == "6")
                    {
                        //kod cofania menu
                    }
                    else
                    {
                        Console.WriteLine("Proszę wybrać cyfrę od 1 do 6!");
                    }





                }
                else if (menu == "2") //utwórz nowego użytkownika
                {
                    try
                    {
                        Console.WriteLine("Podaj swoje imię: ");
                        string Imie = Console.ReadLine();
                        Console.WriteLine("Podaj swoje nazwisko: ");
                        string Nazwisko = Console.ReadLine();
                        Console.WriteLine("Podaj swoją płeć: ");
                        string Plec = Console.ReadLine();
                        Console.WriteLine("Podaj miasto zamieszkania: ");
                        string Miasto = Console.ReadLine();
                        Console.WriteLine("Podaj ulicę na której mieszkasz: ");
                        string Ulica = Console.ReadLine();
                        Console.WriteLine("Podaj swój wiek: ");
                        string Wiek = Console.ReadLine();
                        Console.WriteLine("Podaj kod pocztowy: ");
                        string KodPocztowy = Console.ReadLine();
                        Console.WriteLine("Podaj numer domu: ");
                        string NrDomu = Console.ReadLine();
                        Console.WriteLine("Podaj numer mieszkania: ");
                        string NrMieszkania = Console.ReadLine();

                        List<Osoba> mojalista = new List<Osoba>();


                        mojalista.AddRange(new Osoba[]
                        {
                        new Osoba(""+Imie, "" +Nazwisko, ""+Plec, ""+Miasto, ""+Ulica, ""+Wiek, ""+KodPocztowy, ""+NrDomu, ""+NrMieszkania)

                        });




                        XDocument xml = new XDocument(
                            new XDeclaration("1.0", "utf-8", "yes"),
                            new XComment("Lista_osób_w_rejestrze"),
                            new XElement("Rejestr_osób", from osoba in mojalista
                                                         orderby osoba.Imie, osoba.Nazwisko, osoba.Plec, osoba.Miasto, osoba.Ulica, osoba.Wiek, osoba.KodPocztowy, osoba.NrDomu, osoba.NrMieszkania
                                                         select new XElement("Rejestr_osób",
                                                                new XElement("imię", osoba.Imie),
                                                                new XElement("nazwisko", osoba.Nazwisko),
                                                                new XElement("płeć", osoba.Plec),
                                                                new XElement("miasto", osoba.Miasto),
                                                                new XElement("ulica", osoba.Ulica),
                                                                new XElement("wiek", osoba.Wiek),
                                                                new XElement("kod_pocztowy", osoba.KodPocztowy),
                                                                new XElement("numer_domu", osoba.NrDomu),
                                                                new XElement("numer_mieszkania", osoba.NrMieszkania))));

                        xml.Save(@"I:\Studia semestr 5 notatki i materiały\Programowanie zaawansowane Ć\Rejestr\RejestrOsob\RejestrOsob.xml");

                        Console.WriteLine("Dziękujemy za wypełnienie kwestionariusza!");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Wprowadzasz błędne dane!");
                    }



                }
                else if (menu == "3") //odpal pełną listę użytkowników
                {
                    XElement po = XElement.Load(@"I:\Studia semestr 5 notatki i materiały\Programowanie zaawansowane Ć\Rejestr\RejestrOsob\RejestrOsob.xml");
                    Console.WriteLine(po);
                    Console.WriteLine("");
                    Console.WriteLine("Kliknij jakikolwiek klawisz aby wrócić");

                }
                else if (menu == "4") //kończenie pracy aplikacji
                { break; }
                else
                {
                    Console.WriteLine("Proszę podać cyfrę od 1 do 4!");
                }

                Console.ReadKey();
            }







        }
    }
}
