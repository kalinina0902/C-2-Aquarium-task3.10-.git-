using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium_task3._10_
{
    class FishStrategy:IStrategy
    {
        public void Move(ref double x, ref double y, Random rnd)
        {
            double x1 = rnd(,);
            double y1 = rnd(,);
            double dx = x - x1;
            double dy = y - y1;
            while (x != x1 && y != y1)
            { if (dx < 0)
                {
                    x += dx / 10.0;
                } else if (dx == 0)
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
        
        public void Death()
        {

        }
        public void Reproduction()
        {
            Fry a = new Fry(1,"a");
        }
        public void Eating(ref double x, ref double y, Eat e)
        {
            double dx = x - e.X;
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
    }
