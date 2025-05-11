namespace BubbleSortHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 5, 3, 8, 4, 2 };

            bool statement = false;

            int n = nums.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        statement = true;
                        int temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
                if (!statement) 
                {
                    break;
                }
            }
        }
    }
}
