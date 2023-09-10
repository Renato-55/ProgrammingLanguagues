using ConsoleAppChess.Classes;
using ConsoleAppChess.Util;
using System;

namespace ConsoleChess
{
    class Program
    {
        public static void Main(string[] args)
        {
            var _logger = Logger.GetLogger();
            _logger.Debug(string.Format("[!] Starting Program at {0}", System.DateTime.Now));

            /* Initial Board */ 
            Player whitePieces = new Player() { NickName = "Renato" };
            Player blackPieces = new Player() { NickName = "Mariana" };
            Game game = new Game(whitePieces, blackPieces);

            /* Priting The initial Board state */
            game.StartGame();

            /*  */
            Console.ReadLine();
        }
    }
}