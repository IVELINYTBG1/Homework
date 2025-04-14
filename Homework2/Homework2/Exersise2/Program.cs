namespace Exersise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] numbers = new int[10];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 100);
            }

            Console.WriteLine("случайни числа:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            int smallest = numbers.Min();
            int largest = numbers.Max();

            Console.WriteLine("най малкото число е: " + smallest);
            Console.WriteLine("най голямото число е: " + largest);
        }
    }
}
