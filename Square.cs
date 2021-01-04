﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szachy2
{
    class Square
    {
        private bool selected = false; //is the square selected
        private bool highlight = false; //is the movement here ok thus the highlight
        private Square enPassant = null; //Square tied to this square who caused enPassant

        private bool threatForWhite = false; //is this square threatened by blacks - king cannot move here
        private bool threatForBlack = false; //is this square threatened by whites

        private int x, y;   //coordinates of the square
        private Piece piece;    //piece on this square

        public Square(int x, int y, Piece piece = null)
        {
            this.x = x;
            this.y = y;
            this.piece = piece;
        }

        public int GetX()
        {
            return x;
        }

        public int GetY()
        {
            return y;
        }

        public void SetPiece(Piece piece)
        {
            this.piece = piece;
        }

        public Piece GetPiece() => piece;

        public void Select(ChessBoard chessBoard)
        {
            SetSelected(true);
            piece.HighlightMovement(chessBoard, this);
        }

        public void SetSelected(bool selected)
        {
            this.selected = selected;
        }

        public bool GetSelected()
        {
            return selected;
        }

        public void SetHighlight(bool highlight)
        {
            this.highlight = highlight;
        }

        public bool GetHighlight()
        {
            return highlight;
        }

        public Square GetEnPassant()
        {
            return enPassant;
        }

        public void SetEnPassant(Square enPassant)
        {
            this.enPassant = enPassant;
        }

        public void CaptureEnPassant()
        {
            
        }

        public bool GetThreat(bool turn)
        {
            if(turn == Constants.White)
                return threatForBlack;
            else
                return threatForWhite;
        }
    }
}
