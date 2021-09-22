
using Player.PlayerTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player.PlayerMethods
{
    
    public class FighterGenerator
    {
        public Warrior CreateWarrior()
        {
            var warrior = new Warrior("Aurthor", 100, 20, 20, 15, 2);
            return warrior;
        }
        public Assassin CreateAssassin()
        {
            var assassin = new Assassin("Sly", 90, 15, 20, 25, 3, 35, 20);
            return assassin;
        }
        public Mage CreateMage()
        {
            var mage = new Mage("King", 80, 10, 20, 20, 5, 40, 2);
            return mage;
        }
        public Archer CreateArcher()
        {
            var archer = new Archer("Westly", 90, 15, 15, 25, 7, 2);
            return archer;
        }
    }
}
