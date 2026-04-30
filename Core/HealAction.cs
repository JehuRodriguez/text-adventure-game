using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextAdventureGame.Models;
using TextAdventureGame.Interfaces;

namespace TextAdventureGame.Core
{
    public class HealAction : IChoiceAction
    {
        private int amount;

        public HealAction(int amount)
        {
            this.amount = amount;
        }

        public void Execute(Player player)
        {
            player.Heal(amount);
            Console.WriteLine($"Te curas (+{amount} HP)");
        }




    }
}
