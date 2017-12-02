using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium_task3._10_
{

    public class Aquarium
    {
        public List<Dweller> AllFish = new List<Dweller>();
        public List<Eat> Feed { get; private set; } = new List<Eat>();
        private int temper;
        public int Temper { get; set; }
        // public int Light { get; set; }
        CreatorDweller creator;
        //private int light;
        //private Fish[] fish;
        //private Fry[] fry;
        //private Snail[] snail;
        public void AddFish(Dweller fish)
        {
            AllFish.Add(fish);
        }
        /* public Aquarium(int t)
         {

             temper = t;
             //light = l;

         }
        /* public void StartGame()
         {
             Random rnd=new Random();
             creator = new CreatorFish();
             IStrategy s;
             for (int i = 0; i < fish.Length; i++)
             {
                 Dweller f = creator.Create(rnd, s);
                 fish[i] = f;
                 f.Draw();
             }
             creator = new CreatorSnail();
             IStrategy s1;
             for (int i = 0; i < snail.Length; i++)
             {
                 Dweller sn = creator.Create(rnd, s1);
             }



         }*/
        public void CreateFood(int x, int y)
        {
            Feed.Add(new Eat(x, y));
        }

        public void FallFood()
        {
            foreach (Eat ea in Feed)
                foreach (Eat.Crumb kr in ea.Korm)
                    kr.Sink();
        }
        public void Move()
        {
            if (AllFish.Count != 0)
            {
                for (int i = 0; i < AllFish.Count; i++)
                {
                    if (AllFish[i].Satiety == 0)
                    {
                        AllFish[i].s.Death();
                    }
                    else
                    {
                        if (Math.Abs(AllFish[i].TX - AllFish[i].X) < 10 || Math.Abs(AllFish[i].TY - AllFish[i].Y) < 5)
                        {
                            AllFish[i].SetPoint();
                        }

                        AllFish[i].s.Move(AllFish[i], Feed);
                    }

                }
            }



        }
    }
}