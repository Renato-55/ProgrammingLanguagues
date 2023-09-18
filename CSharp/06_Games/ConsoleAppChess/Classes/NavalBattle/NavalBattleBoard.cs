using ConsoleAppChess.Interfaces;
using Microsoft.Extensions.Logging;

namespace ConsoleAppChess.Classes.NavalBattle
{
    public class NavalBattleBoard: IBoard
    {
        private const int BoardSize = 10;

        private NavalBattlePosition[,] BoardPositions { get; set; }

        public NavalBattleBoard()
        {
            ResetBoard();
            Load();
        }


        public void ResetBoard()
        {
            BoardPositions = new NavalBattlePosition[BoardSize, BoardSize];
        }

        public void Print()
        {
            Console.WriteLine("Naval Battle Board");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("       A      B      C      D      E      F      G      H      I      J\n");
            for(int i=9; i>=0; i--)
            {
                Console.Write(string.Format((i + 1).ToString()).PadRight(6));
                for(int j=0; j<10;j++)
                {
                    string output = "";
                    if(BoardPositions[i,j]!=null)
                    {
                        output = "   x   ";
                    }
                    else output= "   -   ";

                    Console.Write(output);
                }
                Console.WriteLine("\n");       
            }
            Console.WriteLine("       A      B      C      D      E      F      G      H      I      J\n");
            Console.WriteLine("----------------------------------------------------------");
        }

        public bool MakeMove()
        {
            return true;
        }

        public void Load()
        {
            
        }


    }
}