using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    
    public class Enemy : Creature
    {
        Random random = new Random();
        private string[] firstName = { "Заскучавший", "Унылый", "Пробегавший мимо", "Невысокий", "Застенчивый", "Афро", "Злой", "Раскрепощенный", "Вегатерианец", "Душный" };
        private string[] lastName = { "Виталий", "Дед", "Дворф", "Муравей", "Кот", "Дракон", "Табурет", "Ктулху", "Пень", "Морган Фримен" };
        private string[] pics = { "enemy0.png", "enemy1.png", "enemy2.png", "enemy3.png", "enemy4.jpg", "enemy5.jpg", "enemy6.png", "enemy7.png", "enemy8.png", "enemy9.jpg" };
        public Enemy()
        {
            int x = random.Next(10);
            this.Name = firstName[random.Next(10)] + " " + lastName[x];
            this.Health = random.Next(50,100);
            this.Armor = random.Next(0,50);
            this.Damage = random.Next(5,50);
            this.Icon = pics[x];
        }

        
    }

}
