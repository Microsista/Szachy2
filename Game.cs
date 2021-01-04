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
        private bool turn = Constants.White;

        public void Click(int x, int y)
        {
            Square s = chessBoard.GetSquare(x, y);
            if(s.GetHighlight() == true) //jeśli hilighted to mozna tam isc
            {
                MakeMove(s);
            } else
            {
                SelectStartSquare(s); //wybierz inne pole?
            }
            
        }

        public void SelectStartSquare(Square square)
        {
            if (selectedSquare == square)
                return;

            if(selectedSquare != null) //wybieramy inne pole
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
                    selectedSquare.Select(chessBoard);
                }
            }
        }

        public Game()
        {
        }

        public void MakeMove(Square endSquare)
        {
            chessBoard.makeMove(selectedSquare, endSquare);

            selectedSquare = null;
            foreach (Square s in chessBoard.GetSquares())
            {
                s.SetHighlight(false);
            }

            turn = !turn;
        }

        public ChessBoard GetChessBoard()
		{
            return chessBoard;
		}

        public bool GetTurn()
        {
            return turn;
        }

    }
}
