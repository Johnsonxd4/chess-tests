namespace Chess
{
    public abstract class MovementRule {
        internal Position Position;
        internal abstract bool CanMove(Position position);
        public void SetPosition(Position position){
            Position = position;
        }
    }
}