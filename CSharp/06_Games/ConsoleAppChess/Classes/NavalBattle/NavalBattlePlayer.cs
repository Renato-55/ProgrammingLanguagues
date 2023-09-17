using ConsoleAppChess.Classes.NavalBattle;

namespace ConsoleAppChess.Classes.NavalBattle
{
    public class NavalBattlePlayer 
    {
        private string Name;
        private int Score;
        private List<Ship> Ships;

        public NavalBattlePlayer()
        {
            Name="Player";
            Score=0;
        }

        public NavalBattlePlayer(string name)
        {
            Name=name;
            Score=0;
        }


    }
}