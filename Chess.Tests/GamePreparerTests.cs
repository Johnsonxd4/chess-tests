using Xunit;

namespace Chess.Tests
{
    public class GamePreparerTests
    {
        [Fact]
        public void Should_create_new_board()
        {
            var gamePreparer = new GamePreparer();
            var board = gamePreparer.CreateAndPrepareBoard();
            Assert.NotNull(board);
        }

        [Theory]
        [InlineData(0, 0)]
        [InlineData(0, 7)]
        public void Should_create_new_board_with_two_black_towers_on_position(int positionX, int positionY)
        {
            var gamePreparer = new GamePreparer();
            var board = gamePreparer.CreateAndPrepareBoard();

            var position = board.GetPieceOfPosition(positionX, positionY);

            Assert.IsType<Tower>(position);
        }

        [Theory]
        [InlineData(0, 2)]
        [InlineData(0, 5)]
        public void Should_create_new_board_with_two_black_bishops_on_position(int positionX, int positionY)
        {
            var gamePreparer = new GamePreparer();
            var board = gamePreparer.CreateAndPrepareBoard();

            var position = board.GetPieceOfPosition(positionX, positionY);

            Assert.IsType<Bishop>(position);
        }

        [Theory]
        [InlineData(1, 0)]
        [InlineData(1, 1)]
        [InlineData(1, 2)]
        [InlineData(1, 3)]
        [InlineData(1, 4)]
        [InlineData(1, 5)]
        [InlineData(1, 6)]
        [InlineData(1, 7)]
        public void Should_create_new_board_with_eight_black_chessPawns_on_position(int positionX, int positionY)
        {
            var gamePreparer = new GamePreparer();
            var board = gamePreparer.CreateAndPrepareBoard();

            var position = board.GetPieceOfPosition(positionX, positionY);

            Assert.IsType<ChessPawn>(position);

        }

        [Theory]
        [InlineData(0, 1)]
        [InlineData(0, 6)]
        public void Should_create_new_board_with_two_black_horses_on_position(int positionX, int positionY)
        {
            var gamePreparer = new GamePreparer();
            var board = gamePreparer.CreateAndPrepareBoard();

            var position = board.GetPieceOfPosition(positionX, positionY);

            Assert.IsType<Horse>(position);
        }

        [Fact]
        public void Should_create_new_board_with_one_king_on_position_0_3()
        {
            var gamePreparer = new GamePreparer();
            var board = gamePreparer.CreateAndPrepareBoard();

            var position = board.GetPieceOfPosition(0,3);
            Assert.IsType<King>(position);
        }

        [Fact]
        public void Should_create_new_board_with_one_queen_on_position_0_4()
        {
            var gamePreparer = new GamePreparer();
            var board = gamePreparer.CreateAndPrepareBoard();

            var position = board.GetPieceOfPosition(0,4);
            Assert.IsType<Queen>(position);
        }
    }
}