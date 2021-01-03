using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szachy2
{
    class Square
    {
        private bool selected = false;
        private bool highlight = false;
        private int x, y;
        private Piece piece;

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

        public void Select()
        {
            SetSelected(true);
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
    }
}
