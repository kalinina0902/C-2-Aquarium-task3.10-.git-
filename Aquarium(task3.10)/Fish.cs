using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium_task3._10_
{
    class Fish:Dweller
    {
        public Fish(int x, int y)
        {
            creator = new CreatorFish();
            creator.Create( x, y);
            X = x;
            Y = y; 

        }
        //private int satiety;
        //public int Satiety { get { return satiety; } set { satiety = value; } }
        //private string kind;
        //public string Kind { get { return kind; } set { kind = value; } }
        //private double targetX;
        //public double TargetX { get { return targetX; } set { targetX = value; } }
        //private double targetY;
        //public double TargetY { get { return targetY; } set { targetY = value; } }
        //public void Create(int satiety, string kind,Random rnd)
        //{
        //    this.Kind = kind;
        //    this.Satiety = satiety;
        //    this.TargetX = rnd.Next(4);
        //    this.TargetY = rnd.Next(5);
        //}
        
    }
}
