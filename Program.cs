using System;
using WarriorWars.Enum;

namespace WarriorWars
{
    class Program
    {
        static Random rand = new Random();
        static void Main(string[] args)
        {
            Warrior goodGuy = new Warrior("Ibrahim", Faction.GoodGuy);
            Warrior badGuy = new Warrior("Seun", Faction.BadGuy);

            while (goodGuy.IsAlive && badGuy.IsAlive)
            {
                //Probability of attacking is less than 0.5
                if(rand.Next(0,10) < 5)
                {
                    goodGuy.Attack(badGuy);
                }
                else
                {
                    badGuy.Attack(goodGuy);
                }
            }

            Console.ReadKey();
        }        
    }
}
