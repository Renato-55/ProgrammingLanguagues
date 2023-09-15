﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppChess.Classes.Chess
{
    internal class Pawn : Piece
    {
        public Pawn() { }
        public Pawn(string PieceName, string PieceShortName, int PieceValue, Enum.Chess.Color Color, int intPos, char charPos) : this(PieceName, PieceShortName, PieceValue, Color, new Position(intPos, charPos)) { }
        public Pawn(string PieceName, string PieceShortName, int PieceValue, Enum.Chess.Color Color, Position PiecePosition) : base(PieceName, PieceShortName, PieceValue, Color, PiecePosition) { }
        public override void Capture()
        {
            Console.WriteLine("\nPawn capture");
        }

        public override void PossibleMoves()
        {
            Console.WriteLine("\nPossible Moves");
        }

        public override bool isMovePossible(Position position)
        {
            return true;
        }
    }
}
