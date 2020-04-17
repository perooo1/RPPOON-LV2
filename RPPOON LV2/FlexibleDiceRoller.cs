using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON_LV2
{
    ///////////////////////////////////////////////////////////  Z6
    /*
    class FlexibleDiceRoller :IDiceRoller, IDiceRollerFlexible
    {
        private List<Die> dice;
        private List<int> resultForEachRoll;

        public FlexibleDiceRoller()
        {
            this.dice = new List<Die>();
            this.resultForEachRoll = new List<int>();
        }

        public void InsertDie(Die die)
        {
            dice.Add(die);
        }

        public void RemoveAllDice()
        {
            this.dice.Clear();
            this.resultForEachRoll.Clear();
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

    }
    */
    ///////////////////////////////////////////////////////////  Z7

    class FlexibleDiceRoller : IDiceRoller, IDiceRollerFlexible, ILogable
    {
        private List<Die> dice;
        private List<int> resultForEachRoll;

        public FlexibleDiceRoller()
        {
            this.dice = new List<Die>();
            this.resultForEachRoll = new List<int>();
        }

        public void InsertDie(Die die)
        {
            dice.Add(die);
        }

        public void RemoveAllDice()
        {
            this.dice.Clear();
            this.resultForEachRoll.Clear();
        }

        public void RemoveDiceWithNumberOfSides(int numberOfSides)
        {
            for(int i = 0; i < this.dice.Count; i++)
            {
                if(this.dice[i].NumberOfSides == numberOfSides)
                {
                    dice.RemoveAt(i);
                    i--;
                }
            }
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
