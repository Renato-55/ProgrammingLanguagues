using ConsoleAppChess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppChess.Classes
{
    internal abstract class Piece : IPiece
    {
        public string PieceName { get; set; }
        public string PieceValue { get; set; }
        public Position PiecePosition { get; set; }
        public Piece() { }
        
        public virtual void capture()
        {
        }

        public virtual void move()
        {
        }

        public virtual void possibleMoves()
        {
        }
    }
}
