using System;
using System.Collections.Generic;
using System.Linq;
using Tennis.Rules;

namespace Tennis
{
    public class TennisGame1 : ITennisGame
    {
        private int _scorePlayer1;
        private int _scorePlayer2;
        private readonly string _player1Name;

        public TennisGame1(string player1Name, string player2Name)
        {
            this._player1Name = player1Name;
            this._scorePlayer1 = 0;
            this._scorePlayer2 = 0;
        }

        public void WonPoint(string playerName)
        {
            if (playerName == this._player1Name)
                _scorePlayer1 += 1;
            else
                _scorePlayer2 += 1;
        }

        public string GetScore()
        {
            var rules = new List<RuleBase>
            {
                new DeuceRule(),
                new PossibleWinningRule(),
            };
            
            var ruleToUse = rules
                .Find(x => x.CanApply(_scorePlayer1, _scorePlayer2))
                ?? new RuleBase();
            return ruleToUse.GetScoreName(_scorePlayer1, _scorePlayer2);
        }
    }
}

