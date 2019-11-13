namespace Chess {
    public class Horse : Piece, IPiece
    {
        public Horse(Color color) : base(color)
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