using System;
using System.Linq;

namespace AppliedArithmeticsEXERCISE
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split()
                .Select(int.Parse).ToArray();
            Action<int[]> print = Print;
            string command = "";

            while ((command = Console.ReadLine()) != "end")
            {
                Action<int[]> actionDelegate = nums =>
                {
                    for (int i = 0; i < nums.Length; i++)
                    {
                        nums[i]++;
                    }
                };
                switch (command)
                {
                    case "add":
                        actionDelegate(numbers);
                        break;
                    case "multiply":
                        actionDelegate = nums =>
                        {
                            for (int i = 0; i < nums.Length; i++)
                            {
                                nums[i] *= 2;
                            }
                        };
                        actionDelegate(numbers);
                        break;
                    case "subtract":
                        actionDelegate = nums =>
                        {
                            for (int i = 0; i < nums.Length; i++)
                            {
                                nums[i]--;
                            }
                        };
                        actionDelegate(numbers);
                        break;
                    case "print":
                        print(numbers);
                        break;
                }
            }
        }

        static void Print(int[] numbers)
        {
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
