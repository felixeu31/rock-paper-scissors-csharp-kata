using FluentAssertions;

namespace Game.Test
{
    public class GameTest
    {
        [Theory]
        [InlineData(Moves.Rock, Moves.Scissors, GameStatus.Player1Won)]
        [InlineData(Moves.Scissors, Moves.Rock, GameStatus.Player2Won)]
        [InlineData(Moves.Scissors, Moves.Paper, GameStatus.Player1Won)]
        [InlineData(Moves.Paper, Moves.Scissors, GameStatus.Player2Won)]
        [InlineData(Moves.Paper, Moves.Rock, GameStatus.Player1Won)]
        public void run_game_should_return_expected_game_status(Moves movePlayer1, Moves movePlayer2, GameStatus expectedGameStatus)
        {
            // Arrange
            // Act
            var gameStatus = RockPaperScissors.Play(movePlayer1, movePlayer2);

            // Assert
            gameStatus.Should().Be(expectedGameStatus);
        }

        //[Fact]
        //public void rock_should_loose_against_paper()
        //{
        //    // Arrange
        //    // Act
        //    var gameStatus = RockPaperScissors.Play(Moves.Rock, Moves.Paper);

        //    // Assert
        //    gameStatus.Should().Be(GameStatus.Player1Won);
        //}
    }
}