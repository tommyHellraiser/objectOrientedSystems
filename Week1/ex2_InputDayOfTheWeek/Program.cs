namespace ex2_InputDayOfTheWeek
{
    class Program
    {
        static void Main()
        {
            Program program = new Program();
            program.InputDay();
        }
        
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
                Console.WriteLine(e);
            }
        }
        
        private enum WeekDays
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

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
                _ => throw new System.Data.ConstraintException("Invalid day as number entered")
            };
        }
    }
}

