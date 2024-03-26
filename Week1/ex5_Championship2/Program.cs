using System.Text.Json;

namespace ex5_Championship2
{
    //  Small mod to the exercise. The title says 80 points but there are 3 judges rating up to 10 points,
    // so we'll go for just 25 points
    
    /*
     * 3. Modifica la salida de la resolución del punto 2. Se pide mostrar un mensaje que indique si cada participante
     * llegó a la última etapa o no.
     */
    
    class Program
    {
        static void Main()
        {
            List<Contestant> contestants = LoadContestantsList();
            // ShowContestantPoints(contestants);
            ContestantsThatPassed(contestants);
        }

        static void ContestantsThatPassed(List<Contestant> contestants)
        {
            foreach (Contestant contestant in contestants)
            {
                if (contestant.GetTotalPoints() > 25)
                {
                    Console.WriteLine(contestant.Name);
                }
            }
        }

        /// <summary>
        /// Loads contestants list and their points from a json file and proceeds to validate their points. If any point
        /// is higher than 10 or lower than zero, an exception is thrown
        /// </summary>
        /// <returns>
        /// The contestants objects in a list
        /// </returns>
        /// <exception cref="ApplicationException">
        /// Exception thrown when any of the points are not valid
        /// </exception>
        static List<Contestant> LoadContestantsList()
        {
            try
            {
                List<Contestant> contestants = Contestant.LoadPointsFromJson();

                foreach (Contestant contestant in contestants)
                {
                    if (!contestant.ValidatePointsValue())
                    {
                        throw new ApplicationException("Error performing contestant's points validation");
                    }
                }
                
                return contestants;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        /// <summary>
        /// Calls the ShowPoints() method of the Contestant Class to display all details in console
        /// </summary>
        /// <param name="contestants">
        /// Contestants in a List
        /// </param>
        static void ShowContestantPoints(List<Contestant> contestants)
        {
            foreach (Contestant contestant in contestants)
            {
                contestant.ShowPoints();
            }
        }
    }

    /// <summary>
    /// Class that contains each contestant's name and three points from the judges
    /// </summary>
    class Contestant
    {
        public string? Name { get; set; }
        public int? Points1 { get; set; }
        public int? Points2 { get; set; }
        public int? Points3 { get; set; }
        
        public int? GetTotalPoints()
        {
            return Points1 + Points2 + Points3;
        }

        /// <summary>
        /// Validates that the points are between zero and 10
        /// </summary>
        /// <returns>
        /// Bool, always true unless an exception is thrown
        /// </returns>
        /// <exception cref="FormatException">
        /// Exception thrown when any of the points are outside the expected values
        /// </exception>
        public bool ValidatePointsValue()
        {
            if (Points1 is < 0 or > 10)
            {
                throw new FormatException($"Points1 cannot be smaller than 0 or bigger than 10 for contestant {Name}");
            }
            
            if (Points2 is < 0 or > 10)
            {
                throw new FormatException($"Points2 cannot be smaller than 0 or bigger than 10 for contestant {Name}");
            }
            
            if (Points3 is < 0 or > 10)
            {
                throw new FormatException($"Points3 cannot be smaller than 0 or bigger than 10 for contestant {Name}");
            }

            return true;
        }

        /// <summary>
        /// Shows the name of the contestant, all points and their average
        /// </summary>
        public void ShowPoints()
        {
            Console.WriteLine($"Contestant {Name}'s points:");
            Console.WriteLine($"{Points1} | {Points2} | {Points3}");
            float? average = ((float?)Points1 + (float?)Points2 + (float?)Points3) / 3;
            Console.WriteLine("Average points: {0:N2}", average);
        }

        /// <summary>
        /// Loads all Contestants from a json file into a List
        /// </summary>
        /// <returns>
        /// List of Contestants
        /// </returns>
        /// <exception cref="NullReferenceException"></exception>
        public static List<Contestant> LoadPointsFromJson()
        {
            using StreamReader r = new StreamReader("E:\\CSharp\\objectOrientedSystems\\Week1\\ex5_Championship2\\points.json");
            string json = r.ReadToEnd();

            List<Contestant>? contestants = JsonSerializer.Deserialize<List<Contestant>>(json);

            if (contestants == null)
            {
                throw new NullReferenceException();
            }

            return contestants;
        }
    }
}