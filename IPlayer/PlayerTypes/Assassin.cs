using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weapons;

namespace Player.PlayerTypes
{
    public class Assassin : IFighter
    {
        public Assassin(string name, int health, int damage, int defense, int speed, int maxRange, int critChance, int poisonChance)
	{
            Name = name;
            Health = health;
            Damage = damage;
            Defense = defense;
            Speed = speed;
            MaxRange = maxRange;
            CritChance = critChance;
            PoisonChance = poisonChance;
	}
        public string Name { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }
        public int Defense { get; set; }
        public int Speed { get; set; }
        public int MaxRange { get; set; }
        public int CritChance { get; set; }
        public int PoisonChance { get; set; }
        public IWeapons Weapon { get; set; }
    }

}
