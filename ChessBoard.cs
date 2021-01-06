using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szachy2
{
    class ChessBoard
    {
        private Square[,] squares = new Square[8, 8];
        private King whiteKing, blackKing;

        List<Move> possibleMoves = new List<Move>();

        public List<Move> GetMoves()
        {
            return possibleMoves;
        }

        public void PrintLegalMoves()
        {
            foreach (Move m in possibleMoves)
            {
                m.PrintMove();
            }
        }
        public void GenerateLegalMoves(bool turn)
        {
            possibleMoves.Clear();

            if (KingInDanger(turn))
            {
                if (turn == Constants.White)
                    whiteKing.SetInDanger(true);
                else
                    blackKing.SetInDanger(true);
            }
            else
            {
                if (turn == Constants.White)
                    whiteKing.SetInDanger(false);
                else
                    blackKing.SetInDanger(false);
            }

            foreach (Square s in GetSquares())
            {
                ClearHighlights();
                if (s.GetPiece() != null)
                {
                    if(s.GetPiece().GetColor() == turn)
                    {
                        s.GetPiece().HighlightMovement(this, s);
                        foreach(Square highlighted in GetSquares())
                        {
                            if (highlighted.GetHighlight()) //possible move
                            {
                                ChessBoard chessBoardAfterMove = this.Copy();
                                Square start = chessBoardAfterMove.GetSquare(s.GetX(), s.GetY());
                                Square end = chessBoardAfterMove.GetSquare(highlighted.GetX(), highlighted.GetY());
                                chessBoardAfterMove.MakeMove(start, end);
                                if (!chessBoardAfterMove.KingInDanger(turn))
                                {
                                    possibleMoves.Add(new Move(s, highlighted, s.GetPiece(), highlighted.GetPiece()));
                                }
                            }
                        }
                    }
                }
            }
            HighlightThreats(turn, false);
        }

        public void ClearHighlights()
        {
            foreach (Square s in squares)
            {
                s.SetHighlight(false);
            }
        }

        public bool KingInDanger(bool turn)
        {
            HighlightThreats(turn, false);
            HighlightThreats(turn, true);
            foreach (Square s in GetSquares())
            {
                if (s.GetPiece() != null)
                {
                    if (s.GetPiece().GetType() == typeof(King) && s.GetPiece().GetColor() == turn)
                    {
                        if (s.GetThreat())
                        { 
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            return false;
            
        }

        public void HighlightThreats(bool turnColor, bool turnOn)
        {
            if (turnOn)
            {
                //highlighting threates from another color
                foreach (Square s in squares)
                {
                    if (s.GetPiece() != null)
                    {
                        if (s.GetPiece().GetColor() != turnColor)
                        {
                            s.GetPiece().HighlightMovement(this, s, true);
                        }
                    }
                }
            }
            else
            {
                foreach (Square s in squares)
                {
                    s.SetThreat(false);
                }
            }
        }

        public ChessBoard()
        {
            Reset();
        }

        private ChessBoard(Square[,] squares)
        {
            this.squares = squares;
        }

        public void MakeMove(Square start, Square end)
        {
            start.GetPiece().Move(start, end, this); //because each piece tracks its movement differently espacially castling
            
            foreach (Square s in squares)
            {
                s.SetEnPassant(null);  //after my move enPassant is no longer available, as it is 1 turn only
            }

            if (end.GetPiece().GetType() == typeof(Pawn)) //if pawn moved correctly it creates enPassant after the cleaning
            {
                if (Math.Abs(start.GetX() - end.GetX()) == 2) //that creates enPassant opportunity
                {
                    if (end.GetPiece().GetColor() == Constants.White)
                        this.GetSquares()[2, start.GetY()].SetEnPassant(end);
                    else
                        this.GetSquares()[5, start.GetY()].SetEnPassant(end);
                }
            }
        }

        public ChessBoard Copy()
        {
            Square[,] newSquares = new Square[8,8];
            for(int i = 0; i < 8; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    if (squares[i, j].GetPiece() == null)
                        newSquares[i, j] = new Square(i, j, null);
                    else
                        newSquares[i, j] = new Square(i, j, squares[i, j].GetPiece().Copy());
                }
            }
            ChessBoard chessBoard = new ChessBoard(newSquares);
            return chessBoard;
        }

        public Square[,] GetSquares()
        {
            return squares ;
        }

        public Square GetSquare(int x, int y)
        {
            return squares[x, y];
        }
        public void Reset()
        {
            squares = new Square[8, 8];
            whiteKing = new King(Constants.White);
            blackKing = new King(Constants.Black);
            //squares[0, 0] = new Square(0, 0, new Rook(Constants.White));
            //squares[0, 1] = new Square(0, 1, new Knight(Constants.White));
            //squares[0, 2] = new Square(0, 2, new Bishop(Constants.White));
            //squares[0, 3] = new Square(0, 3, new Queen(Constants.White));
            //squares[0, 4] = new Square(0, 4, whiteKing);
            //squares[0, 5] = new Square(0, 5, new Bishop(Constants.White));
            //squares[0, 6] = new Square(0, 6, new Knight(Constants.White));
            //squares[0, 7] = new Square(0, 7, new Rook(Constants.White));

            squares[0, 0] = new Square(0, 0, new Rook(Constants.White));
            squares[0, 1] = new Square(0, 1, new Pawn(Constants.White));
            squares[0, 2] = new Square(0, 2, null);
            squares[0, 3] = new Square(0, 3, null);
            squares[0, 4] = new Square(0, 4, whiteKing);
            squares[0, 5] = new Square(0, 5, null);
            squares[0, 6] = new Square(0, 6, null);
            squares[0, 7] = new Square(0, 7, new Rook(Constants.White));

            squares[7, 0] = new Square(7, 0, new Rook(Constants.Black));
            squares[7, 1] = new Square(7, 1, new Knight(Constants.Black));
            squares[7, 2] = new Square(7, 2, new Bishop(Constants.Black));
            squares[7, 3] = new Square(7, 3, new Queen(Constants.Black));
            squares[7, 4] = new Square(7, 4, blackKing);
            squares[7, 5] = new Square(7, 5, new Bishop(Constants.Black));
            squares[7, 6] = new Square(7, 6, new Knight(Constants.Black));
            squares[7, 7] = new Square(7, 7, new Rook(Constants.Black));


            //for (int i = 0; i < 8; i++)
            //{
            //    squares[1,i] = new Square(1, i, new Pawn(Constants.White));
            //}
            for (int i = 0; i < 8; i++)
            {
                squares[1, i] = new Square(1, i, null);
            }

            for (int i = 0; i < 8; i++)
            {
                squares[6, i] = new Square(6, i, new Pawn(Constants.Black));
            }

            for(int i = 2; i < 6; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    squares[i, j] = new Square(i, j);
                }
            }

            squares[4, 4] = new Square(4, 4, new Queen(Constants.Black));
            squares[4, 5] = new Square(4, 5, new Queen(Constants.Black));
            squares[3, 4] = new Square(3, 4, new Rook(Constants.White));
        }
    }
}
