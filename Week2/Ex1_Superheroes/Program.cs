using System.Text.Json;

namespace Ex1_Superheroes

    /*
     * Create a program that allows to load a json file with all superheroes, and make them fight each other.
     * We added Deadpool, Batman and Superman, more can be added
     * They need to fight and show the result between Win, Lose, or Tie
     */
{
    class Program
    {
        static void Main()
        {
            // List<Superhero> supers = LoadFromJson();
            //  Instantiating all three supers to fight against each other and get rekt
            Superhero batman = new Superhero
            {
                Name = "Batman",
                Strength = 90,
                Stamina = 70,
                Super = 0
            };

            Superhero superman = new Superhero
            {
                Name = "Superman",
                Strength = 95,
                Stamina = 60,
                Super = 70
            };

            Superhero deadpool = new Superhero
            {
                Name = "Deadpool",
                Strength = 69,
                Stamina = 99,
                Super = 3
            };
            
            superman.Fight(batman);
            superman.Fight(deadpool);
            deadpool.Fight(batman);
        }

        // static List<Superhero> LoadFromJson()
        // {
        //     using StreamReader r = new StreamReader("E:\\CSharp\\objectOrientedSystems\\Week2\\Ex1_Superheroes\\supers.json");
        //     string json = r.ReadToEnd();
        //
        //     List<Superhero>? supers = JsonSerializer.Deserialize<List<Superhero>>(json);
        //     
        //     if (supers == null)
        //     {
        //         throw new NullReferenceException();
        //     }
        //
        //     return supers;
        // }
    }

    class Superhero
    {
        public string? Name;
        public int? Strength;
        public int? Stamina;
        public int? Super;

        // enum Compare
        // {
        //     Greater = 0,
        //     Smaller,
        //     Equal
        // }
        //
        // Compare CompareNums(int num1, int num2)
        // {
        //     if (num1 > num2)
        //     {
        //         return Compare.Greater;
        //     } 
        //     if (num1 == num2)
        //     {
        //         return Compare.Equal;
        //     }
        //
        //     return Compare.Smaller;
        // }

        /// <summary>
        /// Executes a fight against another superhero comparing stats and printing if the instantiated superhero won,
        /// lost, or if it was a tie
        /// </summary>
        /// <param name="enemy">
        /// Superhero to fight against
        /// </param>
        public void Fight(Superhero enemy)
        {
            int wins = 0;
            int loss = 0;
            
            Console.WriteLine($"\n{this.Name} is about to fight {enemy.Name}!!");
            
            if (this.Strength > enemy.Strength)
            {
                wins++;
            } else if (this.Strength < enemy.Strength)
            {
                loss++;
            }

            if (this.Stamina > enemy.Stamina)
            {
                wins++;
            } else if (this.Stamina < enemy.Stamina)
            {
                loss++;
            }

            if (this.Super > enemy.Super)
            {
                wins++;
            } else if (this.Super < enemy.Super)
            {
                loss++;
            }

            if (wins == 0 && loss == 0)
            {
                Console.WriteLine($"The fight was a tie!! O.O");                
            }
            else if (wins > loss)
            {
                Console.WriteLine($"{this.Name} won against {enemy.Name}!!");
            } else
            {
                Console.WriteLine($"{this.Name} lost to {enemy.Name}! :(");
            }
            
        }
    }
}