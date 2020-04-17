using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON_LV2
{
    class Die
    {
        ///////////////////////////////////////////////////////////  Z1 
        /*
        private int numberOfSides;
        private Random randomGenerator;
        private int rolledNumber;

        public Die(int numberOfSides)
        {
            this.numberOfSides = numberOfSides;
            this.randomGenerator = new Random();
        }

        public int RolledNumber { get => rolledNumber; private set => rolledNumber = value; }

        public void Roll()
        {
            RolledNumber = randomGenerator.Next(1, numberOfSides + 1);
        }
        */

        ///////////////////////////////////////////////////////////  Z2
        /*
        private int numberOfSides;
        private Random randomGenerator;
        private int rolledNumber;

        public Die(int numberOfSides, Random random)
        {
            this.numberOfSides = numberOfSides;
            this.randomGenerator = random;
        }

        public int RolledNumber { get => rolledNumber; private set => rolledNumber = value; }

        public void Roll()
        {
            RolledNumber = randomGenerator.Next(1, numberOfSides + 1);
        }
        */
        ///////////////////////////////////////////////////////////  Z3, Z4, Z5, Z6
        /*
        private int numberOfSides;
        private int rolledNumber;

        public Die(int numberOfSides)
        {
            this.numberOfSides = numberOfSides;
        }

        public int RolledNumber { get => rolledNumber; private set => rolledNumber = value; }

        public void Roll()
        {
            RolledNumber = RandomGenerator.GetInstance().NextInt(1, numberOfSides + 1);
        }
        */
        ///////////////////////////////////////////////////////////  Z7

        private int numberOfSides;
        private int rolledNumber;

        public Die(int numberOfSides)
        {
            this.NumberOfSides = numberOfSides;
        }

        public int RolledNumber { get => rolledNumber; private set => rolledNumber = value; }
        public int NumberOfSides { get => numberOfSides; private set => numberOfSides = value; }

        public void Roll()
        {
            RolledNumber = RandomGenerator.GetInstance().NextInt(1, NumberOfSides + 1);
        }
    }
}
