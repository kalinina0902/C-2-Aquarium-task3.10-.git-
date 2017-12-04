using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Aquarium_task3._10_
{
   public class Fish : Dweller
    {
        
        public Fish(Random rnd, IStrategy s)
        {
            Satiety = 10;
            Kind = "Взрослая";
            X = rnd.Next(0, 100);
            Y = rnd.Next(10, 150);
            TX = rnd.Next(80, 1450);
            TY = rnd.Next(40, 580);
            s = new FishStrategy();
            Pictureliife = new Rectangle(X, Y + 100, 150, 10);

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
