using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium_task3._10_
{
    class Snail:IDweller
    {
        private int satiety;
        public int Satiety { get { return satiety; } set { satiety = value; } }
        private string kind;
        public string Kind { get { return kind; } set { kind = value; } }
        public void Create() { }
    }
}
