using System.Collections.Generic;
using System.Text;

namespace Tennis.Rules;

public class RuleBase
{
    private Dictionary<int, string> _scoreNames;

    public RuleBase()
    {
        _scoreNames = new Dictionary<int, string>
        {
            {0, "Love"},
            {1, "Fifteen"},
            {2, "Thirty"},
            {3, "Forty"},
        };
    }
    public virtual bool CanApply(int scorePlayer1, int scorePlayer2) => true;

    public virtual string GetScoreName(int scorePlayer1, int scorePlayer2)
    {
        var score = new StringBuilder();
        for (var i = 1; i < 3; i++)
        {
            int tempScore;
            if (i == 1) tempScore = scorePlayer1;
            else
            {
                score.Append('-');
                tempScore = scorePlayer2;
            }

            score.Append(this._scoreNames[tempScore]);
        }

        return score.ToString();
    }
}