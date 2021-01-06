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
            //chessBoard.HighlightThreats(turn, false);
            Square s = chessBoard.GetSquare(x, y);
            if(s.GetHighlight() == true) //jeśli hilighted to mozna tam isc
            {
                MakeMove(s);
            } else
            {
                SelectStartSquare(s); //wybierz inne pole
            }
        }

        public void SelectStartSquare(Square square)
        {
            if (selectedSquare == square)
                return; //wybrane to samo pole

            chessBoard.GenerateLegalMoves(turn);
            selectedSquare = null;
            foreach (Move m in chessBoard.GetMoves())
            {
                if (m.GetStartSquare() == square)    //one of possible moves!
                {
                    selectedSquare = square;
                    m.GetEndSquare().SetHighlight(true); //highlight one of legal moves
                }
            }
        }

        public Game()
        {
        }

        public void MakeMove(Square endSquare)
        {
            chessBoard.MakeMove(selectedSquare, endSquare);

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
