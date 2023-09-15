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
    internal class GamesFactory
    {
        public static IGame CreateGame(GameName gameName)
        {
            switch (gameName)
            {
                case GameName.Chess:
                    /* Initial Board */

                    return ChessGameFactory.CreateGame();

                /***
                 * Define other games here
                 * 
                 */

                default:
                    return null;
            }
        }
    }
}
