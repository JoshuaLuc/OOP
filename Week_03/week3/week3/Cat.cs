using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3
{
    class Cat : Mammal
    {
        public Cat(int life, string name, float hunger, int legs) : base(life, name, hunger, legs)
        {

        }

        public override string move()
        {
            return"walk";
        }
        public override string poop()
        {
            return"cat poo";
        }
        public override string feed()
        {
            return"cat food";
        }

    }
}
