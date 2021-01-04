using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szachy2
{
    class King : Piece
    {
        public King(bool color) : base(color)
        {
        }

        private bool kingInCheck = false;
        private bool firstMove = true;

        private void Highlight(int i, int j, Square[,] squares) //todo check for threats!
        {
            if (squares[i, j].GetPiece() == null) //no piece
            {
                squares[i, j].SetHighlight(true);
            }
            else if (squares[i, j].GetPiece().GetColor() == color) //same color piece
            {
                //no highlight
            }
            else //another color piece
            {
                squares[i, j].SetHighlight(true);
                
            }
        }

        public override void HighlightMovement(ChessBoard chessBoard, Square mySquare)
        {
            int x = mySquare.GetX();
            int y = mySquare.GetY();
            Square[,] squares = chessBoard.GetSquares();

            //left is ok
            if(x > 0)
            {
                Highlight(x - 1, y, squares);
                if(y > 0)
                    Highlight(x - 1, y - 1, squares);
                if(y < 7)
                    Highlight(x - 1, y + 1, squares);
            }
            
            if (x < 7) //right is ok
            {
                Highlight(x + 1, y, squares);
                if (y > 0)
                    Highlight(x + 1, y - 1, squares);
                if (y < 7)
                    Highlight(x + 1, y + 1, squares);
            }
            
            if (y > 0) //down is ok
            {
                Highlight(x, y - 1, squares);
                if (x > 0)
                    Highlight(x - 1, y - 1, squares);
                if (x < 7)
                    Highlight(x + 1, y - 1, squares);
            }

            if(y < 7)  //up is ok
            {
                Highlight(x, y + 1, squares);
                if (x > 0)
                    Highlight(x - 1, y + 1, squares);
                if (x < 7)
                    Highlight(x + 1, y + 1, squares);
            }

            if (firstMove && kingInCheck == false) //there's option for castling
            {
                int i;
                if(color == Constants.White)
                {
                    i = 0;
                }
                else //black
                {
                    i = 7;
                }
                //left side
                if (squares[i, 1].GetPiece() == null && squares[i, 2].GetPiece() == null && squares[i, 3].GetPiece() == null) //no pieces in between
                {
                    if (squares[i, 0].GetPiece() != null)
                    {
                        if (squares[i, 0].GetPiece().GetType() == typeof(Rook))
                        {
                            Rook r = squares[i, 0].GetPiece() as Rook;
                            if (r.GetFirstMove())
                            {
                                squares[i, 2].SetHighlight(true);
                            }
                        }
                    }
                }
                //right side
                if (squares[i, 5].GetPiece() == null && squares[i, 6].GetPiece() == null) //no pieces in between
                {
                    if (squares[i, 7].GetPiece() != null)
                    {
                        if (squares[i, 7].GetPiece().GetType() == typeof(Rook))
                        {
                            Rook r = squares[i, 7].GetPiece() as Rook;
                            if (r.GetFirstMove())
                            {
                                squares[i, 6].SetHighlight(true);
                            }
                        }
                    }
                }
            }
        }

        public override void Move(Square startSquare, Square endSquare, ChessBoard chessBoard)
        {
            Square[,] squares = chessBoard.GetSquares();
            if(Math.Abs(startSquare.GetY() - endSquare.GetY()) > 1) //castling
            {
                startSquare.SetPiece(null);
                endSquare.SetPiece(this);
                if(startSquare.GetY() > endSquare.GetY()) //castle left
                {
                    Rook rook = squares[startSquare.GetX(), 0].GetPiece() as Rook;
                    rook.setFirstMove(false);
                    squares[startSquare.GetX(), 0].SetPiece(null);
                    squares[startSquare.GetX(), 3].SetPiece(rook);
                }
                else //castle right
                {
                    Rook rook = squares[startSquare.GetX(), 7].GetPiece() as Rook;
                    rook.setFirstMove(false);
                    squares[startSquare.GetX(), 7].SetPiece(null);
                    squares[startSquare.GetX(), 5].SetPiece(rook);
                }
            }
            else
            {
                startSquare.SetPiece(null);
                endSquare.SetPiece(this);
            }
            firstMove = false;
        }

        public void setKingInCheck(bool check)
        {
            kingInCheck = check;
        }
    }
}
