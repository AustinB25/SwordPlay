using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapons.Armory
{
    public class Dagger : IWeapons
    {
        public Dagger (string name, int damage, int defense, WeaponWeight weaponWeight, WeaponType weaponType)
        {
            Name = name;
            Damage = damage;
            Defense = defense;
            this.WeaponWeight = weaponWeight;
            this.WeaponType = weaponType;
        }
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Defense { get; set; }
        public WeaponWeight WeaponWeight { get; set; }
        public WeaponType WeaponType { get; set; }
    }
}

