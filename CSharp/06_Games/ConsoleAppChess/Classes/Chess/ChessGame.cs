using ConsoleAppChess.Interfaces;
using ConsoleAppChess.Util;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppChess.Classes.Chess
{
    internal class ChessGame : IGame
    {
        Board board;
        private readonly ILogger _logger;

        public ChessGame()
        {
            board = new Board();
        }

        public ChessGame(Player whitePieces, Player blackPieces)
        {
            board = new Board(whitePieces, blackPieces);
        }

        public void ResetGame()
        {
            Logger.GetLogger().Debug("[!] Reseting the board state");
            board.ResetBoard();
        }

        public void StartGame()
        {
            Console.WriteLine("\nStarting the game");
            board.Print();
            ResetGame();
            board.Print();
        }

        public string GetGameName()
        {
            return "Chess";
        }
    }
}
