using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szachy2
{
    class Bishop : Piece
    {
        public Bishop(bool color) : base(color)
        {
        }


        public override void HighlightMovement(ChessBoard chessBoard, Square mySquare)
        {
            throw new NotImplementedException();
        }
    }
}
