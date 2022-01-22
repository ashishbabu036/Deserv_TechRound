using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Deserv_TechRound
{
    public class Player
    {
        private List<bool> _scorecard;
        private int _numberOfServes = 0;

        public Player()
        {
            _scorecard = new List<bool>();
        }

        public Player(int numberOfServes)
        {
            _scorecard = new List<bool>();
            _numberOfServes = numberOfServes;
        }

        public string Name { get; set; }
        public List<bool> ScoreCard { get => _scorecard; set => _scorecard = value; }
        public int Score => _scorecard.Count(x => x == true);
        public int NumberOfServes { get => _numberOfServes; set =>  _numberOfServes = value; }
        public bool IsServeLeft => NumberOfServes > 0;

        public bool HasPlayerWon => _scorecard.Count(x => x == true) == 21 ||
            (_scorecard.Count(x => x == true) >= 11 && _scorecard.Count(x => x == true) - _scorecard.Count(x => x == false) > 1);
            
    }
}
