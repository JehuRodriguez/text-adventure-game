using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextAdventureGame.Models;

namespace TextAdventureGame.Interfaces
{
    public interface IItem
    {
        void Use(Player player);
    }
}
