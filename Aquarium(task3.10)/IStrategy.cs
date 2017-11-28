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
        void Eating(Fish f, List<Eat> e);
        void Move(Fish f, List<Eat> e);
        void Reproduction();
        bool IsHungry(Dweller f);
    }
}
