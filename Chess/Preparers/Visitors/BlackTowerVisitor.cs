namespace Chess.Preparers.Visitors
{
    public class BlackTowerVisitor : IVisitor
    {
        public void Visit(IElement element)
        {
            var board = element as Board;
            var firstblacktower = new Tower(Color.Black);
            var position = new Position(0, 0, firstblacktower);

            firstblacktower.SetPosition(position);

            var secondBlackTower = new Tower(Color.Black);
            var secondPosition = new Position(0, 7, secondBlackTower);
            secondBlackTower.SetPosition(secondPosition);

            board.AddPosition(position);
            board.AddPosition(secondPosition);
        }
    }
}