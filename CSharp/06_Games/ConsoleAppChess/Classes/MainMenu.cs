using ConsoleAppChess.Classes.Chess;
using ConsoleAppChess.Enum;
using ConsoleAppChess.Interfaces;
using ConsoleAppChess.Util;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppChess.Classes
{
    internal class MainMenu
    {
        public ILogger logger;
        public MainMenu () 
        {
            this.logger = Logger.GetLogger();
        }

        public static void StartMenu()
        {
            MainMenu mainMenu = new MainMenu();

            GameName gameName = mainMenu.PrintMenu();

            IGame game = mainMenu.LoadGame(gameName);

            mainMenu.StartGame(game);

            /* Wait for an input */ 
            Console.ReadLine();
        }

        private GameName PrintMenu()
        {
            this.logger.Debug(string.Format("[!] Starting Program at {0}", System.DateTime.Now));

            Console.ForegroundColor = ConsoleColor.Green; // Set text color to green
            Console.WriteLine("╔══════════════════════════════╗");
            Console.WriteLine("║         Game Selection       ║");
            Console.WriteLine("╠══════════════════════════════╣");
            Console.WriteLine("║  1. Chess                    ║");
            Console.WriteLine("║  2. Battleship               ║");
            Console.WriteLine("║  3. Exit                     ║");
            Console.WriteLine("╚══════════════════════════════╝");
            Console.ResetColor(); // Reset text color

            int userInput = Convert.ToInt32(Console.ReadLine());

            return (GameName)userInput;
        }
    
    
        private IGame LoadGame(GameName gameName)
        {
            // Create factory for games later
            switch(gameName)
            {
                case GameName.Chess:
                    /* Initial Board */
                    Player whitePieces = new Player() { NickName = "Renato" };
                    Player blackPieces = new Player() { NickName = "Mariana" };
                    ChessGame game = new ChessGame(whitePieces, blackPieces);
                    return game;

                /***
                 * Define other games here
                 * 
                 */

                default:
                    return null;
            }
        }
    
        private void StartGame(IGame game)
        {
            logger.Debug("[!] Starting game {0}", game.GetGameName());
            game.StartGame();
        }

    }
}
