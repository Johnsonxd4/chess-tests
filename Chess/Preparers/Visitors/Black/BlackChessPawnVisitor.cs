using System.Collections.Generic;

namespace Chess.Preparers.Visitors.Black
{
    public class BlackChessPawnVisitor : IVisitor
    {
        public void Visit(IElement element)
        {
            var board = element as Board;

            for (int i = 0; i < 8; i++)
            {
                var chessPawn = new ChessPawn(Color.Black);
                var position = new Position(1, i, chessPawn);
                chessPawn.SetPosition(position);
                board.AddPosition(position);
            }
        }

    }
}