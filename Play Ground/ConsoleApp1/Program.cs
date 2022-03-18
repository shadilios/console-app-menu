using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static int selectedIndex = 0;

        static string[] options = { "Start", "About", "Exit" };


        static void Main(string[] args)
        {
            DisplayUI();
            CheckInput();
        }

        static void DisplayUI()
        {
            string prefex;

            string prompt = "Welcome to main menu";


            Console.WriteLine(prompt);

            for (int i = 0; i < options.Length; i++)
            {
                if (i == selectedIndex)
                {
                    prefex = "~";
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    prefex = " ";
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                }

                Console.WriteLine($"{prefex}[ {options[i]} ]");
            }
            Console.ResetColor();
        }

        static int CheckInput()
        {
            ConsoleKey keyPressed;
            do
            {
                Console.Clear();
                DisplayUI();

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                keyPressed = keyInfo.Key;

                if (keyPressed == ConsoleKey.UpArrow)
                {
                    selectedIndex--;
                    if (selectedIndex == -1)
                    {
                        selectedIndex = options.Length -1;
                    }
                }
                if (keyPressed == ConsoleKey.DownArrow)
                {
                    selectedIndex++;
                    if (selectedIndex == options.Length)
                    {
                        selectedIndex = 0;
                    }
                }


            } while (keyPressed != ConsoleKey.Enter);
            return selectedIndex;
        }
    }
}
