using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Hero : Creature
    {
        public Hero(string name, int health, int damage, int armor, string icon)
        {
            Name = name;
            Health = health;
            Damage = damage;
            Armor = armor;
            Icon = icon;
        }
    }
}
