using Constructors_Stone_Evan;
using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Game myGame = new Game("Monster Hunter Wilds", "T");

            Console.WriteLine($"My favorite game is {myGame.title}, which is rated {myGame.genre}.");
        }
    }
}