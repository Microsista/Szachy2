using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szachy2
{
    class Rook : Piece
    {
        public Rook(bool color) : base(color)
        {
        }

        public override bool CanMove(ChessBoard chessBoard, Square start, Square end)
        {
            throw new NotImplementedException();
        }
    }
}
