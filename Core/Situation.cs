using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextAdventureGame.Models;

namespace TextAdventureGame.Core
{
    public  abstract class Situation
    {
        public string Description { get; set; }
        public List<Choice> Choices { get; set; }

        public Situation(string description)
        {
            Description = description;
            Choices = new List<Choice>();
        }

        public abstract void Execute(Player player);

    }
}
