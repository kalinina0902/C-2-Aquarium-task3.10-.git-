using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium_task3._10_
{
    class FishStrategy : IStrategy
    {
        public void Move(Dweller f, List<Eat> food)
        {
            if (IsHungry(f))
            {
                Eating( f, food);
            }
            int dx = f.X - f.TX;
            int dy = f.Y - f.TY;
            while (dx != 0)
            {
                if (dx < 0)
                {
                    f.X += dx / 10;
                }
                else if (dx == 0)
                {
                    f.X += 0;
                }
                else
                {
                    f.X -= dx / 10;
                }
            }
            while (dy != 0)
            {
                if (dy < 0)
                {
                    f.Y += dy / 10;
                }
                else if (dy == 0)
                {
                    f.Y += 0;
                }
                else
                {
                    f.Y -= dy / 10;
                }
            }
            

        }

        public void Death()
        {

        }
        public void Reproduction()
        {
            Fry a = new Fry(1, "a");
        }
        public void Eating(Dweller f, List<Eat> Feed)
        {
            //int min;
            //foreach (Eat ea in Feed)
            //    foreach (Eat.Food kr in ea.Korm)
            //    {

            //    }
            Random rnd = new Random();
            int i = rnd.Next(0, Feed.Count);
            int j = rnd.Next(0, Feed[i].Korm.Count);
            int dx = f.X - Feed[i].Korm[j].x;
            int dy = f.Y - Feed[i].Korm[i].y;
            int stepX = 10;
            int stepY = 5;

            while (dx != 0)
            {
                if (dx < 0)
                {
                    f.X += stepX;
                }
                else if (dx == 0)
                {
                    f.X += 0;
                }
                else
                {
                    f.X -= stepX;
                }
            }
                while (dy != 0) { 
                if (dy < 0)
                {
                    f.Y += stepY;
                }
                else if (dy == 0)
                {
                    f.Y += 0;
                }
                else
                {
                    f.Y -= stepY;
                }
            }
            f.Satiety += 45;
            Feed.RemoveAt(i);



        }
        public bool IsHungry(Dweller f)
        {
            if (f.Satiety < 30) { return true; }
            return false;
        }
    } }
