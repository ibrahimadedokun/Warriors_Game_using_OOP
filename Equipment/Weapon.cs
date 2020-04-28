
using WarriorWars.Enum;

namespace WarriorWars.Equipment
{
    class Weapon
    {
        private int GOOD_GUY_DAMAGE = 15;
        private int BAD_GUY_DAMAGE = 10;

        private int damage;

        public int Damage { get { return this.damage; } }

        public Weapon(Faction faction)
        {
            switch (faction)
            {
                case Faction.GoodGuy:
                    this.damage = GOOD_GUY_DAMAGE;
                    break;

                case Faction.BadGuy:
                    this.damage = BAD_GUY_DAMAGE;
                    break;

                default:
                    break;
            }
        }
    }
}
