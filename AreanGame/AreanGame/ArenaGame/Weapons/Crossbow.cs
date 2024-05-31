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

        public Crossbow(string name)
        {
            Name = name;
            AttackDamage = 15;
            BlockingPower = 12;
            CriticalHitChance = 5;
            

        }
        public double Attack()
        {
            bool isCriticalHit = IsCriticalHit();
            double finalDamage = isCriticalHit ? AttackDamage * 2 : AttackDamage;

            if (HasPoisonedArrow)
            {
                int poisonDamagePercentage = random.Next(1, 31);
                finalDamage += finalDamage * poisonDamagePercentage / 100.0;
            }

            return finalDamage;
        }

    }
}
