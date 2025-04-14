using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exersise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            foreach (int number in numbers)
            {
                
                if (number % 2 == 0)
                {
                   Console.WriteLine(number);
                }
            }
        }
    }
}