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
            Board board = new Board(whitePieces, blackPieces);

            /* Priting The initial Board state */
            board.print();
            board.makeMove();
            board.print();
            board.resetBoard();

            /*  */
            Console.ReadLine();
        }
    }
}