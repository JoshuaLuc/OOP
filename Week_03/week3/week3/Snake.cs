using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3
{
    class Snake : Reptile
    {
        public Snake(int life, string name, float hunger) : base(life, name, hunger)
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
