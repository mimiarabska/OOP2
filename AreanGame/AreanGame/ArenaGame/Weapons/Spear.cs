using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    class Spear : IWeapon
    {
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }
        public double Range { get; set; }
        public float CriticalHitChance { get; set; }

        private static readonly Random random = new Random();
        private bool IsCriticalHit()
        {
            return random.NextDouble() <= CriticalHitChance / 100.0;
        }


        public Spear(string name)
        {
            Name = name;
            AttackDamage = 30;
            BlockingPower = 7;
            Range = 3;
            CriticalHitChance = 10;
        }
        public void Attack()
        {
            bool isCriticalHit = IsCriticalHit();
            double finalDamage = isCriticalHit ? AttackDamage * 2 : AttackDamage;
            Console.WriteLine($"{Name} attack: {finalDamage} damage{(isCriticalHit ? " (Critical Hit!)" : "")}");
        }
    }
}
