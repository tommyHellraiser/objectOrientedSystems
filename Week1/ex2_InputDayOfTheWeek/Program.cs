namespace ex2_InputDayOfTheWeek
{
    class Program
    {
        static void Main()
        {
            //  Instantiate Program class
            Program program = new Program();
            //  Call InputDat method
            program.InputDay();
        }
        
        /// <summary>
        /// Prompts the user to input a number from 1 to 7 to print a day of the week according to the entered number
        /// </summary>
        ///
        /// <remarks>
        /// Easter egg if you enter 8...
        /// </remarks>
        private void InputDay()
        {
            Console.WriteLine("Please enter a number from 1 to 7 to select a day of the week");
			
            try
            {
                WeekDays day = DayFromNumber(int.Parse(Console.ReadLine() ?? "Input was null"));

                Console.WriteLine($"Entered day was {day}");
            }
            catch (Exception e)
            {
                //  Throw an exception if an error is found. Not critical so program will exit with Code 0
                Console.WriteLine(e);
            }
        }
        
        /// <summary>
        /// Enum that allows mapping from a number into a day of the week
        /// </summary>
        private enum WeekDays
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday,
            Osvaldo
        }

        /// <summary>
        /// Maps the input in numeric format into a WeekDays enum format
        /// </summary>
        private WeekDays DayFromNumber(int dayNumber)
        {
            return dayNumber switch
            {
                1 => WeekDays.Monday,
                2 => WeekDays.Tuesday,
                3 => WeekDays.Wednesday,
                4 => WeekDays.Thursday,
                5 => WeekDays.Friday,
                6 => WeekDays.Saturday,
                7 => WeekDays.Sunday,
                8 => WeekDays.Osvaldo,
                _ => throw new System.Data.ConstraintException("Invalid day as number entered")
            };
        }
    }
}

