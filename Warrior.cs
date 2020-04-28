using WarriorWars.Equipment;
using WarriorWars.Enum;
using System;
using System.Threading;

namespace WarriorWars
{
    class Warrior
    {
        private const int GOOD_GUY_STARTING_HEALTH = 100;
        private const int BAD_GUY_STARTING_HEALTH = 100;

        private readonly Faction FACTION;

        private int health;
        private string name;
        private bool isAlive;

        public bool IsAlive { get { return this.isAlive; } }

        private Weapon weapon;
        private Armor armor;

        public Warrior(string name, Faction faction)
        {
            this.name = name;
            this.FACTION = faction;
            this.isAlive = true;

            switch (faction)
            {
                case Faction.GoodGuy:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = GOOD_GUY_STARTING_HEALTH;
                    break;
                case Faction.BadGuy:
                    weapon = new Weapon(faction);
                    armor = new Armor(faction);
                    health = BAD_GUY_STARTING_HEALTH;
                    break;
                default:
                    break;
            }

        }

        private void AttackResult(Warrior enemy, int damage)
        {
            if (enemy.health <= 0)
            {
                enemy.isAlive = false;
                Console.WriteLine($"{this.name} defeated {enemy.name}!");
                Tools.ColorfulWriteLine($"{this.name} won!", ConsoleColor.Green);
                Tools.ColorfulWriteLine($"{enemy.name} lost!", ConsoleColor.Red);
            }
            else
            {
                Console.WriteLine($"{name} attacked {enemy.name}. {damage} damage points was inflicted " +
                    $"on {enemy.name}. {enemy.name}'s remaining health is {enemy.health}");
            }
        }

        public void Attack(Warrior enemy)
        {
            int damage = weapon.Damage / enemy.armor.ArmorPoints;

            enemy.health -= damage;

            AttackResult(enemy, damage);

            Thread.Sleep(500);
        }

        
    }
}
