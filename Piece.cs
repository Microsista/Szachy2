using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szachy2
{
    abstract class Piece
    {
        protected bool color;

        public Piece Copy()
        {
            return this.MemberwiseClone() as Piece;
        }

        public abstract void Move(Square startSquare, Square endSquare, ChessBoard chessBoard);

        public abstract void HighlightMovement(ChessBoard chessBoard, Square mySquare);

        public Piece(bool color)
        {
            this.color = color;
        }

        public bool GetColor()
        {
            return color;
        }
    }
}
