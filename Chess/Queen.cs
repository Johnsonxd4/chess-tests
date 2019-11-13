namespace Chess {
    public class Queen : Piece, IPiece
    {
        public Queen(Color color) : base(color)
        {
        }

        public void Move(Position position)
        {
            throw new System.NotImplementedException();
        }

        internal override bool CanMove(Position position)
        {
            throw new System.NotImplementedException();
        }
    }
}