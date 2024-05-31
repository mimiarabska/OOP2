using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    class Crossbow : IWeapon
    {
        public string Name { get; set; }
        public double AttackDamage { get; private set; }
        public double BlockingPower { get; private set; }
        public float CriticalHitChance { get; set; }
        public bool HasPoisonedArrow { get; set; }

        private bool IsCriticalHit()
        {
            return random.NextDouble() <= CriticalHitChance / 100.0;
        }
        private bool IsPoisoned()
        {
            return random.NextDouble() <= HasPoisonedArrow / 100.0;
        }

        public Crossbow(string name)
        {
            Name = name;
            AttackDamage = 15;
            HasPoisonedArrow = 3;
            if (IsPoisoned)
            {
                AttackDamage = AttackDamage*2;
            }
            if (IsCriticalHit)
            {
                AttackDamage += AttackDamage * 3;
            }
            BlockingPower = 12;
            CriticalHitChance = 5;
        }


    }
}
