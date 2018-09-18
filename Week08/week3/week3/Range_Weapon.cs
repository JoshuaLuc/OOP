using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3
{
    public abstract class Range_Weapon : Weapon
    {
        public Range_Weapon(int base_damage, int base_range, int action_points, float critical_damage) : base(base_damage, base_range, action_points, critical_damage)
        {
            
            base_range = 1;
            action_points = 1;
            critical_damage = 2;
        }
    }
}
