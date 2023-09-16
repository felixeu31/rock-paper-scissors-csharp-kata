namespace Game;

public class RockPaperScissors
{
    public static GameStatus Play(Moves movePlayer1, Moves movePlayer2)
    {
        if (movePlayer1 == Moves.Scissors)
            return GameStatus.Player2Won;

        return GameStatus.Player1Won;
    }
}