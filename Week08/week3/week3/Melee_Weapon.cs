using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3
{
    public abstract class Melee_Weapon : Weapon
    {
        public Melee_Weapon(int base_damage, int base_range, int action_points, float critical_damage) : base( base_damage,  base_range,  action_points,  critical_damage)
        {

        }
    }
}
