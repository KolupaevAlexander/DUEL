using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Fight : Form
    {
        public Enemy InfoEnemy { get {return enemy;} set {enemy = value; } }
        Enemy enemy;
        public Hero InfoHero { get { return hero; } set { hero = value; } }
        Hero hero;
        public Fight()
        {
            InitializeComponent();
            
        }

        private void Fight_Load(object sender, EventArgs e)
        {
            label1.Text = hero.Name;
            label3.Text = enemy.Name;

            pictureBox1.Image = Image.FromFile(hero.Icon);
            pictureBox2.Image = Image.FromFile(enemy.Icon);

            progressBar1.Maximum = hero.Health;
            progressBar2.Maximum = enemy.Health;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Thread.Sleep(1000);

            progressBar1.Value = hero.Health;
            progressBar2.Value = enemy.Health;

            if (hero.Health > 0 && enemy.Health > 0)
            {
                Creature.Duel(hero, enemy);
            }
            else
            {
                if (enemy.Health>0)
                {
                    label4.Visible = true;
                    pictureBox1.Image = Image.FromFile("d" + hero.Icon);
                }
                else 
                { 
                    label2.Visible = true;
                    pictureBox2.Image = Image.FromFile("d" + enemy.Icon);
                }
                timer1.Stop();
            }
        }

    }
}
