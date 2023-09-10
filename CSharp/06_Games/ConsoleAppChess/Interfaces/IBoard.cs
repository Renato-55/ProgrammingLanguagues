using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppChess.Interfaces
{
    internal interface IBoard
    {
        void resetBoard();
        void print();
        void makeMove();
    }
}
