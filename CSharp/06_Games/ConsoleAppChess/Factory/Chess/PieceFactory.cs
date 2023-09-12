using ConsoleAppChess.Classes;
using ConsoleAppChess.Classes.Chess;
using ConsoleAppChess.Enum.Chess;
using ConsoleAppChess.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppChess.Factory.Chess
{
    public sealed class PieceFactory
    {
        public static Piece CreatePiece(PieceType pieceType, string PieceName, string PieceShortName, int PieceValue, Color Color, int intPos, char charPos)
        {
            Piece piece = null;

            switch (pieceType)
            {
                case PieceType.Pawn:
                    piece = new Pawn(PieceName, PieceShortName, PieceValue, Color, intPos, charPos);
                    break;
                case PieceType.Rook:
                    piece = new Rook(PieceName, PieceShortName, PieceValue, Color, intPos, charPos);
                    break;
                case PieceType.Bishop:
                    piece = new Bishop(PieceName, PieceShortName, PieceValue, Color, intPos, charPos);
                    break;
                case PieceType.Knight:
                    piece = new Knight(PieceName, PieceShortName, PieceValue, Color, intPos, charPos);
                    break;
                case PieceType.Queen:
                    piece = new Queen(PieceName, PieceShortName, PieceValue, Color, intPos, charPos);
                    break;
                case PieceType.King:
                    piece = new Knight(PieceName, PieceShortName, PieceValue, Color, intPos, charPos);
                    break;

                default: return piece;
            }

            return piece;
        }

        public static Piece CreatePiece(PieceType pieceType, string PieceName, string PieceShortName, int PieceValue, Color Color, Position position)
        {
            Piece piece = null;

            switch (pieceType)
            {
                case PieceType.Pawn:
                    piece = new Pawn(PieceName, PieceShortName, PieceValue, Color, position);
                    break;
                case PieceType.Rook:
                    piece = new Rook(PieceName, PieceShortName, PieceValue, Color, position);
                    break;
                case PieceType.Bishop:
                    piece = new Bishop(PieceName, PieceShortName, PieceValue, Color, position);
                    break;
                case PieceType.Knight:
                    piece = new Knight(PieceName, PieceShortName, PieceValue, Color, position);
                    break;
                case PieceType.Queen:
                    piece = new Queen(PieceName, PieceShortName, PieceValue, Color, position);
                    break;
                case PieceType.King:
                    piece = new Knight(PieceName, PieceShortName, PieceValue, Color, position);
                    break;

                default: return piece;
            }

            return piece;
        }
    }
}
