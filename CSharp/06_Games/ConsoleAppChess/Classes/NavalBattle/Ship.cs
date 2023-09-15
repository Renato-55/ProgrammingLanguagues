namespace ConsoleAppChess.Classes.NavalBattle
{
    public abstract class Ship
    {
        private string Name { get; set; }
        private int Size { get; set; }
        private string Position { get; set; }
        private string Orientation { get; set; }
        private int Hits { get; set; }
        private bool IsSunk { get; set; }

        public Ship(int size, string position, string orientation)
        {
            this.Size = size;
            this.Position = position;
            this.Orientation = orientation;
            this.Hits = 0;
            this.IsSunk = false;
        }

        public abstract void Position();

        public abstract void Hit();


    }
}
```