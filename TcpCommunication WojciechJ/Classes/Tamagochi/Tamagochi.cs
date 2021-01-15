using System;
using System.Threading;
using System.Xml.Serialization;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TcpCommunication.Classes.Tamagochi
{

    class Tamagochi
    {
       
        public static void Gramy()

        {


            for (; ; )

            {


                {
                    Console.Clear();
                    Console.WriteLine("Witaj w grze Tamagochi!");
                    Console.WriteLine("");
                    Console.WriteLine("1. Nowa gra");
                    Console.WriteLine("2. Jak grać?");
                    Console.WriteLine("3. O autorach");
                    Console.WriteLine("4. Wyjdź z programu");

                    string wyboropcji;
                    string wyborzwierzaka;

                    wyboropcji = Console.ReadLine();

                    if (wyboropcji == "1")
                    {
                        for (; ;)
                        {

                        
                        Console.Clear();
                        Console.WriteLine("");
                        Console.WriteLine("Wybierz swojego pupila!");
                        Console.WriteLine("");
                            Console.WriteLine("1. Szynszyla" + "\n" +
                                           "                            " + "\n" +
                                           "   /|_/|   /|" + "\n" +
                                           "  | . . | // " + "\n" +
                                           " |   .   |/" + "\n" +
                                           " |   o   |" + "\n" +
                                           " |_____/" + "\n" +
                                           "    /  \" ");
                            Console.WriteLine("");
                            Console.WriteLine("2. Piesek" + "\n" +
                                "                           " + "\n" +
                                "   d/..|b" + "\n" +
                                "    |  |" + "\n" +
                                "    |  |" + "\n" +
                                "   / |/ |" + "\n" +
                                "  |  *   |" + "\n" +
                                "  |      |" + "\n" +
                                " |||----|||" + "\n");
                            Console.WriteLine("");
                            Console.WriteLine("3. Słoń"+ "\n" +
                                "            " + "\n" +
                                " ---     ---" + "\n" +
                                " |  |___/  |" + "\n" +
                                " |  |   |  |" + "\n" +
                                " | /|o o|| |" + "\n" +
                                " |/ | ||| ||" + "\n" +
                                "    |c||/" + "\n" +
                                "     --\\___" + "\n" +
                                "        |__/|" + "\n");
                            Console.WriteLine("");
                            Console.WriteLine("4. Wróc do poprzedniego menu");

                        wyborzwierzaka = Console.ReadLine();
                         

                        if (wyborzwierzaka == "1")
                        {

                                Classes.Tamagochi.Szynszyla.GraSzynszyla();

                        }

                        else if (wyborzwierzaka == "2")
                        {
                                Classes.Tamagochi.Pies.GraPies();
                            }

                        else if (wyborzwierzaka == "3")
                        {
                                Classes.Tamagochi.Slon.GraSlon();
                            }

                        else if (wyborzwierzaka == "4")
                        {
                                Console.Clear();
                                break;
                        }

                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Zaznacz opcję od 1 do 4!");
                            Console.ReadKey();
                        }

                        }

                    }

                    else if (wyboropcji == "2")
                    {
                        Console.Clear();
                        Console.WriteLine("");
                        Console.WriteLine("************Tamagochi************");
                        Console.WriteLine("*Twoje doświadczenia z grą, będą*");
                        Console.WriteLine("*się różnić w zależności od tego*");
                        Console.WriteLine("*jakie zwierzę wybierzesz.      *");
                        Console.WriteLine("*Jeśli zdrowie,głód lub higiena *");
                        Console.WriteLine("*Twojego pupila spadną do zera, *");
                        Console.WriteLine("*zwierzątko umrze.Dlatego trzeba*");
                        Console.WriteLine("*bacznie obserwować te trzy pola*");
                        Console.WriteLine("*                               *");
                        Console.WriteLine("*Do gry używamy czterech guzików*");
                        Console.WriteLine("*                               *");
                        Console.WriteLine("*1 - poprawia higienę zwierzaka.*");
                        Console.WriteLine("*2 - poprawia zdrowie zwierzaka.*");
                        Console.WriteLine("*3 - karmienie zwierzaka.       *");
                        Console.WriteLine("*4 - sprzątanie odchodów.       *");
                        Console.WriteLine("*********************************");
                        Console.WriteLine("");
                        Console.WriteLine("Wciśnij jakikolwiek klawisz aby wrócić!");
                        Console.ReadKey();
                    }
                    else if (wyboropcji == "3")
                    {
                        Console.Clear();
                        Console.WriteLine();
                        ConsoleColor PreviousForegroundColor = Console.ForegroundColor;
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("-----------------------------" + "\n" + "|                           |" + "\n" + "|                           |"
                        + "\n" + "|                           |" + "\n" + "|        AUTORZY GRY:       |" + "\n" + "|                           |" + "\n" + "|                           |"
                        + "\n" + "|                           |" + "\n" + "|     Wojciech Jasiński     |" + "\n" + "|                           |" + "\n" + "|       Mateusz Kałek       |"
                        + "\n" + "|                           |" + "\n" + "|                           |" + "\n" + "|                           |" + "\n" + "-----------------------------");
                        Console.ForegroundColor = PreviousForegroundColor;
                        Console.ReadKey();
                    }

                    else if (wyboropcji == "4")
                    {
                        Console.Clear();
                        Console.WriteLine("Do następnego razu!");
                        Console.ReadKey();
                        return;

                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Zaznacz opcję od 1 do 4!");
                        Console.ReadKey();


                    }
                }

            }
        }

       
    }
}
