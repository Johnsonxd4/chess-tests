namespace Chess.Preparers.Visitors.Black
{
    public class BlackBishopVisitor : IVisitor
    {
        public void Visit(IElement element)
        {
            var board = element as Board;
            var firstBishop = new Bishop(Color.Black);
            var firstPosition = new Position(0, 3, firstBishop);
            firstBishop.SetPosition(firstPosition);

            board.AddPosition(firstPosition);

            var secondBishop = new Bishop(Color.Black);
            var secondPosition = new Position(0, 5, secondBishop);
            secondBishop.SetPosition(secondPosition);

            board.AddPosition(secondPosition);
        }
    }
}