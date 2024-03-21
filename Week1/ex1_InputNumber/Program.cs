namespace ex1_InputNumber
{
    class Program
    {
        static void Main()
        {
            Program program = new Program();
            program.InputNumber();
        }

        /// <summary>
        /// Prompts the user to input a number and parses it into an int
        /// </summary>
        private void InputNumber()
        {
            Console.WriteLine("Input a positive number");
            //  Read line from input stream
            string input = Console.ReadLine() ?? "Null input";

            try
            {
                //  Try parsing
                int number = int.Parse(input);
                Console.WriteLine($"The input number is: {number}");
            }
            catch (Exception e)
            {
                //  Throw exception if parsing is not possible
                Console.WriteLine($"Error parsing input value. Exception: {e.GetType()} -> {e.Message}");
            }
        }
    }
}