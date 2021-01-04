using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szachy2
{
    class Knight : Piece
    {
        public Knight(bool color) : base(color) { }
     
        private void HighlightSquare(Square s)
        {
            if(s.GetPiece() != null)
            {
                if (s.GetPiece().GetColor() == color)
                    return;
            }

            s.SetHighlight(true);
        }

        public override void HighlightMovement(ChessBoard chessBoard, Square mySquare)
        {
            Square[,] squares = chessBoard.GetSquares();
            int x = mySquare.GetX();
            int y = mySquare.GetY();
            //up
            if(x < 6)
            {
                //left
                if (y > 0)
                    HighlightSquare(squares[x + 2, y - 1]);
                //right
                if (y < 7)
                    HighlightSquare(squares[x + 2, y + 1]);
            }
            //down
            if (x > 1)
            {
                //left
                if (y > 0)
                    HighlightSquare(squares[x - 2, y - 1]);
                //right
                if (y < 7)
                    HighlightSquare(squares[x - 2, y + 1]);
            }
            //right
            if(y < 6)
            {
                //down
                if(x > 0)
                    HighlightSquare(squares[x - 1, y + 2]);
                //up
                if (x < 7)
                    HighlightSquare(squares[x + 1, y + 2]);
            }
            //left
            if (y > 1)
            {
                //down
                if (x > 0)
                    HighlightSquare(squares[x - 1, y - 2]);
                //up
                if (x < 7)
                    HighlightSquare(squares[x + 1, y - 2]);
            }

        }

        public override void Move(Square startSquare, Square endSquare, ChessBoard chessBoard)
        {
            startSquare.SetPiece(null);
            endSquare.SetPiece(this);
        }
    }
}
