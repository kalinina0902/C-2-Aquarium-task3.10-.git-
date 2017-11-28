using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium_task3._10_
{
   
    public class Aquarium
    {
        public List <Dweller> denizen { get; private set; } = new List<Dweller>();
        public List<Eat> Feed { get; private set; } = new List<Eat>();
        private int temper;
        public int Temper { get; set; }
       // public int Light { get; set; }
        CreatorDweller creator;
        //private int light;
        //private Fish[] fish;
        //private Fry[] fry;
        //private Snail[] snail;
        public Aquarium(int t)
        {
            
            temper = t;
            //light = l;

        }
        public void StartGame()
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



        }
        public void CreateFood(int x, int y)
        {
            Feed.Add(new Eat(x, y));
        }

        public void FallFood()
        {
            foreach (Eat ea in Feed)
                foreach (Eat.Food kr in ea.Korm)
                    kr.Sink();
        }

       

    }
}
