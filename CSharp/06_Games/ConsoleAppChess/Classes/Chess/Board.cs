using ConsoleAppChess.Enum.Chess;
using ConsoleAppChess.Factory.Chess;
using ConsoleAppChess.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppChess.Enum.Chess;

namespace ConsoleAppChess.Classes.Chess
{
    internal class Board : IBoard
    {
        private const int boardSize = 8;
        public Player _whitePlayer;
        public Player _blackPlayer;
        public List<Piece> blackPieces;
        public List<Piece> whitePieces;
        public Piece[,] board;
        public bool isWhiteMove;
        private readonly ILogger _logger;

        public Board() : this(new Player(), new Player()) { }
        public Board(Player whitePlayer, Player blackPlayer)
        {
            _whitePlayer = whitePlayer;
            _blackPlayer = blackPlayer;
            ResetBoard();
            Load();
        }

        public bool MakeMove()
        {
            Piece piece = null;

            Console.WriteLine("Select a Piece to move");
            Console.ResetColor(); // Reset text color
            Console.ResetColor(); // Reset text color

            string pieceToMove = Console.ReadLine();

            Position newPosition = Position.ReadPosition();

            if (isWhiteMove)
            {
                piece = whitePieces.FirstOrDefault(piece => piece.PieceShortName == pieceToMove);
            }
            else
            {
                piece = blackPieces.FirstOrDefault(piece => piece.PieceShortName == pieceToMove);
            }

            try
            {
                this.MovePiece(piece, newPosition);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void MovePiece(Piece piece, Position newPosition)
        {
            board
            [
                piece.PiecePosition.intPostion - 1,
                piece.PiecePosition.charToInt(piece.PiecePosition.charPosition) - 1
            ] = null;

            piece.MovePiece(newPosition);

            board
                [
                    piece.PiecePosition.intPostion - 1,
                    piece.PiecePosition.charToInt(piece.PiecePosition.charPosition) - 1
                ] = piece;

            isWhiteMove = !isWhiteMove;
        }

        public void Print()
        {
            Util.Logger.GetLogger().Debug("[!] Printed the board state");
            Console.WriteLine("\nPrinting Current Board");

            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("       A      B      C      D      E      F      G      H\n");
            for (int i = 7; i >= 0; i--)
            {
                Console.Write(string.Format((i + 1).ToString()).PadRight(6));
                for (int j = 0; j < 8; j++)
                {
                    string output = "";
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
            blackPieces = new List<Piece>();
            whitePieces = new List<Piece>();
            board = new Piece[boardSize, boardSize];
            isWhiteMove = true;
        }
        public void Load()
        {
            Console.WriteLine("\nLoading Board");
            #region Loading Pawns
            for (int i = 0; i < 8; i++)
            {
                Piece wPawn = PieceFactory.CreatePiece(PieceType.Pawn, "WPawn-" + i, "WP-" + i, 1, Enum.Chess.Color.White, new Position(2, (char)('a' + i)));
                AddPieceToBoard(wPawn); 

                Piece bPawn = PieceFactory.CreatePiece(PieceType.Pawn, "Pawn-" + i, "BP-" + i, 1, Enum.Chess.Color.Black, new Position(7, (char)('a' + i)));
                AddPieceToBoard(bPawn);
            }
            #endregion

            #region Loading Special Pieces
            #region Rooks
            Piece WLrook = PieceFactory.CreatePiece(PieceType.Rook, "WLRook-", "WLR", 5, Color.White, new Position(1, 'a'));
            Piece WRrook = PieceFactory.CreatePiece(PieceType.Rook, "WRrook-", "WRR", 5, Color.White, new Position(1, 'h'));
            Piece BLrook = PieceFactory.CreatePiece(PieceType.Rook, "BLrook-", "BLR", 5, Color.Black, new Position(8, 'a'));
            Piece BRrook = PieceFactory.CreatePiece(PieceType.Rook, "BRrook-", "BRR", 5, Color.Black, new Position(8, 'h'));
            AddPieceToBoard(WLrook);
            AddPieceToBoard(WRrook);
            AddPieceToBoard(BLrook);
            AddPieceToBoard(BRrook);
            #endregion

            #region Bishop
            Piece WLbishop = PieceFactory.CreatePiece(PieceType.Bishop, "WLBishop", "WLB", 3, Color.White, new Position(1, 'c'));
            Piece WRbishop = PieceFactory.CreatePiece(PieceType.Bishop, "WRBishop", "WRB", 3, Color.White, new Position(1, 'f'));
            Piece BLbishop = PieceFactory.CreatePiece(PieceType.Bishop, "BLBishop", "BLB", 3, Color.Black, new Position(8, 'c'));
            Piece BRbishop = PieceFactory.CreatePiece(PieceType.Bishop, "BRBishop", "BRB", 3, Color.Black, new Position(8, 'f'));
            AddPieceToBoard(WLbishop);
            AddPieceToBoard(WRbishop);
            AddPieceToBoard(BLbishop);
            AddPieceToBoard(BRbishop);
            #endregion

            #region Knight
            Piece WLKnight = PieceFactory.CreatePiece(PieceType.Knight, "WLKnight", "WLK", 3, Color.White, new Position(1, 'b'));
            Piece WRKnight = PieceFactory.CreatePiece(PieceType.Knight, "WRKnight", "WRK", 3, Color.White, new Position(1, 'g'));
            Piece BLKnight = PieceFactory.CreatePiece(PieceType.Knight, "BLKnight", "BLK", 3, Color.Black, new Position(8, 'b'));
            Piece BRKnight = PieceFactory.CreatePiece(PieceType.Knight, "BRKnight", "BRK", 3, Color.Black, new Position(8, 'g'));
            AddPieceToBoard(WLKnight);
            AddPieceToBoard(WRKnight);
            AddPieceToBoard(BLKnight);
            AddPieceToBoard(BRKnight);
            #endregion

            #region Quuen and King
            Piece WKing = PieceFactory.CreatePiece(PieceType.Knight, "WKing", "WKing", 0, Color.White, new Position(1, 'e'));
            Piece BKing = PieceFactory.CreatePiece(PieceType.Knight, "BKing", "BKing", 0, Color.Black, new Position(8, 'e'));
            Piece WQueen = PieceFactory.CreatePiece(PieceType.Knight, "WQueen", "WQueen", 9, Color.White, new Position(1, 'd'));
            Piece BQueen = PieceFactory.CreatePiece(PieceType.Knight, "BQueen", "BQueen", 9, Color.Black, new Position(8, 'd'));
            AddPieceToBoard(WKing);
            AddPieceToBoard(BKing);
            AddPieceToBoard(WQueen);
            AddPieceToBoard(BQueen);
            #endregion
            #endregion
        }
        public void AddPieceToBoard(Piece piece)
        {
            if (piece.color == Enum.Chess.Color.White)
            {
                whitePieces.Add(piece);
            }
            else
            {
                blackPieces.Add(piece);
            }

            int charIndex = piece.PiecePosition.charToInt(piece.PiecePosition.charPosition);
            board
                    [
                        piece.PiecePosition.intPostion - 1,
                        piece.PiecePosition.charToInt(piece.PiecePosition.charPosition) - 1
                    ] = piece;

        }

    }
}
