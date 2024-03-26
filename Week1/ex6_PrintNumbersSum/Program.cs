
namespace ex6_PrintNumbersSum
{
    class Program
    {
        //  This exercise applies to both "Practica formativa A2.4 and .5"
        /*
         * 4. Se trata de implementar un programa que sume los dígitos de un número entero no negativo de 4 dígitos.
         * Por ejemplo, la suma de los dígitos del 3433 es 13.  Para darle un poco más de emoción, el programa no se
         * limitará a escribir el resultado de la suma, sino que también escribirá todos los sumandos
         * utilizados: 3 + 4 + 3 + 3 = 13.
         
         * 5. Resolver la consiga del punto 4 con la particularidad que el número puede tener cualquier cantidad de
         * dígitos, es decir, puede ser un número de dos dígitos como un número de 6 dígitos. Tomá la codificación
         * anterior e introducí los cambios que sean necesarios.
         */
        
        // private const int Number = 763547;  // Sum = 32
        private const long Number = 6969696969;
        
        static void Main()
        {
            string num = ParseNumberAsString();
            int sum = SumNumberDigits(num);
            
            Console.WriteLine($"The sum of all digits is {sum}");
        }

        /// <summary>
        /// Parses the digits of the int constant as a string
        /// </summary>
        /// <returns>
        /// String that contains all digits of the constant number
        /// </returns>
        static string ParseNumberAsString()
        {
            return Number.ToString();
        }

        /// <summary>
        /// Sums all digits of the received number
        /// </summary>
        /// <param name="num">
        /// Int constant number parsed as string
        /// </param>
        /// <returns>
        /// The sum of all digits
        /// </returns>
        static int SumNumberDigits(string num)
        {
            int sum = 0;

            foreach (char letter in num)
            {
                sum += int.Parse(letter.ToString());
            }

            return sum;
        }
    }
}