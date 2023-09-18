namespace ConsoleAppChess.Classes.NavalBattle {
    public class NavalBattlePosition 
    {
        private int PositionInt;
        private char PositionChar;
        private char orientation;

        public NavalBattlePosition()
        {
            PositionInt=0;
            PositionChar='A';
            orientation='H';
        }

        public NavalBattlePosition(int positionInt, char positionChar, char orientation)
        {
            PositionInt=positionInt;
            PositionChar=positionChar;
            this.orientation=orientation;
        }

        public string GetPosition()
        {
            return PositionChar.ToString()+PositionInt.ToString()+orientation.ToString();
        }

    }
}