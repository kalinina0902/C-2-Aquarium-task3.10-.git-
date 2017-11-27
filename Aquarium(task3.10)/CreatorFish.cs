using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium_task3._10_
{
    class CreatorFish:CreatorDweller
    {
        public override Dweller Create(Random rnd, IStrategy s)
        {
            return new Fish(rnd, s);
        }
    }
}
