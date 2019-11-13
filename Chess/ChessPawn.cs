namespace Chess {
    public class ChessPawn : Piece, IPiece
    {
        public void Move(Position position)
        {
            throw new System.NotImplementedException();
        }

        internal override bool CanMove(Position position)
        {
            throw new System.NotImplementedException();
        }
        public ChessPawn(Color color) : base(color) { }
    }
}