using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3
{
    class Melee_1: Melee_Weapon
    {
        public Melee_1(int base_damage, int base_range, int action_points, float critical_damage) : base(base_damage, base_range, action_points, critical_damage)
        {
            base_damage = 1;


        }
        public override string move()
        {
            return "walk";
        }
        public override string poop()
        {
            return "dog poo";
        }
        public override string feed()
        {
            return "dog food";
        }
    }
}
