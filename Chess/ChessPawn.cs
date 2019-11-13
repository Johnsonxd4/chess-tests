namespace Chess {
    public class ChessPawn : MovementRule, IPiece
    {
        private Color _color;
        public void Move(Position position)
        {
            throw new System.NotImplementedException();
        }

        public ChessPawn(Color color)
        {
            _color = color;
        }

        internal override bool CanMove(Position position)
        {
            throw new System.NotImplementedException();
        }
    }
}