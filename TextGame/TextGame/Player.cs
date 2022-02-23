using System;
using System.Collections.Generic;
using System.Text;

namespace TextGame
{
    class Player
    {
        public string Name { get; set; }
        public bool Food { get; set; }
        public bool Tired { get; set; }
        public int Gas { get; set; }
        public Player()
        {
            Console.WriteLine("What is your name?");
            Name = Console.ReadLine();
            Food = false;
            Tired = false;
            Gas = 10;
        }
    }
}
