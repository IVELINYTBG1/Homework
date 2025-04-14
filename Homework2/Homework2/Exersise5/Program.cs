namespace Exersise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("въведете число за проверка:");
            int targetNumber = int.Parse(Console.ReadLine());

            bool numberExists = numbers.Contains(targetNumber);

            if (numberExists)
            {
                Console.WriteLine("числото " + targetNumber + " съществува");
            }
            else
            {
                Console.WriteLine("числото " + targetNumber + "  не съществува");
            }
        }
    }
}
