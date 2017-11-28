using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium_task3._10_
{
   public abstract class Dweller
    {
        private int satiety;
        public int Satiety { get { return satiety; } set { satiety = 100; } }
        private string kind;
        public string Kind { get { return kind; } set { kind = value; } }
        private double x;
        public double X { get { return x; } set { x = value; } }
        private double y;
        public double Y { get { return y; } set { y = value; } }
        private double tx;
        public double TX { get { return tx; } set { tx = value; } }
        private double ty;
        public double TY { get { return ty; } set { ty = value; } }
    }
}
