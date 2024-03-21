namespace ex1_InputNumber
{
    class Program
    {
        static void Main()
        {
            Program program = new Program();
            program.InputNumber();
        }

        private void InputNumber()
        {
            Console.WriteLine("Input a positive number");

            string input = Console.ReadLine() ?? "Null input";

            try
            {
                int number = int.Parse(input);

                Console.WriteLine($"The input number is: {number}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error parsing input value. Exception: {e.GetType()} -> {e.Message}");
            }
        }
    }
}