using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3
{
    class Range_1 : Range_Weapon
    {
        public Range_1(int base_damage, int base_range, int action_points, float critical_damage) : base(base_damage, base_range, action_points, critical_damage)
        {

        }
        public override string move()
        {
            return "slither";
        }
        public override string poop()
        {
            return "small, long, brown, white tip";
        }
        public override string feed()
        {
            return "rats";
        }
    }
}
