using ConsoleAppChess.Interfaces;
using ConsoleAppChess.Util;
using Microsoft.Extensions.Logging;
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
        private readonly ILogger _logger;

        public Game() 
        {
            this.board = new Board();
        }

        public Game(Player whitePieces, Player blackPieces)
        {
            this.board = new Board(whitePieces, blackPieces);
        }

        public void ResetGame()
        {
            Logger.GetLogger().Debug("[!] Reseting the board state");
            this.board.ResetBoard();
        }

        public void StartGame()
        {
            Console.WriteLine("\nStarting the game");
            this.board.Print();
            this.ResetGame();
            this.board.Print();
        }
    }
}
