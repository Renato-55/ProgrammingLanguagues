﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppChess.Classes
{
    internal class King : Piece
    {
        public King() { }
        public King(string PieceName, string PieceShortName, int PieceValue, Color color, int intPos, char charPos) : this(PieceName, PieceShortName, PieceValue, color, new Position(intPos, charPos)) { }
        public King(string PieceName, string PieceShortName, int PieceValue, Color color, Position PiecePosition) : base(PieceName, PieceShortName, PieceValue, color, PiecePosition) { }
        public override void Capture()
        {
            Console.WriteLine("\nKing capture");
        }

        public override void Move()
        {
            Console.WriteLine("\nKing moving");
        }

        public override void PossibleMoves()
        {
            Console.WriteLine("\nPossible Moves");
        }
    }
}
