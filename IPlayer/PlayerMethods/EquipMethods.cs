using Player.PlayerTypes;
using Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Weapons.Armory;

namespace Player.PlayerMethods
{
    public class EquipMethods
    {
        public bool EquipSword(int currentPlayerDamage, IFighter playerWithSword)
        {
            var addSword = new Sword("Sword", 40, 25, WeaponWeight.Medium, WeaponType.Physical);
            if (currentPlayerDamage <= 25)
            {
                playerWithSword.Weapon = addSword;
                playerWithSword.Damage = playerWithSword.Weapon.Damage;
                return true;
            }
            return false;
        }
        public bool EquipDagger(int currentPlayerDamage, IFighter playerWithDagger)
        {
            var addDagger = new Dagger("Dagger", 35, 25, WeaponWeight.Light, WeaponType.Physical);
            if (currentPlayerDamage <= 25)
            {
                playerWithDagger.Weapon = addDagger;
                playerWithDagger.Damage = addDagger.Damage;                
                return true;
            }
            return false;
        }
        public bool EquipBow(int currentPlayerDamage, IFighter playerWithBow)
        {
            var addBow = new BowAndArrow("Bow and Arrom", 30, 10, WeaponWeight.Light, WeaponType.Range);
            if (currentPlayerDamage <= 25)
            {
                playerWithBow.Weapon = addBow;
                playerWithBow.Damage = addBow.Damage;
                return true;
            }
            return false;
        }
        public bool EquipStaff(int currentPlayerDamage, IFighter playerWithStaff)
        {
            var addStaff = new Staff("Staff", 40, 25, WeaponWeight.Medium, WeaponType.Magic);
            if (currentPlayerDamage <= 25)
            {
                
                return true;
            }
            return false;
        }
        public bool EquipFist(int currentPlayerDamage, IFighter playerFistFighting)
        {
            var showThemThoseHands = new Fists("Fists", 20, 10, WeaponWeight.Light, WeaponType.Physical);
            if (currentPlayerDamage <= 25)
            {
                playerFistFighting.Weapon = showThemThoseHands;
                playerFistFighting.Damage = showThemThoseHands.Damage;
                return true;
            }
            return false;
        }
    }
}
