using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aquarium_task3._10_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        Aquarium h2o;
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = e.Location.ToString();
        }

        private void Startwork_Click(object sender, EventArgs e)
        {

            int t = temperature.Value;
           
            h2o = new Aquarium(t);
            CreatorDweller creator;
            creator = new CreatorFish();
            IStrategy fs = new  FishStrategy();
            Fish f = creator.Create(rnd, fs);
            h2o.denizen.Add(f);
            h2o.StartGame();
        }

        private void temperature_Scroll(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void food_Click(object sender, EventArgs e)
        {
            h2o.CreateFood(rnd.Next(15, 40), rnd.Next(0, 5));
            h2o.FallFood();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
