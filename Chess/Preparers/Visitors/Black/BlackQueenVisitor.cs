namespace Chess.Preparers.Visitors.Black
{
    public class BlackQueenVisitor : IVisitor
    {
        public void Visit(IElement element)
        {
            var board = element as Board;
            var queen = new Queen(Color.Black);
            var position = new Position(0, 4, queen);
            queen.SetPosition(position);

            board.AddPosition(position);
        }
    }
}