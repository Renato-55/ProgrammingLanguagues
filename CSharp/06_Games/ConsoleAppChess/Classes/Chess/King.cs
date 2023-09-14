using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppChess.Classes.Chess
{
    internal class King : Piece
    {
        public King() { }
        public King(string PieceName, string PieceShortName, int PieceValue, Enum.Chess.Color color, int intPos, char charPos) : this(PieceName, PieceShortName, PieceValue, color, new Position(intPos, charPos)) { }
        public King(string PieceName, string PieceShortName, int PieceValue, Enum.Chess.Color color, Position PiecePosition) : base(PieceName, PieceShortName, PieceValue, color, PiecePosition) { }
        public override void Capture()
        {
            Console.WriteLine("\nKing capture");
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
