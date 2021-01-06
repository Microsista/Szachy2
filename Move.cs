using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szachy2
{
    class Move
    {
        Square startSquare;
        Square endSquare;

        Piece startSquarePiece;
        Piece endSquarePiece;

        public Square GetStartSquare()
        {
            return startSquare;
        }

        public Square GetEndSquare()
        {
            return endSquare;
        }

        public Move(Square startSquare, Square endSquare, Piece startSquarePiece, Piece endSquarePiece = null)
        {
            this.startSquare = startSquare;
            this.endSquare = endSquare;
            this.startSquarePiece = startSquarePiece;
            this.endSquarePiece = endSquarePiece;
        }

        public void PrintMove()
        {
            Console.WriteLine("Square " + startSquare.GetX() +" " + startSquare.GetY() +"  -->  " + endSquare.GetX() + " " + endSquare.GetY());
        }

    }
}
