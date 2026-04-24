using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextAdventureGame.Models;


namespace TextAdventureGame.Core
{
    public class Choice
    {
        public string Text { get; set; }
        public Action<Player> Result { get; set; }

        public Choice(string text, Action<Player> result)
        {
            Text = text;
            Result = result;
        }

    }
}
