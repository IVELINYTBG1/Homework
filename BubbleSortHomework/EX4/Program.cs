namespace EX4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BubbleSort();
        }
        static void BubbleSort()
        {
            int[] array = { 5, 17, 42, 8, 93, 26, 71, 33, 64, 11, -87, -13 };

            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {

                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }

                }
            }
            Console.WriteLine($"{ array[0]} е най малкото");
            Console.WriteLine($"{array[11]} е най голямото");
        }
    }
}
