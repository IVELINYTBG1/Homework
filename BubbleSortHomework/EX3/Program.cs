namespace EX3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 17, 42, 8, 93, 26, 71, 33, 64, 11, -87, -13 };

            int n = array.Length;
            int i = 0;

            while (i < n - 1) 
            {
                int j = 0;

                while (j < n - i - 1) 
                {
                    if (array[j] > array[j + 1])
                    {
                        
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                    j++;
                }

                i++;
            }

            Console.WriteLine(string.Join(", ", array));
        }
    }
}