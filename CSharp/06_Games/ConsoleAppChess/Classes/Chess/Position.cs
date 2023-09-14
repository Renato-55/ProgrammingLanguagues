using ConsoleAppChess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
