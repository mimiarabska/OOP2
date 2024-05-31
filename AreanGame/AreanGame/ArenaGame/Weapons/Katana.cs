﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    class Katana : IWeapon
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


        public Katana(string name)
        {
            Name = name;
            AttackDamage = 40;
            BlockingPower = 15;
            Range = 2;
            CriticalHitChance = 15;
        }
        public void Attack()
        {
            bool isCriticalHit = IsCriticalHit();
            double finalDamage = isCriticalHit ? AttackDamage * 2 : AttackDamage;
            Console.WriteLine($"{Name} attack: {finalDamage} damage{(isCriticalHit ? " (Critical Hit!)" : "")}");
        }
    }
}
