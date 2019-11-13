using System;

namespace Chess
{
    public class Tower : MovementRule, IPiece
    {
        public Color Color { get; }

        internal override bool CanMove(Position position)
        {
            throw new System.NotImplementedException();
        }

        public void Move(Position position)
        {
            throw new System.NotImplementedException();
        }

        public Tower(Color color)
        {
            Color = color;
        }

    }
}