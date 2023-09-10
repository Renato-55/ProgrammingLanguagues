using ConsoleAppChess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppChess.Classes
{
    internal class Game : IGame
    {
        Board board;
        public Game() 
        {
            this.board = new Board();
        }

        public Game(Player whitePieces, Player blackPieces)
        {
            this.board = new Board(whitePieces, blackPieces);
        }

        public void resetGame()
        {
            Console.WriteLine("\nReseting the game");
        }

        public void startGame()
        {
            Console.WriteLine("\nStarting the game");
        }
    }
}
