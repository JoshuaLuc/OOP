using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3
{
    public abstract class Weapon
    {

        public Weapon(int base_damage, int base_range, int action_points, float critical_damage)
        {
            Base_Damage = base_damage;
            Base_Range = base_range;
            Action_Points = action_points;
            Critical_Damage = critical_damage;
        }
        public int Base_Damage { get; set; }
        public int Base_Range { get; set; }
        public int Action_Points { get; set; }
        public float Critical_Damage { get; set; }

        public abstract string move();
        public abstract string poop();
        public abstract string feed();


    }
}
