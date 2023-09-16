using FluentAssertions;

namespace Game.Test
{
    public class GameTest
    {
        [Fact]
        public void rock_should_win_scissors()
        {
            // Arrange
            // Act
            var gameStatus = RockPaperScissors.Play(Moves.Rock, Moves.Scissors);

            // Assert
            gameStatus.Should().Be(GameStatus.Player1Won);
        }
    }
}