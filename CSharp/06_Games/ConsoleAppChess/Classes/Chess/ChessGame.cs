﻿using ConsoleAppChess.Interfaces;
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
        ChessBoard board;
        private readonly ILogger _logger;

        public ChessGame()
        {
            board = new ChessBoard();
        }

        public ChessGame(Player whitePieces, Player blackPieces)
        {
            board = new ChessBoard(whitePieces, blackPieces);
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

            while (1 == 1)
            {
                board.MakeMove();
                board.Print();
            }

        }

        public string GetGameName()
        {
            return "Chess";
        }
    }
}
