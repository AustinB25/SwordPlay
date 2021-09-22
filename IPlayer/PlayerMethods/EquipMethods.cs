using Player.PlayerTypes;
using Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player.PlayerMethods
{
    public class EquipMethods
    {
        public bool EquipSwordToWarrior(int playerWithoutSwordInt, Warrior playerWithSword)
        {
            var addSword = new Sword("Sword", 35, 25, WeaponWeight.Medium);
            if (playerWithoutSwordInt <= 25)
            {
                playerWithoutSwordInt = addSword.Damage;
                playerWithSword.Damage = playerWithoutSwordInt;
                return true;
            }
            return false;
        }
    }
}
