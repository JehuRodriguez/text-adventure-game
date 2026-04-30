using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextAdventureGame.Models;


namespace TextAdventureGame.Core
{
    public class CombatSituation : Situation
    {
        private Enemy enemy;

        public CombatSituation(string description, Enemy enemy) : base(description)
        {
            this.enemy = enemy;
        }

        public override void Execute(Player player)
        {
            Console.WriteLine(Description);
            Console.WriteLine($"Te enfrentas a {enemy.Name}");

            while (player.Health > 0 && enemy.Health > 0)
            {
                Console.WriteLine("\n--- TURNO ---");
                Console.WriteLine($"Tu vida: {player.Health}");
                Console.WriteLine($"Vida de {enemy.Name}: {enemy.Health}");

                Console.WriteLine("1. Atacar");
                Console.WriteLine("2. Usar item");

                int option;
                bool valid = int.TryParse(Console.ReadLine(), out option);

                if (!valid || option < 1 || option > 2)
                {
                    Console.WriteLine("Opción inválida");
                    continue;
                }

                if (option == 1)
                {
                    enemy.TakeDamage(player.Damage);
                    Console.WriteLine($"Atacas y haces {player.Damage} de daño");
                }

                else
                {
                    if (player.Inventory.Count == 0)
                    {
                        Console.WriteLine("No tienes items");
                        continue;
                    }

                    Console.WriteLine("Inventario:");
                    for (int i = 0; i < player.Inventory.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. Item {i + 1}");
                    }

                    int itemChoice;
                    if (int.TryParse(Console.ReadLine(), out itemChoice) &&
                        itemChoice > 0 &&
                        itemChoice <= player.Inventory.Count)
                    {
                        var item = player.Inventory[itemChoice - 1];
                        item.Use(player);
                        player.Inventory.RemoveAt(itemChoice - 1);
                    }

                    else
                    {
                        Console.WriteLine("Selección inválida");
                        continue;
                    }
                }
                if (enemy.Health > 0)
                {
                    player.TakeDamage(enemy.Damage);
                    Console.WriteLine($"{enemy.Name} te golpea por {enemy.Damage}");
                }

            }

            if (player.Health > 0)
            {
                Console.WriteLine($"Derrotaste a {enemy.Name}");
            }
            else
            {
                Console.WriteLine("Has sido derrotado...");
            }
        }






    }
}
