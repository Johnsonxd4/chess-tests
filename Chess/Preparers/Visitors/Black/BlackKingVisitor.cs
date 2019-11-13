namespace Chess.Preparers.Visitors.Black
{
    public class BlackKingVisitor : IVisitor
    {
        public void Visit(IElement element)
        {
            var board = element as Board;
            var king = new King(Color.Black);
            var position = new Position(0, 3, king);
            king.SetPosition(position);

            board.AddPosition(position);
        }
    }
}