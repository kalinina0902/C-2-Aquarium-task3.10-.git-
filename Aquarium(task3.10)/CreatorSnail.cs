using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium_task3._10_
{
    class CreatorSnail: CreatorDweller
    {
        public override Dweller Create(Random rnd, IStrategy s)
        {
            return new Snail(rnd, s);
        }
    }
}
