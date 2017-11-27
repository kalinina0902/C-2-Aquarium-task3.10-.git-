using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium_task3._10_
{
    class Aquarium
    {
        private int temper;
        public int Temper { get; set; }
       // public int Light { get; set; }
        CreatorDweller creator;
        private int light;
        private Fish[] fish;
        private Fry[] fry;
        private Snail[] snail;
        public Aquarium(int t,int fi,int fr, int s)
        {
            fish = new Fish[fi];
            fry = new Fry[fr];
            snail = new Snail[s];
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

    }
}
