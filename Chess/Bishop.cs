namespace Chess
{
    public class Bishop : Piece, IPiece
    {
        public Bishop(Color color) : base(color)
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