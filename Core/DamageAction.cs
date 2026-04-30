using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextAdventureGame.Models;
using TextAdventureGame.Interfaces;


namespace TextAdventureGame.Core
{
    public class DamageAction : IChoiceAction
    {
        private int damage;

        public DamageAction(int damage)
        {
            this.damage = damage;
        }

        public void Execute(Player player)
        {
            player.TakeDamage(damage);
            Console.WriteLine($"Recibes daño (-{damage} HP)");
        }
    }
}
