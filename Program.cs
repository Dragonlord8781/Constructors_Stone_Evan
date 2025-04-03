using Constructors_Stone_Evan;
using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Writes the program #
            Console.WriteLine("Program 11");
            // Write a line greeting the user
            Console.WriteLine("Hello User");

            // creating myGame from the Game class and giving it the values "Monster Hunter Wilds" for title and "T for Teen" for genre
            Game myGame = new Game("Monster Hunter Wilds", "T for Teen");
            //Writes a line saying my favorite game and its rating using the values given to myGame
            Console.WriteLine($"My favorite game is {myGame.title}, which is rated {myGame.genre}.");

            //writes a line saying that the next part is another code demonstation
            Console.WriteLine("And as another code demonstration,");
            // creates myOtherGame from the Game class but doesn't give it values
            Game myOtherGame = new Game();
            // Writes a line saying my other favorite game and its genre but using the Game class default values
            Console.WriteLine($"My other favorite game is {myOtherGame.title} and it is a {myOtherGame.genre} game.");

            //writes a line asking for users favorite game
            Console.WriteLine("What about your favorite game?");
            // creates the string yourGame and assigns it the inputted string
            string yourGame = Console.ReadLine();
            //writes a line asking for user's inputted game's rating
            Console.WriteLine("And what is its rating?");
            //creates the string yourRate and assigns it the inputted string
            string yourRate = Console.ReadLine();
            //creates yourFavGame from the Game class and assigns yourGame to title and yourRate to genre
            Game yourFavGame = new Game(yourGame, yourRate);
            //writes a line saying the users favorite game and its rating using their inputted data
            Console.WriteLine($"Your favorite game is {yourFavGame.title} and it is rated {yourFavGame.genre}.");
        }
    }
}