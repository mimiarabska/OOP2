using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    class Warrior : Hero
    {
        public Warrior(string name, double armor, double strenght, IWeapon weapon) :
            base(name, armor, strenght, weapon)
        {
        }

        public override double Attack()
        {
            double damage = base.Attack();

            double probability = random.NextDouble();
            if (probability < 0.50)
            {
                damage *= 2;
            }
            return damage;
        }
        public override double Defend(double damage)
        {
            hitCount++;
            if (hitCount == 2)
            {
                hitCount = 0;
                return 0;
            }
            return base.Defend(damage);
        }
    }
}
