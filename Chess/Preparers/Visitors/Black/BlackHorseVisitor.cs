namespace Chess.Preparers.Visitors.Black
{
    public class BlackHorseVisitor : IVisitor
    {
        public void Visit(IElement element)
        {
            var board = element as Board;
            var firstHorse = new Horse(Color.Black);
            var position = new Position(0, 1, firstHorse);
            firstHorse.SetPosition(position);

            board.AddPosition(position);

            var secondHorse = new Horse(Color.Black);
            var secondPosition = new Position(0, 6, secondHorse);
            secondHorse.SetPosition(secondPosition);

            board.AddPosition(secondPosition);
        }
    }
}