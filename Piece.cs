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

        protected void Highlight(bool highligh, bool threat, Square s)
        {
            s.SetHighlight(highligh, threat);
        }

        public abstract void Move(Square startSquare, Square endSquare, ChessBoard chessBoard);

        public abstract void HighlightMovement(ChessBoard chessBoard, Square mySquare, bool threat = false); //threat = place king cannot go

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
