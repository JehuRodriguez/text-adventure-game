using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextAdventureGame.Models;



namespace TextAdventureGame.Core
{
    public class SimpleSituation : Situation
    {
        public SimpleSituation(string description) : base(description) { }

        public override void Execute(Player player)
        {
            Console.WriteLine(Description);

            for (int i = 0; i < Choices.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Choices[i].Description}");
            }

            int option = int.Parse(Console.ReadLine());
            Choices[option - 1].Execute(player);
        }
    }
}
