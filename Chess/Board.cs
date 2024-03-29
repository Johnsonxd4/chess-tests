using System;

namespace Chess
{
    public class Board : IElement
    {
        public Position[,] Houses { get; private set; }
        public Board()
        {
            Houses = new Position[8, 8];
        }

        public IPiece GetPieceOfPosition(int x, int y)
        {
            return Houses[x, y].Piece;
        }

        public bool Accept(IVisitor visitor)
        {
            visitor.Visit(this);
            return true;
        }

        internal void AddPosition(Position position)
        {
            if (Houses[position.X, position.Y] != null)
                throw new InvalidOperationException("There's allready a piece on this position");
            Houses[position.X, position.Y] = position;
        }
    }
}