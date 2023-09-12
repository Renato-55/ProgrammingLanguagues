using ConsoleAppChess.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppChess.Classes.Chess
{
    public abstract class Piece
    {
        public string PieceName { get; set; }
        public string PieceShortName { get; set; }
        public int PieceValue { get; set; }
        public Color color { get; set; }
        public Position PiecePosition { get; set; }
        public Piece() { }
        public Piece(string PieceName, string PieceShortName, int PieceValue, Color Color, int intPos, char charPos) : this(PieceName, PieceShortName, PieceValue, Color, new Position(intPos, charPos)) { }
        public Piece(string PieceName, string PieceShortName, int PieceValue, Color Color, Position PiecePosition)
        {
            this.PieceName = PieceName;
            this.PieceShortName = PieceShortName;
            this.PieceValue = PieceValue;
            this.PiecePosition = PiecePosition;
        }

        public abstract void Capture();

        public abstract void Move();

        public abstract void PossibleMoves();

        public int getPieceValue()
        {
            return PieceValue;
        }

        public string getPieceName()
        {
            return PieceName;
        }
    }
}
