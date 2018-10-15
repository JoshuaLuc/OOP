using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week09
{
    class Automoble:Object, IMoveable
    {
        string Make { get; set; }
        string Model { get; set; }
        public string GetMake()
        {
            return Make;
        }
        public string GetModel()
        {
            return Model;
        }

        public string Move()
        {
            throw new NotImplementedException();
        }
    }
}
