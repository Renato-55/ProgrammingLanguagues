﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppChess.Classes.Chess
{
    internal class Bishop : Piece
    {
        public Bishop() { }
        public Bishop(string PieceName, string PieceShortName, int PieceValue, Enum.Chess.Color color, int intPos, char charPos) : this(PieceName, PieceShortName, PieceValue, color, new Position(intPos, charPos)) { }
        public Bishop(string PieceName, string PieceShortName, int PieceValue, Enum.Chess.Color color, Position PiecePosition) : base(PieceName, PieceShortName, PieceValue, color, PiecePosition) { }
        public override void Capture()
        {
            Console.WriteLine("\nBishop capture");
        }

        public override bool isMovePossible(Position position, ChessBoard board)
        {
            return true;
        }

        public override List<Position> PossibleMoves(ChessBoard board)
        {
            throw new NotImplementedException();
        }
    }
}
