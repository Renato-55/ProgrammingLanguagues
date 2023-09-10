using ConsoleAppChess.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppChess.Classes
{
    internal class Board : IBoard
    {
        Player _whitePieces;
        Player _blackPieces;
        private readonly ILogger _logger;
        public Board() 
        {
            this.resetBoard();
            this._whitePieces = new Player();
            this._blackPieces = new Player();
        }

        public Board(Player whitePieces, Player blackPieces)
        {
            this.resetBoard();
            this._whitePieces = whitePieces;
            this._blackPieces = blackPieces;
        }

        public void makeMove()
        {
            Console.WriteLine("\nMaking a move");
        }

        public void print()
        {
            ConsoleAppChess.Util.Logger.GetLogger().Debug("[!] Printed the board state");
            Console.WriteLine("\nPrinting Current Board");
        }

        public void resetBoard()
        {
            Console.WriteLine("\nReseting the Board");
        }
    }
}
