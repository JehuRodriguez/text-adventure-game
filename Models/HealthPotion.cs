using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextAdventureGame.Interfaces;


namespace TextAdventureGame.Models
{
    public class HealthPotion : IITEM
    {

        public int HealAmount { get; set; }

        public HealthPotion(int amount)
        {
            HealAmount = amount;
        }

        public void Use(Player player)
        {
            player.Heal(HealAmount);
            Console.WriteLine("Te curaste {HealAmount} de vida.");
        }

    }
}
