
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapons
{
    
    public class Sword : IWeapons
    {
        public Sword(string name, int damage, int defense, WeaponWeight weaponWeight)
        {
            Name = name;
            Damage = damage;
            Defense = defense;
            this.weaponWeight = weaponWeight;
        }
        public string Name { get; set; }
        public int Damage { get; set; }
        public int Defense { get; set; }
        public WeaponWeight weaponWeight { get; set; }
    }
    
   
        

    }

