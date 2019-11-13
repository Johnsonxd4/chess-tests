using System;

namespace Chess
{
    public class Tower : Piece, IPiece
    {
        internal override bool CanMove(Position position)
        {
            throw new System.NotImplementedException();
        }

        public void Move(Position position)
        {
            throw new System.NotImplementedException();
        }

        public Tower(Color color) :base(color)
        {
            Color = color;
        }

    }
}