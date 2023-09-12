using ConsoleAppChess.Classes.Chess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppChess.Interfaces
{
    internal interface IPosition
    {
        Position getPos();
        void setPos(int intPos, char charPos);
        int charToInt(char c);
        char intToChar(int i);
        string displayPos();
    }
}
