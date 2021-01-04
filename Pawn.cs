using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szachy2
{
    class Pawn : Piece
    {
        bool firstMove = true;
        public Pawn(bool color) : base(color)
        {
        }

        public void HighlightAttackSquares(int gotoSquareX, int gotoSquareY, Square[,] squares)
        {
            Piece possiblePiece = squares[gotoSquareX, gotoSquareY].GetPiece();
            if (possiblePiece != null)
            {
                if (possiblePiece.GetColor() == Constants.Black)
                {
                    squares[gotoSquareX, gotoSquareY].SetHighlight(true);
                }
            }
            else if (squares[gotoSquareX, gotoSquareY].GetEnPassant())
            {
                squares[gotoSquareX, gotoSquareY].SetHighlight(true);
            }
        }

        private void HighlightAttack(Square[,] squares, Square mySquare)
        {
            if(color == Constants.White)
            {
                if(mySquare.GetY() > 0) //can attack left
                {
                    HighlightAttackSquares(mySquare.GetX() + 1, mySquare.GetY() - 1, squares);
                }

                if(mySquare.GetY() < 7) //can attack right
                {
                    HighlightAttackSquares(mySquare.GetX() + 1, mySquare.GetY() + 1, squares);
                }
            } else //black
            {
                if (mySquare.GetY() > 0) //can attack left
                {
                    HighlightAttackSquares(mySquare.GetX() - 1, mySquare.GetY() - 1, squares);
                }

                if (mySquare.GetY() < 7) //can attack right
                {
                    HighlightAttackSquares(mySquare.GetX() - 1, mySquare.GetY() + 1, squares);
                }
            }
        }

        public override void HighlightMovement(ChessBoard chessBoard, Square mySquare)
        {
            Square[,] squares = chessBoard.GetSquares();

            //todo check for pins...

            if (color == Constants.White)
            {
                if (squares[mySquare.GetX() + 1, mySquare.GetY()].GetPiece() == null)
                {
                    squares[mySquare.GetX() + 1, mySquare.GetY()].SetHighlight(true);
                    if (firstMove)
                    {
                        if (squares[mySquare.GetX() + 2, mySquare.GetY()].GetPiece() == null)
                        {
                            squares[mySquare.GetX() + 2, mySquare.GetY()].SetHighlight(true);
                        }
                    }
                }
                HighlightAttack(squares, mySquare);
            }
            else //black
            {
                if (squares[mySquare.GetX() - 1, mySquare.GetY()].GetPiece() == null)
                {
                    squares[mySquare.GetX() - 1, mySquare.GetY()].SetHighlight(true);
                    if (firstMove)
                    {
                        if (squares[mySquare.GetX() - 2, mySquare.GetY()].GetPiece() == null)
                        {
                            squares[mySquare.GetX() - 2, mySquare.GetY()].SetHighlight(true);
                        }
                    }
                }
                HighlightAttack(squares, mySquare);
            }
        }
    }
}
