using ConsoleAppChess.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppChess.Classes
{
    internal class Board : IBoard
    {
        private const int boardSize = 8;
        public Player _whitePlayer;
        public Player _blackPlayer;
        public List<Piece> blackPieces;
        public List<Piece> whitePieces;
        public Piece[,] board;

        private readonly ILogger _logger;

        public Board() : this(new Player(), new Player()) { }
        public Board(Player whitePlayer, Player blackPlayer)
        {
            this._whitePlayer = whitePlayer;
            this._blackPlayer = blackPlayer;
            this.ResetBoard();
            this.Load();
        }

        public void MakeMove()
        {
            Console.WriteLine("\nMaking a move");
        }

        public void Print()
        {
            ConsoleAppChess.Util.Logger.GetLogger().Debug("[!] Printed the board state");
            Console.WriteLine("\nPrinting Current Board");

            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("       A      B      C      D      E      F      G      H\n");
            for (int i = 7; i >= 0; i--)
            {
                Console.Write(string.Format((i+1).ToString()).PadRight(6));
                for (int j = 0; j < 8; j++)
                {
                    string output ="";
                    if (board[i, j] != null)
                    {
                        output = board[i, j].PieceShortName;
                    }
                    else
                    {
                        output = "   -   ";
                    }

                    // Ensure the string is always 6 characters wide
                    output = output.PadRight(7);
                    Console.Write(output);
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("       A      B      C      D      E      F      G      H\n");
            Console.WriteLine("----------------------------------------------------------");


        }
        public void ResetBoard()
        {
            this.blackPieces = new List<Piece>();
            this.whitePieces = new List<Piece>();
            this.board = new Piece[boardSize, boardSize];
        }
        public void Load()
        {
            Console.WriteLine("\nLoading Board");
            #region Loading Pawns
            for (int i = 0; i < 8; i++)
            {
                Pawn wPawn = new Pawn("WPawn-" + i, "WP-" + i, 1, Color.White, new Position(2, (char)('a' + i)));
                this.AddPieceToBoard(wPawn);

                Pawn bPawn = new Pawn("Pawn-" + i, "BP-" + i, 1, Color.Black, new Position(7, (char)('a' + i)));
                this.AddPieceToBoard(bPawn);
            }
            #endregion

            #region Loading Special Pieces
            #region Rooks
            Rook WLrook = new Rook("WLRook-", "WLR", 5, Color.White, new Position(1, 'a'));
            Rook WRrook = new Rook("WRrook-", "WRR", 5, Color.White, new Position(1, 'h'));
            Rook BLrook = new Rook("BLrook-", "BLR", 5, Color.Black, new Position(8, 'a'));
            Rook BRrook = new Rook("BRrook-", "BRR", 5, Color.Black, new Position(8, 'h'));
            this.AddPieceToBoard(WLrook);
            this.AddPieceToBoard(WRrook);
            this.AddPieceToBoard(BLrook);
            this.AddPieceToBoard(BRrook);
            #endregion

            #region Bishop
            Bishop WLbishop = new Bishop("WLBishop", "WLB", 3, Color.White, new Position(1, 'c'));
            Bishop WRbishop = new Bishop("WRBishop", "WRB", 3, Color.White, new Position(1, 'f'));
            Bishop BLbishop = new Bishop("BLBishop", "BLB", 3, Color.Black, new Position(8, 'c'));
            Bishop BRbishop = new Bishop("BRBishop", "BRB", 3, Color.Black, new Position(8, 'f'));
            this.AddPieceToBoard(WLbishop);
            this.AddPieceToBoard(WRbishop);
            this.AddPieceToBoard(BLbishop);
            this.AddPieceToBoard(BRbishop);
            #endregion

            #region Knight
            Knight WLKnight = new Knight("WLKnight", "WLK", 3, Color.White, new Position(1, 'b'));
            Knight WRKnight = new Knight("WRKnight", "WRK", 3, Color.White, new Position(1, 'g'));
            Knight BLKnight = new Knight("BLKnight", "BLK", 3, Color.Black, new Position(8, 'b'));
            Knight BRKnight = new Knight("BRKnight", "BRK", 3, Color.Black, new Position(8, 'g'));
            this.AddPieceToBoard(WLKnight);
            this.AddPieceToBoard(WRKnight);
            this.AddPieceToBoard(BLKnight);
            this.AddPieceToBoard(BRKnight);
            #endregion

            #region Quuen and King
            King WKing = new King("WKing", "WKing", 0, Color.White, new Position(1, 'e'));
            King BKing = new King("BKing", "BKing", 0, Color.Black, new Position(8, 'e'));
            Queen WQueen = new Queen("WQueen", "WQueen", 9, Color.White, new Position(1, 'd'));
            Queen BQueen = new Queen("BQueen", "BQueen", 9, Color.Black, new Position(8, 'd'));
            this.AddPieceToBoard(WKing);
            this.AddPieceToBoard(BKing);
            this.AddPieceToBoard(WQueen);
            this.AddPieceToBoard(BQueen);
            #endregion
            #endregion
        }
        public void AddPieceToBoard(Piece piece)
        {
            if (piece.color == Color.White) 
            {
               this.whitePieces.Add(piece);
            } 
            else 
            {
                this.blackPieces.Add(piece);
            }

            int charIndex = piece.PiecePosition.charToInt(piece.PiecePosition.charPosition);
            this.board
                    [
                        piece.PiecePosition.intPostion - 1,
                        piece.PiecePosition.charToInt(piece.PiecePosition.charPosition) - 1
                    ] = piece;

        }
    
    }
}
