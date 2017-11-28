using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium_task3._10_
{
    public interface IStrategy
    {
        void Death();
        void Eating(ref double x, ref double y, List<Eat> e);
        void Move(ref double x, ref double y, Random rnd);
        void Reproduction();
        bool IsHungry(Dweller f);
    }
}
