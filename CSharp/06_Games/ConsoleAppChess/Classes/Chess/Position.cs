using ConsoleAppChess.Enum.Chess;
using ConsoleAppChess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppChess.Classes.Chess
{
    public class Position : IPosition
    {
        public int intPostion { get; set; }
        public char charPosition { get; set; }

        public string PositionStr { get; set; }

        public Position()
        {
            intPostion = 0;
            charPosition = 'a';
            setPositionStr();
        }
        public Position(int intPos, char charPos)
        {
            intPostion = intPos;
            charPosition = charPos;
            setPositionStr();
        }
        public static Position ReadPosition()
        {
            Console.ForegroundColor = ConsoleColor.Green; // Set text color to green
            Console.WriteLine("Select a Move position (char)");
            string charPos = Console.ReadLine();
            
            Console.WriteLine("Select a Move position (int)");
            string intPos = Console.ReadLine();
            Console.ResetColor(); // Reset text color

            charPos = charPos.ToUpper() == charPos ? charPos.ToLower() : charPos;
            return new Position(Convert.ToInt32(intPos), Char.Parse(charPos));
        }

        private void setPositionStr()
        {
            PositionStr = charPosition.ToString() + intPostion.ToString();
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
            intPostion = intPos;
            charPosition = charPos;
            setPositionStr();
        }

        public string displayPos()
        {
            string outputStr = "";
            outputStr += string.Format("\nIntPos: {0}", intPostion);
            outputStr += string.Format("\nCharPos: {0}", charPosition);
            outputStr += string.Format("\nCharPos in int: {0}", charToInt(charPosition));
            outputStr += string.Format("\nPos: {0}", PositionStr);

            return outputStr;
        }
    
        public static Position PositionAhead(Position position, Color color, int step = 1)
        {
            Position tempPos = new Position();
            tempPos = position;

            if (color == Color.White)
            {
                tempPos.intPostion += step;
            } else
            {
                tempPos.intPostion -= step;
            }
            return tempPos;
        }

        public static Position PositionDiag(Position position, Color color, bool rightDiag = false, bool backDiag = false, int step = 1)
        {
            int mul = Color.White == color ? 1 : -1;

            if (rightDiag)
            {
                position.charPosition = position.intToChar(position.charToInt(position.charPosition) + (mul * step)); 
            }
            else
            {
                position.charPosition = position.intToChar(position.charToInt(position.charPosition) + (mul * step * -1));
            }
            position.intPostion += mul * step;
            return position;
        }

        public static bool isEqual(Position pos1, Position pos2)
        {
            return (pos1.charPosition == pos2.charPosition && pos1.intPostion == pos2.intPostion);
        }

        public bool isEqual(Position pos)
        {
            return (this.charPosition == pos.charPosition && this.intPostion == pos.intPostion);
        }
    }
}
