using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Creature
    {
        private string name;
        private int health;
        private int damage;
        private int armor;
        private string icon;
        public string Name { get { return name; } set { name = value; } }
        public int Health { get { return health; } set { health = value; } }
        public int Damage { get { return damage; } set { damage = value; } }
        public int Armor { get { return armor; } set { armor = value; } }
        public string Icon { get { return icon; } set { icon = value; } }

        static public void Duel(Creature enemy, Creature hero)
        {
            if (enemy.Damage > hero.Armor)
            { 
                hero.health -= enemy.Damage + hero.Armor / 10;
                if (hero.Health<0) hero.Health = 0;
            }
            if (hero.Damage > enemy.Armor)
            { 
                enemy.health -= hero.Damage + enemy.Armor / 10;
                if (enemy.Health < 0) enemy.Health = 0;
            }
        }
    }
}
