using ConsoleAppChess.Classes.Chess;
using ConsoleAppChess.Enum;
using ConsoleAppChess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppChess.Factory.Games
{
    internal class ChessGameFactory
    {
        public static ChessGame CreateGame()
        {
            Player whitePieces = new Player() { NickName = "Renato" };
            Player blackPieces = new Player() { NickName = "Mariana" };
            return new ChessGame(whitePieces, blackPieces);
        }
    }
}
