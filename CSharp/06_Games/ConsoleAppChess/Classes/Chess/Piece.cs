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
        public Enum.Chess.Color color { get; set; }
        public Position PiecePosition { get; set; }
        public Piece() { }
        public Piece(string PieceName, string PieceShortName, int PieceValue, Enum.Chess.Color Color, int intPos, char charPos) : this(PieceName, PieceShortName, PieceValue, Color, new Position(intPos, charPos)) { }
        public Piece(string PieceName, string PieceShortName, int PieceValue, Enum.Chess.Color Color, Position PiecePosition)
        {
            this.PieceName = PieceName;
            this.PieceShortName = PieceShortName;
            this.PieceValue = PieceValue;
            this.PiecePosition = PiecePosition;
            this.color = Color;
        }

        public abstract void Capture();

        public bool Move(Position position, ChessBoard board)
        {
            if (isMovePossible(position, board)) 
            { 
                MovePiece(position);
                /* Check win conditions */
                return true;
            }

            return false;
        }

        public void MovePiece(Position position)
        {
            // must handle/update piece information 
            // update whit pieces see´s who´s
            // Move piece to position
            this.PiecePosition = position;
        }
        public abstract bool isMovePossible(Position position, ChessBoard board);

        public abstract List<Position> PossibleMoves(ChessBoard board);

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
