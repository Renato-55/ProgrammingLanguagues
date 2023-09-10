using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppChess.Interfaces
{
    internal interface IPiece
    {
        void move();
        void capture();
        void possibleMoves();
    }
}
