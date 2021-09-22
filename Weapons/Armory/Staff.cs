using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapons.Armory
{
    public class Staff :IWeapons
    {
        public Staff(string name, int damage, int defense, WeaponWeight weaponWeight, WeaponType weaponType)
        {
            Name = name;
            Damage = damage;
            Defense = defense;
            this.weaponWeight = weaponWeight;
            this.weaponType = weaponType;
        }
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Defense { get; set; }
        public WeaponWeight weaponWeight { get; set; }
        public WeaponType weaponType { get; set; }
    }
}

