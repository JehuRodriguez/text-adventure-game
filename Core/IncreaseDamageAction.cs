using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextAdventureGame.Models;
using TextAdventureGame.Interfaces;

namespace TextAdventureGame.Core
{
    public class IncreaseDamageAction : IChoiceAction
    {
        private int amount;

        public IncreaseDamageAction(int amount)
        {
            this.amount = amount;
        }

        public void Execute(Player player)
        {
            player.Damage += amount;
            Console.WriteLine($"Tu daño aumenta (+{amount})");
        }
    }
}
