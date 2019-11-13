namespace Chess
{
    public class Position
    {
        public Position(int x, int y, IPiece piece)
        {
            X = x;
            Y = y;
            Piece = piece;
        }
        public int X { get; private set; }
        public int Y { get; private set; }

        public IPiece Piece { get; private set; }
    }
}