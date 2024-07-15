using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsPlayPig.Models
{
    internal class Game
    {
        private int _turnNumber;
        private int _turnScore;
        private int _totalScore;
        private int _diceRoll;
        private string _userReply;

        Random random = new Random();

        public Game()
        {
            Console.WriteLine("Let's Play PIG!\n See how many turns it takes you to get to 20.\n Turn ends when you hold or roll a 1.\n" +
                " If you roll a 1, you lose all points for the turn.\n If you hold, you save all points for the turn.");

            _turnNumber = 1;
            _totalScore = 0;
        }

        public int TotalScore
        {
            set { _totalScore = value; }
            get => _totalScore;
        }

        public int TurnScore
        {
            set => _turnScore = value;
            get => _turnScore;
        }

        public int TurnNumber
        {
            set { _turnNumber = value; }
            get => _turnNumber;
        }

        public string UserReply
        {
            set => _userReply = value;
            get => _userReply;
        }

        public int DiceRollValue
        {
            set => _diceRoll = value;
            get => _diceRoll;
        }

        public void RollDice()
        {
            DiceRollValue = random.Next(1, 6);
        }

        public void IncrementTurnScore()
        {
            TurnScore += DiceRollValue ;
        }

        public void IncrementTurnNumber()
        {
            TurnNumber++;
        }

        public void IncrementTotalScore()
        {
            TotalScore += TurnScore;
            
        }
                  
    }
}