using ConsoleAppChess.Enum.Chess;
using ConsoleAppChess.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppChess.Classes.Chess
{
    public class Pawn : Piece
    {
        public int NumberOfMoves { get; set; }
        public Pawn(string PieceName, string PieceShortName, int PieceValue, Enum.Chess.Color Color, int intPos, char charPos) : this(PieceName, PieceShortName, PieceValue, Color, new Position(intPos, charPos)) 
        { 
            this.NumberOfMoves = 0; 
        }
        public Pawn(string PieceName, string PieceShortName, int PieceValue, Enum.Chess.Color Color, Position PiecePosition) : base(PieceName, PieceShortName, PieceValue, Color, PiecePosition) { }
        public override void Capture()
        {
            Console.WriteLine("\nPawn capture");
        }

        public override List<Position> PossibleMoves(ChessBoard board)
        {
            List<Position> moves = new List<Position>();

            #region Front Moves
            Position PieceActualPos = this.PiecePosition;

            Position positionAhead = Position.PositionAhead(new Position(PieceActualPos.intPostion, PieceActualPos.charPosition), this.color);
            Piece inFrontPiece = board.PieceAt(positionAhead);

            if (inFrontPiece == null)
            {
                // possible to add piece in Front
                moves.Add(positionAhead);
            }

            Position positionAheadStep2 = Position.PositionAhead(new Position(PieceActualPos.intPostion, PieceActualPos.charPosition), this.color, 2);

            Piece inFrontPieceStep2 = board.PieceAt(positionAheadStep2);

            if (inFrontPiece == null && this.NumberOfMoves == 0 && inFrontPieceStep2 == null)
            {
                moves.Add(positionAheadStep2);
            }
            #endregion
            #region Captures
            //Position rightLateralPosition = Position.PositionDiag(this.PiecePosition, this.color, true);
            //Piece rightLateralPiece = board.PieceAt(rightLateralPosition);

            //if (rightLateralPiece == null)
            //{
            //    // possible to add piece in Front
            //    moves.Add(rightLateralPosition);
            //}

            //Position leftLateralPosition = Position.PositionDiag(this.PiecePosition, this.color, false);
            //Piece leftLateralPiece = board.PieceAt(leftLateralPosition);
            //if (leftLateralPiece == null && this.NumberOfMoves == 0 && inFrontPieceStep2 == null)
            //{
            //    moves.Add(leftLateralPosition);
            //}
            #endregion

            return moves;
        }

        public override bool isMovePossible(Position position, ChessBoard board)
        {
            List<Position> moves = this.PossibleMoves(board);
            
            return moves.Find(move => move.isEqual(position)) != null;
        }
    }
}
