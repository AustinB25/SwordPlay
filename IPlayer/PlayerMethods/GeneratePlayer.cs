using Players.PlayerTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Players.Methods
{
    public class GeneratePlayer
    {
        public Warrior CreateWarrior()
        {
            Warrior warrior = new Warrior("Aurthor", 100, 20, 20, 15);
            return warrior;
        }
    }
}
