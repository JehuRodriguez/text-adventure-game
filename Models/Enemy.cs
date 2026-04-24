using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventureGame.Models
{
    public class Enemy
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }

        public bool IsAlive => Health > 0;

        public Enemy(string name, int health, int damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }

        public void TakeDamage(int dmg)
        {
            Health -= dmg;
        }
    }
}
