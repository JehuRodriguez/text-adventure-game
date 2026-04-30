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
                    Console.WriteLine("Has muerto. ¿Quieres volver a intentar? (s/n)");
                    string r = Console.ReadLine();

                    if (r.ToLower() == "s")
                    {
                        Start(); 
                    }
                    return;
                }
            }


            EndGame();

        }


        private void CreateSituations()
        {
            // S1 - Cofre
            var s1 = new SimpleSituation("Encuentras un cofre");

            s1.Choices.Add(new Choice("Abrirlo", new GivePotionAction()));
            s1.Choices.Add(new Choice("Ignorarlo", new DoNothingAction()));

            situations.Add(s1);

            // S2 - Combate
            var enemy = new Enemy("Goblin", 40, 8);
            var combat = new CombatSituation("Un goblin aparece!", enemy);

            situations.Add(combat);

            // S3 - Trampa
            var s3 = new SimpleSituation("Caes en una trampa");
            s3.Choices.Add(new Choice("Salir rápido", new DamageAction(15)));
            s3.Choices.Add(new Choice("Salir con cuidado", new DoNothingAction()));
            situations.Add(s3);

            // S4 - Poción
            var s4 = new SimpleSituation("Encuentras una poción");
            s4.Choices.Add(new Choice("Beberla", new HealAction(10)));
            s4.Choices.Add(new Choice("Guardarla", new GivePotionAction()));
            situations.Add(s4);

            // S5 - Animal
            var s5 = new SimpleSituation("Un animal salvaje aparece");
            s5.Choices.Add(new Choice("Pelear", new DamageAction(10)));
            s5.Choices.Add(new Choice("Huir", new DoNothingAction()));
            situations.Add(s5);

            // S6 - Arma
            var s6 = new SimpleSituation("Encuentras un arma");
            s6.Choices.Add(new Choice("Usarla", new IncreaseDamageAction(5)));
            s6.Choices.Add(new Choice("Ignorarla", new DoNothingAction()));
            situations.Add(s6);

            // S7 - Veneno
            var s7 = new SimpleSituation("Algo te envenena");
            s7.Choices.Add(new Choice("Buscar cura", new DamageAction(20)));
            s7.Choices.Add(new Choice("Resistir", new DoNothingAction()));
            situations.Add(s7);

            // S8 - Suministros
            var s8 = new SimpleSituation("Encuentras suministros");
            s8.Choices.Add(new Choice("Tomarlos", new GivePotionStrongAction()));
            s8.Choices.Add(new Choice("Dejarlos", new DoNothingAction()));
            situations.Add(s8);

            // S9 - Puente
            var s9 = new SimpleSituation("Cruzas un puente peligroso");
            s9.Choices.Add(new Choice("Correr", new DamageAction(10)));
            s9.Choices.Add(new Choice("Ir lento", new DoNothingAction()));
            situations.Add(s9);

            // S10 - Santuario
            var s10 = new SimpleSituation("Encuentras un santuario");
            s10.Choices.Add(new Choice("Rezar", new HealAction(20)));
            s10.Choices.Add(new Choice("Ignorar", new DoNothingAction()));
            situations.Add(s10);

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
