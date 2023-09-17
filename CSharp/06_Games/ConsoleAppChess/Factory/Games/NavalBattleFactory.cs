using ConsoleAppChess.Classes.NavalBattle;

namespace ConsoleAppChess.Factory.Games
{
    public class NavalBattleFactory
    {
        public static NavalBattleGame CreateGame()
        {
            return new NavalBattleGame();
        }
    }
}