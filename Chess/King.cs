namespace Chess {
    public class King : Piece, IPiece
    {
        public King(Color color) : base(color)
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