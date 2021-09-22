using Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player.PlayerTypes
{
    public class Archer : IFighter
    {
        public Archer(string name, int health, int damage, int defense, int speed, int maxRange, int drawBow)
        {
            Name = name;
            Health = health;
            Damage = damage;
            Defense = defense;
            Speed = speed;
            MaxRange = maxRange;
            DrawBow = drawBow;
        }

        public string Name { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }
        public int Defense { get; set; }
        public int Speed { get; set; }
        public int MaxRange { get; set; }
        public int DrawBow { get; set; }

    }
}
