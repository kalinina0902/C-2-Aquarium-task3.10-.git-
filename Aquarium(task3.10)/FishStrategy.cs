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
             if (dx < 0)
                {
                    f.X += dx / 10;
                f.turn = true;
                }
                else if (dx == 0)
                {
                    f.X += 0;
                
                }
                else
                {
                    f.X -= dx / 10;
                }
            
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
            f.Pictureliife.X = f.X;
            f.Pictureliife.Y = f.Y;
            

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
            double min = 5000;
            int indexI = -1;
            int indj = -1;
            double distance;
            foreach (Eat ea in Feed)
                for (int j = 0; j < Feed.Count; j++)
                    for (int k = 0; k < ea.Korm.Count; k++)
            {
                distance = Math.Sqrt((f.X - ea.Korm.ElementAt(k).x) * (f.X - ea.Korm.ElementAt(k).x)+ (f.Y - ea.Korm.ElementAt(k).y) * (f.Y - ea.Korm.ElementAt(k).y));
                if (distance < min)
                {
                    min = distance;
                    indexI = k;
                            indj = j;
                }
            }
            if (min <= 20)
            {
                Feed[indj].Korm.RemoveAt(indexI);
                f.Satiety += 15;
                return;
            }
            int dx = f.X - Feed[indj].Korm[indexI].x;
            int dy = f.Y - Feed[indj].Korm[indexI].y;
            int stepX = 10;
            int stepY = 5;

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
            f.Pictureliife.X = f.X;
            f.Pictureliife.Y = f.Y;



        }
        public bool IsHungry(Dweller f)
        {
            if (f.Satiety < 30) { return true; }
            return false;
        }
    } }
