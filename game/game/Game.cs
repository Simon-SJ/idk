using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace game
{
    class Game
    {
        public void Start()
        {
            Title = "Skynet";
            RunMainMenu();
        }

        private void RunMainMenu()
        {
            string prompt = @"
 ▄▄▄▄▄▄▄▄▄▄▄  ▄    ▄  ▄         ▄  ▄▄        ▄  ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄▄ 
▐░░░░░░░░░░░▌▐░▌  ▐░▌▐░▌       ▐░▌▐░░▌      ▐░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌
▐░█▀▀▀▀▀▀▀▀▀ ▐░▌ ▐░▌ ▐░▌       ▐░▌▐░▌░▌     ▐░▌▐░█▀▀▀▀▀▀▀▀▀  ▀▀▀▀█░█▀▀▀▀ 
▐░▌          ▐░▌▐░▌  ▐░▌       ▐░▌▐░▌▐░▌    ▐░▌▐░▌               ▐░▌     
▐░█▄▄▄▄▄▄▄▄▄ ▐░▌░▌   ▐░█▄▄▄▄▄▄▄█░▌▐░▌ ▐░▌   ▐░▌▐░█▄▄▄▄▄▄▄▄▄      ▐░▌     
▐░░░░░░░░░░░▌▐░░▌    ▐░░░░░░░░░░░▌▐░▌  ▐░▌  ▐░▌▐░░░░░░░░░░░▌     ▐░▌     
 ▀▀▀▀▀▀▀▀▀█░▌▐░▌░▌    ▀▀▀▀█░█▀▀▀▀ ▐░▌   ▐░▌ ▐░▌▐░█▀▀▀▀▀▀▀▀▀      ▐░▌     
          ▐░▌▐░▌▐░▌       ▐░▌     ▐░▌    ▐░▌▐░▌▐░▌               ▐░▌     
 ▄▄▄▄▄▄▄▄▄█░▌▐░▌ ▐░▌      ▐░▌     ▐░▌     ▐░▐░▌▐░█▄▄▄▄▄▄▄▄▄      ▐░▌     
▐░░░░░░░░░░░▌▐░▌  ▐░▌     ▐░▌     ▐░▌      ▐░░▌▐░░░░░░░░░░░▌     ▐░▌     
 ▀▀▀▀▀▀▀▀▀▀▀  ▀    ▀       ▀       ▀        ▀▀  ▀▀▀▀▀▀▀▀▀▀▀       ▀      
                                                                      
use the Arrow Keys to cycle";
            string[] options = { "Love Tester", "Social Credit System", "China Quiz", "Calculator", "Timer", "Dance", "Friday Night Funkin", "About", "Exit"};
            Menu mainMenu = new Menu(prompt, options);
            int selectedIndex = mainMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    RunLoveTester();
                    break;
                case 1:
                    RunChina();
                    break;
                case 2:
                    RunQuiz();
                    break;
                case 3:
                    RunCal();
                    break;
                case 4:
                    RunTimer();
                    break;
                case 5:
                    RunDance();
                    break;
                case 6:
                    RunFNF();
                    break;
                case 7:
                    RunAbout();
                    break;
                case 8:
                    ExitGame();
                    break;
            }
        }
        //The code exites the program
        private void ExitGame()
        {
            Environment.Exit(0);
        }
        //gives you a random number 1400-0
        private void RunChina()
        {
            string name1;
            Console.Write("name: ");
            name1 = Console.ReadLine(); // reads name
            if (name1 == "Taiwan")
            {
                Console.WriteLine("That is not a Valid Name");
                Console.WriteLine("Press any Button to Exit");
                Console.ReadKey();
                RunMainMenu();
            }
            Random rnd = new Random();
            int num = rnd.Next(0, 1400); // makes a random number
            Console.WriteLine(name1 + " have " + num + " social credit\npress any button to close");
            Console.ReadKey();
            RunMainMenu();
        }
        //The code for a Random number generator 100-0
        private void RunLoveTester()
        {

            string name1;
            string name2;
            Console.WriteLine("type 2 names");
            Console.Write("First Name: ");
            name1 = Console.ReadLine(); // reads first name
            Console.Write("Second Name: ");
            name2 = Console.ReadLine(); // reads second name
            Random rnd = new Random();
            int num = rnd.Next(0, 100); // makes a random number
            Console.WriteLine(name1 + " and " + name2 + " have a " + num + "% chanse of love\npress any button to close");
            Console.ReadKey();
            RunMainMenu();
        }
        //The code for Sotial Credit Quiz
        private void RunQuiz()
        {
            int num1 = 1000;

            string prompt = "Is taiwan a Contry";
            string[] options = { "Yes", "No" };
            Menu colorMenu = new Menu(prompt, options);
            int selectedIndex = colorMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("Wrong -100");
                    ResetColor();
                    num1 = num1 - 100;
                    break;
                case 1:
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("True 30");
                    ResetColor();
                    num1 = num1 + 30;
                    break;
            }

            WriteLine("Press any button for the next Quiston");
            ReadKey();

            prompt = "Is China good";
            colorMenu = new Menu(prompt, options);
            selectedIndex = colorMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("True +30");
                    ResetColor();
                    num1 = num1 + 30;
                    break;
                case 1:
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("Wrong -100");
                    ResetColor();
                    num1 = num1 - 100;
                    break;
            }

            WriteLine("Press any button for the next Quiston");
            ReadKey();

            prompt = "Is Ryan a good person";
            colorMenu = new Menu(prompt, options);
            selectedIndex = colorMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("True +30");
                    ResetColor();
                    num1 = num1 + 30;
                    break;
                case 1:
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("Wrong -100");
                    ResetColor();
                    num1 = num1 - 100;
                    break;
            }

            if (num1 < 601)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                WriteLine("\n\nyou're Score is: " + num1);
                WriteLine("\nPress any Button to Exit");
                ReadKey();
            } else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                WriteLine("\n\nyou're Score is: " + num1);
                WriteLine("\nPress any Button to Exit");
                ReadKey();
            }
            RunMainMenu();
        }
        //The Calculator Page/Program
        private void RunCal()
        {
            string prompt = "Calculator";
            string[] options = { "+", "-", "*", "/" };
            Menu colorMenu = new Menu(prompt, options);
            int selectedIndex = colorMenu.Run();

            switch (selectedIndex)
            {
                case 0:
                    //The + code for Calculator
                    int num1;
                    int num2;

                    Console.WriteLine("Type first number");
                    Console.Write("Number: ");
                    num1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Type second number");
                    Console.Write("Number: ");
                    num2 = Convert.ToInt32(Console.ReadLine());

                    ForegroundColor = ConsoleColor.Green;
                    Console.Write("result: ");
                    Console.Write(num1 + num2);
                    break;
                case 1:
                    //The - code for Calculator
                    Console.WriteLine("Type first number");
                    Console.Write("Number: ");
                    num1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Type second number");
                    Console.Write("Number: ");
                    num2 = Convert.ToInt32(Console.ReadLine());

                    ForegroundColor = ConsoleColor.Green;
                    Console.Write("result: ");
                    Console.Write(num1 - num2);
                    break;
                case 2:
                    //The * code for Calculator
                    Console.WriteLine("Type first number");
                    Console.Write("Number: ");
                    num1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Type second number");
                    Console.Write("Number: ");
                    num2 = Convert.ToInt32(Console.ReadLine());

                    ForegroundColor = ConsoleColor.Green;
                    Console.Write("result: ");
                    Console.Write(num1 * num2);
                    break;
                case 3:
                    //The / code for Calculator
                    Console.WriteLine("Type first number");
                    Console.Write("Number: ");
                    num1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Type second number");
                    Console.Write("Number: ");
                    num2 = Convert.ToInt32(Console.ReadLine());

                    ForegroundColor = ConsoleColor.Green;
                    Console.Write("result: ");
                    Console.Write(num1 / num2);
                    break;
            }
            ResetColor();

            WriteLine("\n\npress any Button to Exit");
            Console.ReadKey();
            RunMainMenu(); 
        }
        //The Timer page/program
        private void RunTimer()
        {
            WriteLine("Type a time in minuts");
            Write("Time: ");
            int time1 = Convert.ToInt32(ReadLine());
            int time1a = time1 * 60;
            int time2 = 0;
            while (time1a > time2)
            {
                time2++;
                Thread.Sleep(1000);
            }
            WriteLine("You're Time is Up...");
            int timer = 0;
            while (timer < 5)
            {
                timer++;
                Beep();
                Beep();
                Beep();
                Thread.Sleep(1000);
            }
        RunMainMenu();
        }
        //The About page
        private void RunAbout()
        {
            Console.Clear();
            ForegroundColor = ConsoleColor.Blue;
            WriteLine(
                @"
 ▄▄▄▄▄▄▄▄▄▄▄  ▄▄▄▄▄▄▄▄▄▄   ▄▄▄▄▄▄▄▄▄▄▄  ▄         ▄  ▄▄▄▄▄▄▄▄▄▄▄ 
▐░░░░░░░░░░░▌▐░░░░░░░░░░▌ ▐░░░░░░░░░░░▌▐░▌       ▐░▌▐░░░░░░░░░░░▌
▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀█░▌▐░▌       ▐░▌ ▀▀▀▀█░█▀▀▀▀ 
▐░▌       ▐░▌▐░▌       ▐░▌▐░▌       ▐░▌▐░▌       ▐░▌     ▐░▌     
▐░█▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄▄▄█░▌▐░▌       ▐░▌▐░▌       ▐░▌     ▐░▌     
▐░░░░░░░░░░░▌▐░░░░░░░░░░▌ ▐░▌       ▐░▌▐░▌       ▐░▌     ▐░▌     
▐░█▀▀▀▀▀▀▀█░▌▐░█▀▀▀▀▀▀▀█░▌▐░▌       ▐░▌▐░▌       ▐░▌     ▐░▌     
▐░▌       ▐░▌▐░▌       ▐░▌▐░▌       ▐░▌▐░▌       ▐░▌     ▐░▌     
▐░▌       ▐░▌▐░█▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄▄▄█░▌     ▐░▌     
▐░▌       ▐░▌▐░░░░░░░░░░▌ ▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌     ▐░▌     
 ▀         ▀  ▀▀▀▀▀▀▀▀▀▀   ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀▀       ▀      
                                                                 
                ");
            Console.WriteLine("Head Developer: Simon Stampe Jakobsen\nHead Design Developer: Simon Stampe Jakobsen\n  -  Second Design Developer: http://patorjk.com/software/taag/\nHead Bug Finder/Fixer: Simon Stampe Jakobsen\n");
            ResetColor();
            WriteLine("\n\nPress any Button to Exit");
            ReadKey();
            RunMainMenu();
        }
        // The Code for the Dance
        private void RunDance()
        {
            int num1 = 1;
            int num2;
            string dance1 = 
            @"
 \o/
  | 
 / \
            ";
            string dance2 = 
            @"
  o 
 /|\
 / \
            ";
            string dance3 = 
            @"
  o/
 /|
 / \
            ";
            string dance4 = 
            @"
 \o
  |\
 / \
            ";
            string dance5 = 
            @"
 \o
  |>
 / \
            ";
            WriteLine("Type the number of dances");
            num2 = Convert.ToInt32(ReadLine());
            while(num1 < num2)
            {
            num1++;
            Console.Clear();
            WriteLine(dance3);
            Beep(528, 100);
            Thread.Sleep(400);
            Console.Clear();
            WriteLine(dance1);
            Beep(741, 100);
            Thread.Sleep(400);
            Console.Clear();
            WriteLine(dance5);
            Beep(528, 100);
            Thread.Sleep(400);
            Console.Clear();
            WriteLine(dance4);
            Beep(741, 100);
            Thread.Sleep(400);
            Console.Clear();
            WriteLine(dance2);
            Beep(528, 100);
            Thread.Sleep(400);
            }
        RunMainMenu();
        }
        // the Code for Friday Night Funkin
        private void RunFNF()
        {
            int i = 0;
            while (i < 100)
            {
            ConsoleKey keyPressed;
            ConsoleKeyInfo keyInfo = ReadKey(true);
            keyPressed = keyInfo.Key;
                i++;
                if (keyPressed == ConsoleKey.UpArrow)
                {
                    Console.Clear();
                    WriteLine("up");
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine(
                        @"
░░░░░░░░░░░█▀▀░░█░░░░░░
░░░░░░▄▀▀▀▀░░░░░█▄▄░░░░
░░░░░░█░█░░░░░░░░░░▐░░░
░░░░░░▐▐░░░░░░░░░▄░▐░░░
░░░░░░█░░░░░░░░▄▀▀░▐░░░
░░░░▄▀░░░░░░░░▐░▄▄▀░░░░
░░▄▀░░░▐░░░░░█▄▀░▐░░░░░
░░█░░░▐░░░░░░░░▄░█░░░░░
░░░█▄░░▀▄░░░░▄▀▐░█░░░░░
░░░█▐▀▀▀░▀▀▀▀░░▐░█░░░░░
░░▐█▐▄░░▀░░░░░░▐░█▄▄░░░
░░░▀▀▄░░░░░░░░▄▐▄▄▄▀░░░
░░░░░░░░░░░░░░░░░░░░░░░
                        ");
                ResetColor();
                }
                else if (keyPressed == ConsoleKey.DownArrow)
                {
                    Console.Clear();
                    WriteLine("down");
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine(
                    @"
░░░░▄▄▄▄▀▀▀▀▀▀▀▀▄▄▄▄▄▄
░░░░█░░░░▒▒▒▒▒▒▒▒▒▒▒▒░░▀▀▄
░░░█░░░▒▒▒▒▒▒░░░░░░░░▒▒▒░░█
░░█░░░░░░▄██▀▄▄░░░░░▄▄▄░░░█
░▀▒▄▄▄▒░█▀▀▀▀▄▄█░░░██▄▄█░░░█
█▒█▒▄░▀▄▄▄▀░░░░░░░░█░░░▒▒▒▒▒█
█▒█░█▀▄▄░░░░░█▀░░░░▀▄░░▄▀▀▀▄▒█
░█▀▄░█▄░█▀▄▄░▀░▀▀░▄▄▀░░░░█░░█
░░█░░▀▄▀█▄▄░█▀▀▀▄▄▄▄▀▀█▀██░█
░░░█░░██░░▀█▄▄▄█▄▄█▄████░█
░░░░█░░░▀▀▄░█░░░█░███████░█
░░░░░▀▄░░░▀▀▄▄▄█▄█▄█▄█▄▀░░█
░░░░░░░▀▄▄░▒▒▒▒░░░░░░░░░░█
░░░░░░░░░░▀▀▄▄░▒▒▒▒▒▒▒▒▒▒░█
░░░░░░░░░░░░░░▀▄▄▄▄▄░░░░░█
                    ");
                    ResetColor();
                } 
                else if (keyPressed == ConsoleKey.LeftArrow)
                {
                    Console.Clear();
                    WriteLine("left");
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine(
                        @"
─────────▄▄───────────────────▄▄──
──────────▀█───────────────────▀█─
──────────▄█───────────────────▄█─
──█████████▀───────────█████████▀─
───▄██████▄─────────────▄██████▄──
─▄██▀────▀██▄─────────▄██▀────▀██▄
─██────────██─────────██────────██
─██───██───██─────────██───██───██
─██────────██─────────██────────██
──██▄────▄██───────────██▄────▄██─
───▀██████▀─────────────▀██████▀──
──────────────────────────────────
──────────────────────────────────
──────────────────────────────────
───────────█████████████──────────
──────────────────────────────────
──────────────────────────────────
                        ");
                ResetColor();
                }
                else if (keyPressed == ConsoleKey.RightArrow)
                {
                    Console.Clear();
                    WriteLine("Right");
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine(
                        @"
░░▄▀░░░░░░░░░░░░░░░▀▀▄▄░░░░░ 
░░▄▀░░░░░░░░░░░░░░░░░░░░▀▄░░░ 
░▄▀░░░░░░░░░░░░░░░░░░░░░░░█░░ 
░█░░░░░░░░░░░░░░░░░░░░░░░░░█░ 
▐░░░░░░░░░░░░░░░░░░░░░░░░░░░█ 
█░░░░▀▀▄▄▄▄░░░▄▌░░░░░░░░░░░░▐ 
▌░░░░░▌░░▀▀█▀▀░░░▄▄░░░░░░░▌░▐ 
▌░░░░░░▀▀▀▀░░░░░░▌░▀██▄▄▄▀░░▐ 
▌░░░░░░░░░░░░░░░░░▀▄▄▄▄▀░░░▄▌ 
▐░░░░▐░░░░░░░░░░░░░░░░░░░░▄▀░ 
░█░░░▌░░▌▀▀▀▄▄▄▄░░░░░░░░░▄▀░░ 
░░█░░▀░░░░░░░░░░▀▌░░▌░░░█░░░░ 
░░░▀▄░░░░░░░░░░░░░▄▀░░▄▀░░░░░ 
░░░░░▀▄▄▄░░░░░░░░░▄▄▀▀░░░░░░░ 
░░░░░░░░▐▌▀▀▀▀▀▀▀▀░░░░░░░░░░░ 
░░░░░░░░█░░░░░░░░░░░░░░░░░░░░ 
░░╔═╗╔═╗╔═╗░░░░░║░║╔═╗║░║░░░░ 
░░╠═╣╠╦╝╠╣░░░░░░╚╦╝║░║║░║░░░░ 
░░║░║║╚═╚═╝░░░░░░║░╚═╝╚═╝░░░░ 
║╔═░╦░╦═╗╦═╗╦╔╗║╔═╗░░╔╦╗╔═╗╔╗ 
╠╩╗░║░║░║║░║║║║║║═╗░░║║║╠╣░╔╝ 
║░╚░╩░╩═╝╩═╝╩║╚╝╚═╝░░║║║╚═╝▄░
                        ");
                ResetColor();
                }
            }
            WriteLine("press any button to close");
            ReadKey(); 
            RunMainMenu();
        }
    }
}