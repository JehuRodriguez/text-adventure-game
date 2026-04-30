using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextAdventureGame.Models;
using TextAdventureGame.Interfaces;

namespace TextAdventureGame.Core
{
    public class DoNothingAction : IChoiceAction
    {
        public void Execute(Player player)
        {
            Console.WriteLine("Sigues tu camino...");
        }

    }
}
