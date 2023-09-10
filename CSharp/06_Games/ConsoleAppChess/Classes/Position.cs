using ConsoleAppChess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppChess.Classes
{
    internal class Position : IPosition
    {
        public int intPostion { get; set; }
        public char charPosition { get; set; }
        
        public string PositionStr { get; set; }

        public Position() 
        { 
            this.intPostion = 0;
            this.charPosition = 'a';
            this.setPositionStr();
        }
        public Position (int intPos, char charPos)
        {
            this.intPostion = intPos;
            this.charPosition = charPos;
            this.setPositionStr();
        }

        private void setPositionStr()
        {
            this.PositionStr = this.charPosition.ToString() + this.intPostion.ToString();
        }

        public int charToInt(char c)
        {
            return c - 'a' + 1;
        }

        public Position getPos()
        {
            return this;
        }

        public char intToChar(int i)
        {
            return (char)i;
        }

        public void setPos(int intPos, char charPos)
        {
            this.intPostion = intPos;
            this.charPosition = charPos;
            this.setPositionStr();
        }

        public string displayPos()
        {
            string outputStr = "";
            outputStr += string.Format("\nIntPos: {0}",this.intPostion);
            outputStr += string.Format("\nCharPos: {0}", this.charPosition);
            outputStr += string.Format("\nCharPos in int: {0}", this.charToInt(this.charPosition));
            outputStr += string.Format("\nPos: {0}", this.PositionStr);

            return outputStr;
        }
    }
}
