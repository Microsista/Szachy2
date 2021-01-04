using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szachy2
{
    class Game
    {
        private ChessBoard chessBoard = new ChessBoard();
        private Square selectedSquare = null;
        bool turn = Constants.White;

        public void Click(int x, int y)
        {
            Square s = chessBoard.GetSquare(x, y);
            if(s.GetHighlight() == true)
            {
                MakeMove();
            } else
            {
                SelectStartSquare(s);
            }
        }

        public bool SelectStartSquare(Square square)
        {
            if(selectedSquare != null)
            {
                selectedSquare = null;
                foreach (Square s in chessBoard.GetSquares())
                {
                    s.SetHighlight(false);
                }
            }

            Piece p = square.GetPiece();
            if (p != null)
            {
                if(p.GetColor() == turn)
                {
                    selectedSquare = square;
                    selectedSquare.Select();
                    foreach (Square s in chessBoard.GetSquares())
                    {
                        if(p.CanMove(chessBoard, selectedSquare, s))
                        {
                            s.SetHighlight(true);
                        }
                    }
                    return true;
                }
            }
            return false;
        }

        public Game()
        {
            //
        }

        public void MakeMove()
        {

        }

        public ChessBoard GetChessBoard()
		{
            return chessBoard;
		}


    }
}
