using System;
using System.Collections.Generic;
using System.Text;

namespace TextGame
{
    class Game
    {
        public static Player newPlayer = new Player();
        public void Start()
        {
            Console.WriteLine(newPlayer.Name);
            Menus.StartMainMenu();
        }
    }
}
