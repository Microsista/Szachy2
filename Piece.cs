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
        public abstract bool CanMove(ChessBoard chessBoard, Square start, Square end);

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
