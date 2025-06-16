namespace MyFirstMiniGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Console.WriteLine("Въведи 5 числа, разделени с интервал:");
            int[] userNumbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int[] randomNumbers = new int[5];

            // Generate and print 5 random numbers with a 5-second cooldown before each print
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(5000); // Wait for 5 seconds
                randomNumbers[i] = random.Next(1, 35);
                Console.WriteLine($"{i + 1}: печелившото число е {randomNumbers[i]}");
            }

            // Wait for 3 seconds before clearing the console
            Thread.Sleep(3000);
            Console.Clear();

            // Check if all user numbers match any random number
            bool isWinner = userNumbers.All(num => randomNumbers.Contains(num));

            if (isWinner)
            {
                Console.WriteLine("Ти спечели");
            }
            else
            {
                Console.WriteLine("Ти загуби");
            }

        }
    }
}            
            
        
    

    

