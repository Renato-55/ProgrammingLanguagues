using ConsoleAppChess.Classes.NavalBattle;

namespace ConsoleAppChess.Classes.NavalBattle
{
    public class NavalBattlePlayer 
    {
        private string Name;
        private int Score;
        private List<Ship> Ships;
        private NavalBattleBoard Board;

        public NavalBattlePlayer()
        {
            Name="Player";
            Score=0;
            Ships = new List<Ship>();
            Board = new NavalBattleBoard();
        }

        public NavalBattlePlayer(string name)
        {
            Name=name;
            Score=0;
            Ships = new List<Ship>();
            Board = new NavalBattleBoard();
        }


    }
}