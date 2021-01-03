using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szachy2
{
    class Queen : Piece
    {
        public Queen(bool color) : base(color)
        {
        }

        public override bool CanMove(ChessBoard chessBoard, Square start, Square end)
        {
            throw new NotImplementedException();
        }
    }
}
