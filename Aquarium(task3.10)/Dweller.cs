using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Aquarium_task3._10_
{
   public abstract class Dweller
    {
        Random rnd = new Random();
        public Rectangle Pictureliife;
        private int satiety;
        public int Satiety { get { return satiety; } set { satiety = 100; } }
        private string kind;
        public string Kind { get { return kind; } set { kind = value; } }
        private int x;
        public int X { get { return x; } set { x = value; } }
        private int y;
        public int Y { get { return y; } set { y = value; } }
        private int tx;
        public int TX { get { return tx; } set { tx = value; } }
        private int ty;
        public int TY { get { return ty; } set { ty = value; } }
        public virtual void SetPoint()
        {

            TX = rnd.Next(80, 1450);
            TY = rnd.Next(40, 580);
        }
        public IStrategy s;
    }
}
