using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON_LV2
{
    class Program
    {
        ///////////////////////////////////////////////////////////  Z1
        /*          
        static void Main(string[] args)
        {
            DiceRoller diceRoller = new DiceRoller();

            for(int i = 0; i < 20; i++)
            {
                Die die = new Die(6);
                diceRoller.InsertDie(die);
            }

            diceRoller.RollAllDice();

            diceRoller.PrintToConsole(diceRoller.GetRollingResults());

        }
        */
        ///////////////////////////////////////////////////////////  Z2
        /*
        static void Main(string[] args)
        { 
            DiceRoller diceRoller = new DiceRoller();
            Random generator = new Random();

            for (int i = 0; i < 20; i++)
            {
                Die die = new Die(6,generator);
                diceRoller.InsertDie(die);
            }

            diceRoller.RollAllDice();

            diceRoller.PrintToConsole(diceRoller.GetRollingResults());
        }
        */
        ///////////////////////////////////////////////////////////  Z3
        /*
        static void Main(string[] args)
        {
            DiceRoller diceRoller = new DiceRoller();

            for (int i = 0; i < 20; i++)
            {
                Die die = new Die(6);
                diceRoller.InsertDie(die);
            }

            diceRoller.RollAllDice();

            diceRoller.PrintToConsole(diceRoller.GetRollingResults());

        }
        */
        ///////////////////////////////////////////////////////////  Z4
        /*
        static void Main(string[] args)
        {
            ConsoleLogger consoleLogger = new ConsoleLogger();
            DiceRoller diceRoller = new DiceRoller(consoleLogger);

            for (int i = 0; i < 20; i++)
            {
                Die die = new Die(6);
                diceRoller.InsertDie(die);
            }

            diceRoller.RollAllDice();
            diceRoller.GetRollingResults();
            diceRoller.LogRollingResults(consoleLogger);

        }
        */
        ///////////////////////////////////////////////////////////  Z5
        /*
       static void Main(string[] args)
        {
            ConsoleLogger consoleLogger = new ConsoleLogger();
            DiceRoller diceRoller = new DiceRoller(consoleLogger);

            for (int i = 0; i < 20; i++)
            {
                Die die = new Die(6);
                diceRoller.InsertDie(die);
            }

            diceRoller.RollAllDice();
            diceRoller.GetRollingResults();

            consoleLogger.Log(diceRoller);
        }
        */
        ///////////////////////////////////////////////////////////  Z6 i Z7
        static void Main(string[] args)
        {
            ConsoleLogger consoleLogger = new ConsoleLogger();
            FlexibleDiceRoller diceRoller = new FlexibleDiceRoller();
            

            for (int i = 0; i < 20; i++)
            {
                Die die = new Die(6);
                diceRoller.InsertDie(die);
            }

            diceRoller.RollAllDice();
            diceRoller.GetRollingResults();
            consoleLogger.Log(diceRoller);

            Console.WriteLine("ClosedDiceRoller:\n");

            ClosedDiceRoller closedDiceRoller = new ClosedDiceRoller(20, 6);
            closedDiceRoller.RollAllDice();
            closedDiceRoller.GetRollingResults();
            consoleLogger.Log(closedDiceRoller);

        }
    }
}
