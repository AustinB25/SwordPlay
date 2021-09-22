using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weapons
{
    public interface IWeapons
    {
        string Name { get; set; }
        int Damage { get; set; }
        int Defense { get; set; }
        WeaponWeight weaponWeight { get; set; }
    }
    public enum WeaponWeight
    {
        Heavy,
        Medium, 
        Light
    }
}
