using Chess.Preparers.Visitors.Black;

namespace Chess {
    public class GamePreparer {
        public Board CreateAndPrepareBoard(){
                var board =  new Board();
                board.Accept(new BlackTowerVisitor());
                board.Accept(new BlackBishopVisitor());
                board.Accept(new BlackChessPawnVisitor());
                return board;
        }
    }
}