using System;
using System.Linq;

namespace ReverseAndExcludeEXERCISE
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int divisor = int.Parse(Console.ReadLine());

            Action<int[]> reverse = nums =>
            {
                for (int i = 0; i < nums.Length / 2; i++)
                {
                    int tmp = nums[i];
                    nums[i] = nums[nums.Length - i - 1];
                    nums[nums.Length - i - 1] = tmp;
                }
            };
            Func<int[], int, int[]> deleteDivisible = (nums, d) => nums.Where(n => n % d != 0).ToArray();
            Action<int[]> print = Print;

            reverse(nums);
            nums = deleteDivisible(nums, divisor);
            print(nums);
        }

        static void Print(int[] arr)
        {
            Console.WriteLine(string.Join(" ",arr));
        }
    }
}
