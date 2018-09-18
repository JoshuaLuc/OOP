using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3
{
    public abstract class Reptile : Animal
    {
        public Reptile(int life, string name, float hunger) : base(life, name, hunger)
        {

        }
    }
}
