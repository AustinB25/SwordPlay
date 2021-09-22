using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
    public interface IFighter

    {
        string Name { get; set; }
        int Health { get; set; }
        int Damage { get; set; }
        int Defense { get; set;  }
        int Speed { get; set; }
        int MaxRange { get; set; }
    }
}
