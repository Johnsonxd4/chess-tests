namespace Chess
{
    public class Bishop : MovementRule, IPiece
    {
        private Color _color;
        public Bishop(Color color)
        {
            _color = color;
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