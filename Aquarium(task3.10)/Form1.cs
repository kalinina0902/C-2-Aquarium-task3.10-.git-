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
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = e.Location.ToString();
        }

        private void Startwork_Click(object sender, EventArgs e)
        {

            int t = temperature.Value;
            int fi = 3;
            int sn = 6;
            int fr = 0;
            Aquarium h2o = new Aquarium(t, fi, fr, sn);
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
    }
}
