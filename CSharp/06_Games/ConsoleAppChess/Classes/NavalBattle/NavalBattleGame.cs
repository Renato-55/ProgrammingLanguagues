using ConsoleAppChess.Interfaces;

namespace ConsoleAppChess.Classes.NavalBattle
{
    public class NavalBattleGame : IGame
    {
        public NavalBattleGame()
        {
        }
        
        public void StartGame()
        {
            Console.WriteLine("Naval Battle Game started!");
        }

        public void ResetGame()
        {
            Console.WriteLine("Naval Battle Game reseted!");
        }

        public string GetGameName()
        {
            return "Naval Battle";
        }
    }
}