using FluentAssertions;

namespace Game.Test
{
    public class GameTest
    {
        [Fact]
        public void rock_should_win_against_scissors()
        {
            // Arrange
            // Act
            var gameStatus = RockPaperScissors.Play(Moves.Rock, Moves.Scissors);

            // Assert
            gameStatus.Should().Be(GameStatus.Player1Won);
        }

        [Fact]
        public void scissors_should_loose_against_rock()
        {
            // Arrange
            // Act
            var gameStatus = RockPaperScissors.Play(Moves.Scissors, Moves.Rock);

            // Assert
            gameStatus.Should().Be(GameStatus.Player2Won);
        }

        [Fact]
        public void scissors_should_win_against_paper()
        {
            // Arrange
            // Act
            var gameStatus = RockPaperScissors.Play(Moves.Scissors, Moves.Paper);

            // Assert
            gameStatus.Should().Be(GameStatus.Player1Won);
        }

        [Fact]
        public void paper_should_loose_against_scissors()
        {
            // Arrange
            // Act
            var gameStatus = RockPaperScissors.Play(Moves.Paper, Moves.Scissors);

            // Assert
            gameStatus.Should().Be(GameStatus.Player2Won);
        }

        [Fact]
        public void paper_should_win_against_rock()
        {
            // Arrange
            // Act
            var gameStatus = RockPaperScissors.Play(Moves.Paper, Moves.Rock);

            // Assert
            gameStatus.Should().Be(GameStatus.Player1Won);
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