using System.Collections.Generic;

namespace Tennis.Rules;

public class DeuceRule : RuleBase
{
    private Dictionary<int, string> _scoreNames;

    public DeuceRule()
    {
        _scoreNames = new Dictionary<int, string>
        {
            {0, "Love"},
            {1, "Fifteen"},
            {2, "Thirty"}
        };
    }
    public override bool CanApply(int scorePlayer1, int scorePlayer2) => scorePlayer1 == scorePlayer2;

    public override string GetScoreName(int scorePlayer1, int scorePlayer2)
    {
        return this._scoreNames.ContainsKey(scorePlayer1) ?
            this._scoreNames[scorePlayer1] + "-All" :
            "Deuce";
    }
}