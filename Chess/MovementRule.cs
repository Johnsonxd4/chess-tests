namespace Chess
{
    public abstract class Piece {
        internal Color Color;
        internal Position Position;

        public Piece(Color color)
        {
            Color = color;
        }

        public void SetPosition(Position position){
            Position = position;
        }

        internal abstract bool CanMove(Position position);
    }
}