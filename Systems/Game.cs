using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextAdventureGame.Models;
using TextAdventureGame.Core;

namespace TextAdventureGame.Systems
{
    internal class Game
    {
        private Player player;
        private List<Situation> situations;
        public void Start()
        {
            Console.WriteLine("Ingresa tu nombre:");
            string name = Console.ReadLine();

            player = new Player(name);
            situations = new List<Situation>();

            CreateSituations();

            foreach (var situation in situations)
            {
                situation.Execute(player);

                if (player.Health <= 0)
                {
                    Console.WriteLine("Has muerto. Fin del juego.");
                    return;
                }
            }


            EndGame();

        }


        private void CreateSituations()
        {
            var s1 = new SimpleSituation("Encuentras un cofre");

            s1.Choices.Add(new Choice("Abrirlo", p =>
            {
                p.AddItem(new HealthPotion(20));
                Console.WriteLine("Obtienes una poción");
            }));

            s1.Choices.Add(new Choice("Ignorarlo", p =>
            {
                Console.WriteLine("Sigues tu camino...");
            }));

            situations.Add(s1);

            var enemy = new Enemy("Goblin", 40, 8);

            var combat = new CombatSituation("Un goblin aparece!", enemy);

            situations.Add(combat);

        }

        private void EndGame()
        {
            if (player.Health > 70)
                Console.WriteLine("Final Bueno");
            else if (player.Health > 30)
                Console.WriteLine("Final Neutral");
            else
                Console.WriteLine("Final Malo");
        }

    }
}
