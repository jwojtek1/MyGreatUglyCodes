using System;
using System.Xml.Serialization;
using System.IO;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TcpCommunication.Classes.Tamagochi
{
    public class Cialo
    {


        public static int Zdrowie { get; set; }
        public static int Higiena { get; set; }
        public static int Sytosc { get; set; }
        public static int Odchody { get; set; }
        public static int Dzien { get; set; }
        
       

        public static void WyborSzynszyli()
        {
            if (Sytosc >= 5)
            {
                Odchody += 2;
            }

            Console.Clear();
            LicznikDni();
            szynszyla();
            HUD();

            
        }

        public static void WyborSlonia()
        {
            if (Sytosc >= 8)
            {
                Odchody += 4;
            }
            Console.Clear();
            LicznikDni();
            slon();
            HUD();

        }

        public static void WyborPieska()
        {
            if (Sytosc >= 4)
            {
                Odchody += 2;
            }
            Console.Clear();
            LicznikDni();
            piesek();
            HUD();

        }


        public static void szynszyla()

        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("");
            Console.WriteLine("" + "\n" +
                                           "                            " + "\n" +
                                           "   /|_/|   /|" + "\n" +
                                           "  | . . | // " + "\n" +
                                           " |   .   |/" + "\n" +
                                           " |   o   |" + "\n" +
                                           " |_____/" + "\n" +
                                           "    /  \" ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine("");
        }

        public static void slon()

        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("");
            Console.WriteLine("" + "\n" +
                                            "            " + "\n" +
                                            " ---     ---" + "\n" +
                                            " |  |___/  |" + "\n" +
                                            " |  |   |  |" + "\n" +
                                            " | /|o o|| |" + "\n" +
                                            " |/ | ||| ||" + "\n" +
                                            "    |c||/" + "\n" +
                                            "     --\\___" + "\n" +
                                            "        |__/|" + "\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine("");
        }

        public static void piesek()
        
        {
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("" + "\n" +
                                           "                           " + "\n" +
                                           "   d/..|b" + "\n" +
                                           "    |  |" + "\n" +
                                           "    |  |" + "\n" +
                                           "   / |/ |" + "\n" +
                                           "  |  *   |" + "\n" +
                                           "  |      |" + "\n" +
                                           " |||----|||" + "\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine("");
        }



        public static void HUD()

        {
            

            Console.WriteLine("Zdrowie: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            for (var i = 0; i < Zdrowie; i++)
            {
                Console.Write("*");
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");

            Console.WriteLine("Sytosc: ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            for (var i = 0; i < Sytosc; i++)
            {
                Console.Write("*");
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");

            Console.WriteLine("Higiena: ");
            Console.ForegroundColor = ConsoleColor.Green;
            for (var i = 0; i < Higiena; i++)
            {
                Console.Write("*");
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");

            Console.WriteLine("Odchody: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            for (var i = 0; i < Odchody; i++)
            {
                Console.Write("*");
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");


        }

      
        public static void LicznikDni()
        {
            Console.WriteLine("Nastał " +Dzien +" dzień życia Twojego zwierzaka!");
        }

      
       
        

    }
}
