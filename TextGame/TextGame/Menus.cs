using System;
using System.Collections.Generic;
using System.Text;

namespace TextGame
{
    static class Menus
    {
        public static void StartMainMenu()
        {
            string message = "Hello" + Game.newPlayer.Name + "You need to work out and get food to make dinner, " +
                "where do you want to go first?";
            List<string> options = new List<string> 
                { "Supermarket", "Home", "Gym" };
            Selector Main = new Selector(message, options);
            int selected = Main.Run();
            if (selected == 0)
            {
                GoToSupermarket();
                Game.newPlayer.Gas--;
            }
            else if (selected == 1)
            {
                GoToHome();
                Game.newPlayer.Gas--;
            }
            else if (selected == 2)
            {
                GoToGym();
                Game.newPlayer.Gas--;
            }
            Console.ReadKey();
        }
        public static void GoToSupermarket()
        {
            string message = "The supermarket has shelves stocked full of food should you want to buy some.";
            List<string> options = new List<string>();
            if(Game.newPlayer.Food == false)
            {
                options.AddRange(new List<string>{ "Go home", "Head to the gym", "buy chicken and rice" });

            }
            else
            {
                options.AddRange(new List<string>{ "Go home", "Head to the gym" });

            }
            Selector Super = new Selector(message, options);
            int selected = Super.Run();
            if (selected == 0)
            {
                Game.newPlayer.Gas--;
                if (Game.newPlayer.Gas == 0)
                {
                    Console.WriteLine("Your car runs out of gas and strands you in the middle of nowhere.");
                    System.Environment.Exit(1);
                }
                GoToHome();
            }
            else if (selected == 1)
            {
                Game.newPlayer.Gas--;
                if (Game.newPlayer.Gas == 0)
                {
                    Console.WriteLine("Your car runs out of gas and strands you in the middle of nowhere.");
                    System.Environment.Exit(1);
                }
                GoToGym();
            }
            else if (selected == 2)
            {
                Game.newPlayer.Food = true;
                Console.WriteLine("You grab some chicken and rice from the shelves for later");
                GoToSupermarket();
            }
        }
        public static void GoToHome()
        {
            string message = "The gym is full of machines and workout equiptment ready to be used.";
            List<string> options = new List<string>();
            if (Game.newPlayer.Tired == true && Game.newPlayer.Food == true)
            {
                options.AddRange(new List<string> { "Go to the supermarket", "Head to the gym", "Eat and sleep" });

            }
            else
            {
                options.AddRange(new List<string> { "Go to the supermarket", "Head to the gym" });

            }
            Selector Super = new Selector(message, options);
            int selected = Super.Run();
            if (selected == 0)
            {
                Game.newPlayer.Gas--;
                if (Game.newPlayer.Gas == 0)
                {
                    Console.WriteLine("Your car runs out of gas and strands you in the middle of nowhere.");
                    System.Environment.Exit(1);
                }
                GoToHome();
            }
            else if (selected == 1)
            {
                Game.newPlayer.Gas--;
                if (Game.newPlayer.Gas == 0)
                {
                    Console.WriteLine("Your car runs out of gas and strands you in the middle of nowhere.");
                    System.Environment.Exit(1);
                }
                GoToGym();
            }
            else if (selected == 2)
            {
                Console.WriteLine("You eat your food and go to bed after a long day.");
                System.Environment.Exit(0);
            }
        }
        public static void GoToGym()
        {
            string message = "The gym is full of machines and workout equiptment ready to be used.";
            List<string> options = new List<string>();
            if (Game.newPlayer.Tired == false)
            {
                options.AddRange(new List<string> { "Go home", "Head to the Supermarket", "Workout" });

            }
            else
            {
                options.AddRange(new List<string> { "Go home", "Head to the gym" });

            }
            Selector Super = new Selector(message, options);
            int selected = Super.Run();
            if (selected == 0)
            {
                Game.newPlayer.Gas--;
                if (Game.newPlayer.Gas == 0)
                {
                    Console.WriteLine("Your car runs out of gas and strands you in the middle of nowhere.");
                    System.Environment.Exit(1);
                }
                GoToSupermarket();
            }
            else if (selected == 1)
            {
                Game.newPlayer.Gas--;
                if (Game.newPlayer.Gas == 0)
                {
                    Console.WriteLine("Your car runs out of gas and strands you in the middle of nowhere.");
                    System.Environment.Exit(1);
                }
                GoToGym();
            }
            else if (selected == 2)
            {
                Game.newPlayer.Tired = true;
                Console.WriteLine("You workout and finish feeling sufficiently tired.");
                GoToGym();
            }
        }
    }
}
