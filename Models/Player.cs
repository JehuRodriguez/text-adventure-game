using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextAdventureGame.Interfaces;


namespace TextAdventureGame.Models
{
    public class Player
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }
        public List<IItem> Inventory { get; set; }

        public Player(string name)
        {
            Name = name;
            Health = 100;
            Damage = 10;
            Inventory = new List<IItem>();
        }

        public void TakeDamage(int dmg)
        {
            Health -= dmg;
        }

        public void Heal(int amount)
        {
            Health += amount;
        }

        public void AddItem(IItem item)
        {
            Inventory.Add(item);
        }
    }
}
