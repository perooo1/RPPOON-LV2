using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON_LV2
{
    //class DiceRoller
    //{
    ///////////////////////////////////////////////////////////  Z1, Z2 i Z3
    /*          
    private List<Die> dice;
    private List<int> resultForEachRoll;

    public DiceRoller()
    {
        this.dice = new List<Die>();
        this.resultForEachRoll = new List<int>();
    }

    public void InsertDie(Die die)
    {
        dice.Add(die);
    }

    public void RollAllDice()
    {
        this.resultForEachRoll.Clear();
        foreach(Die die in dice)
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

    public int DiceCount()
    {
        return dice.Count;
    }

    public void PrintToConsole(List<int>results)
    {
        foreach (int result in results)
        {
            Console.WriteLine(result);
        }

    }
    */
    ///////////////////////////////////////////////////////////  Z4
    /*
     private List<Die> dice;
     private List<int> resultForEachRoll;
     private ILogger logger;

     public DiceRoller()
     {
         this.dice = new List<Die>();
         this.resultForEachRoll = new List<int>();
         this.logger = new ConsoleLogger();
     }

     public DiceRoller(ILogger logger)
     {
         this.dice = new List<Die>();
         this.resultForEachRoll = new List<int>();
         this.logger = logger;
     }

     public void InsertDie(Die die)
     {
         dice.Add(die);
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

     public int DiceCount()
     {
         return dice.Count;
     }

     public void LogRollingResults(ILogger logger)
     {
         foreach (int result in resultForEachRoll)
         {
             logger.Log(result.ToString());
         }
     }
     
    }
    */
    ///////////////////////////////////////////////////////////  Z5
    /*
    class DiceRoller:ILogable
    {
        private List<Die> dice;
        private List<int> resultForEachRoll;
        private ILogger logger;

        public DiceRoller()
        {
            this.dice = new List<Die>();
            this.resultForEachRoll = new List<int>();
            this.logger = new ConsoleLogger();
        }

        public DiceRoller(ILogger logger)
        {
            this.dice = new List<Die>();
            this.resultForEachRoll = new List<int>();
            this.logger = logger;
        }

        public void InsertDie(Die die)
        {
            dice.Add(die);
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

        public int DiceCount()
        {
            return dice.Count;
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
    */
}
