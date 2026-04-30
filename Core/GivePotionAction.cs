using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextAdventureGame.Models;
using TextAdventureGame.Interfaces;


namespace TextAdventureGame.Core
{
    public class GivePotionAction : IChoiceAction
    {
        public void Execute(Player player)
        {
            player.AddItem(new HealthPotion(20));
            Console.WriteLine("Obtienes una poción");
        }
    }
}
