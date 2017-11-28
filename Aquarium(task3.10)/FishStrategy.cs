using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium_task3._10_
{
    class FishStrategy : IStrategy
    {
        public void Move(Fish f, List<Eat> food)
        {
            if (IsHungry(f))
            {
                Eating( f, food);
            }
            double dx = f.X - f.TX;
            double dy = f.Y - f.TY;
            { if (dx < 0)
                {
                    f.X += dx / 10.0;
                } else if (dx == 0)
                {
                    f.X += 0;
                }
                else
                {
                    f.X -= dx / 10.0;
                }
                if (dy < 0)
                {
                    f.Y += dy / 10.0;
                }
                else if (dy == 0)
                {
                    f.Y += 0;
                }
                else
                {
                    f.Y -= dy / 10.0;
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
        public void Eating(Fish f, List<Eat> Feed)
        {
            int min;
            foreach (Eat ea in Feed)
                foreach (Eat.Food kr in ea.Korm)
                {

                }

            double dx = x - ;
            double dy = y - e.Y;
            while (x != e.X && y != e.Y)
            {
                if (dx < 0)
                {
                    x += dx / 10.0;
                }
                else if (dx == 0)
                {
                    x += 0;
                }
                else
                {
                    x -= dx / 10.0;
                }
                if (dy < 0)
                {
                    y += dy / 10.0;
                }
                else if (dy == 0)
                {
                    y += 0;
                }
                else
                {
                    y -= dy / 10.0;
                }
            }


        }
        public bool IsHungry(Fish f)
        {
            if (f.Satiety < 30) { return true; }
            return false;
        }
    } }
