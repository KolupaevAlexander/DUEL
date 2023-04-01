using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string[] heroIcons = { "01.jpg", "2.jpg", "3.jpg", "4.jpg", "5.jpg", };
        int iconIndex = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void nextHero(object sender, EventArgs e)
        {
            if (iconIndex == 4)
                iconIndex = 0;
            else iconIndex++;
            pictureBox1.Image = Image.FromFile(heroIcons[iconIndex]);
        }

        private void previousHero(object sender, EventArgs e)
        {
            if (iconIndex == 0)
                iconIndex = 4;
            else iconIndex--;
            pictureBox1.Image = Image.FromFile(heroIcons[iconIndex]);
        }

        private void startBattle(object sender, EventArgs e)
        {
            if (enemyReady && heroReady)
            {
                Fight newForm = new Fight();
                newForm.InfoEnemy = enemy;
                newForm.InfoHero = hero;
                newForm.Show();
            }
        }

        bool enemyReady = false;
        bool heroReady = false;
        Enemy enemy = new Enemy();
        Hero hero;
        private void enemyCreate(object sender, EventArgs e)
        {
            enemy = new Enemy();
            label3.Text = enemy.Name;
            label4.Text = "Жизни: " + enemy.Health.ToString();
            label5.Text = "Броня: " + enemy.Armor.ToString();
            label6.Text = "Урон: " + enemy.Damage.ToString();
            pictureBox2.Image = Image.FromFile(enemy.Icon);
            enemyReady = true;
        }

        private void heroCreate(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && comboBox1.SelectedIndex != -1 && comboBox2.SelectedIndex != -1)
            {
                hero = new Hero(textBox1.Text, 200, comboBox2.SelectedIndex * 5, comboBox1.SelectedIndex * 5, heroIcons[iconIndex]);

                textBox1.Enabled = false;
                comboBox1.Enabled = false;
                comboBox2.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                heroReady = true;
            }
            else MessageBox.Show("Ошибка в создании героя");
        }
    }
}
