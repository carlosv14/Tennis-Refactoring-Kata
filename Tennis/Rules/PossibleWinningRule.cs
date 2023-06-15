namespace Tennis.Rules;

public class PossibleWinningRule : RuleBase
{
    public override bool CanApply(int scorePlayer1, int scorePlayer2) => scorePlayer1 >= 4 || scorePlayer2 >= 4;

    public override string GetScoreName(int scorePlayer1, int scorePlayer2)
    {
        string score;
        var minusResult = scorePlayer1 - scorePlayer2;
        if (minusResult == 1)
        {
            score = "Advantage player1";
        }
        else if (minusResult == -1)
        {
            score = "Advantage player2";
        }
        else if (minusResult >= 2)
        {
            score = "Win for player1";
        }
        else
        {
            score = "Win for player2";
        }
        return score;
    }
}