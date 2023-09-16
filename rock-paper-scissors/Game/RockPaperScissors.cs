namespace Game;

public class RockPaperScissors
{
    public static GameStatus Play(Moves movePlayer1, Moves movePlayer2)
    {
        if (movePlayer1 == Moves.Scissors)
        {
            if (movePlayer2 == Moves.Paper)
            {
                return GameStatus.Player1Won;
            }
            return GameStatus.Player2Won;
        }

        return GameStatus.Player1Won;
    }
}