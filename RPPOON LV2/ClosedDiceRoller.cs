using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON_LV2
{
    class ClosedDiceRoller:IDiceRoller, ILogable
    {
        private List<Die> dice;
        private List<int> resultForEachRoll;

        public ClosedDiceRoller(int diceCount, int numberOfSides)
        {
            this.dice = new List<Die>();
            for(int i = 0; i < diceCount; i++)
            {
                this.dice.Add(new Die(numberOfSides));
            }
            this.resultForEachRoll = new List<int>();
        }
        
        public void RollAllDice()
        {
            this.resultForEachRoll.Clear();
            foreach (Die die in dice)
            {
                die.Roll();
            }
        }

        public List<int> GetRollingResults()
        {
            foreach (Die die in dice)
            {
                this.resultForEachRoll.Add(die.RolledNumber);
            }
            return resultForEachRoll;
        }

        public string GetStringRepresentation()
        {
            StringBuilder builder = new StringBuilder();
            foreach (int result in resultForEachRoll)
            {
                builder.Append(result.ToString());
                builder.Append("\n");
            }
            return builder.ToString();
        }

    }
}
