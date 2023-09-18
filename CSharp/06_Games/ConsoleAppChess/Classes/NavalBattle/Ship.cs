using ConsoleAppChess.Classes.Chess;

namespace ConsoleAppChess.Classes.NavalBattle
{
    public abstract class Ship
    {
        private string Name;
        private int Size;
        private NavalBattlePosition position;
        private bool isSunk;
        private int hits;
        

        public Ship()
        {
            Name="Ship";
            Size=0;
            position = new NavalBattlePosition();
            isSunk=false;
            hits=0;
        }

        public Ship(string name, int size, NavalBattlePosition position)
        {
            Name=name;
            Size=size;
            this.position = position;
            isSunk=false;
            hits=0;
        }

        public void Hit()
        {
            hits++;
            if(hits==Size)
            {
                isSunk=true;
            }
        }

        public bool IsSunk()
        {
            return isSunk;
        }

    }
}