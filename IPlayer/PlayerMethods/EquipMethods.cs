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
        public bool EquipSword(int playerWithoutSwordInt, IFighter playerWithSword)
        {
            var addSword = new Sword("Sword", 35, 25, WeaponWeight.Medium, WeaponType.Physical);
            if (playerWithoutSwordInt <= 25)
            {
                playerWithoutSwordInt = addSword.Damage;
                playerWithSword.Damage = playerWithoutSwordInt;
                return true;
            }
            return false;
        }
        public bool EquipDagger(int playerWithoutDaggerInt, IFighter playerWithDagger)
        {
            var addDagger = new Dagger("Sword", 35, 25, WeaponWeight.Medium, WeaponType.Physical);
            if (playerWithoutDaggerInt <= 25)
            {
                playerWithoutDaggerInt = addDagger.Damage;
                playerWithDagger.Damage = playerWithoutDaggerInt;
                return true;
            }
            return false;
        }
        public bool EquipBow(int playerWithoutBowInt, IFighter playerWithBow)
        {
            var addBow = new BowAndArrow("Sword", 30, 25, WeaponWeight.Light, WeaponType.Range);
            if (playerWithoutBowInt <= 25)
            {
                playerWithoutBowInt = addBow.Damage;
                playerWithBow.Damage = playerWithoutBowInt;
                return true;
            }
            return false;
        }
        public bool EquipStaff(int playerWithoutStaffInt, IFighter playerWithStaff)
        {
            var addStaff = new Staff("Staff", 35, 25, WeaponWeight.Medium, WeaponType.Magic);
            if (playerWithoutStaffInt <= 25)
            {
                playerWithoutStaffInt = addStaff.Damage;
                playerWithStaff.Damage = playerWithoutStaffInt;
                return true;
            }
            return false;
        }
    }
}
