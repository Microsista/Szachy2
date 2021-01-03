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

        public ChessBoard()
        {
            Reset();
        }
        public Square[,] GetSquares()
        {
            return squares;
        }

        public Square GetSquare(int x, int y)
        {
            return squares[x, y];
        }
        public void Reset()
        {
            squares = new Square[8, 8];
            squares[0, 0] = new Square(0, 0, new Rook(Constants.White));
            squares[0, 1] = new Square(0, 0, new Knight(Constants.White));
            squares[0, 2] = new Square(0, 0, new Bishop(Constants.White));
            squares[0, 3] = new Square(0, 0, new Queen(Constants.White));
            squares[0, 4] = new Square(0, 0, new King(Constants.White));
            squares[0, 5] = new Square(0, 0, new Bishop(Constants.White));
            squares[0, 6] = new Square(0, 0, new Knight(Constants.White));
            squares[0, 7] = new Square(0, 0, new Rook(Constants.White));

            squares[7, 0] = new Square(0, 0, new Rook(Constants.Black));
            squares[7, 1] = new Square(0, 0, new Knight(Constants.Black));
            squares[7, 2] = new Square(0, 0, new Bishop(Constants.Black));
            squares[7, 3] = new Square(0, 0, new Queen(Constants.Black));
            squares[7, 4] = new Square(0, 0, new King(Constants.Black));
            squares[7, 5] = new Square(0, 0, new Bishop(Constants.Black));
            squares[7, 6] = new Square(0, 0, new Knight(Constants.Black));
            squares[7, 7] = new Square(0, 0, new Rook(Constants.Black));

            for(int i = 0; i < 8; i++)
            {
                squares[1,i] = new Square(0, 0, new Pawn(Constants.White));
            }

            for (int i = 0; i < 8; i++)
            {
                squares[6, i] = new Square(0, 0, new Pawn(Constants.Black));
            }

            for(int i = 2; i < 6; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    squares[i, j] = new Square(i, j);
                }
            }
        }
    }
}
