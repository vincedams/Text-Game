using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace TextGame
{
    class Selector
    {
        private int selected;
        private List<string> Options;
        private string Message;

        public Selector(string message, List<string> options)
        {
            Message = message;
            Options = options;
            selected = 0;
        }

        private void Display()
        {
            Console.WriteLine(Message);
            for (int i = 0; i < Options.Count; i++)
            {
                string currentOption = Options[i];

                if (i == selected)
                {
                    ForegroundColor = ConsoleColor.Black;
                    BackgroundColor = ConsoleColor.White;
                }
                else
                {
                    ForegroundColor = ConsoleColor.White;
                    BackgroundColor = ConsoleColor.Black;
                }
                Console.WriteLine($" == {currentOption} == ");
            }
        }
        public int Run()
        {
            ConsoleKey keyInput;
            do
            {
                Clear();
                Display();
                ConsoleKeyInfo keyInfo = ReadKey(true);
                keyInput = keyInfo.Key;

                if (keyInput == ConsoleKey.DownArrow)
                {
                    if (selected != Options.Count - 1)
                    {
                        selected++;
                    }
                }
                else if (keyInput == ConsoleKey.UpArrow)
                {
                    if (selected != 0)
                    {
                        selected--;
                    }
                }
            } while (keyInput != ConsoleKey.Enter);
            return selected;
        }
    }
}
