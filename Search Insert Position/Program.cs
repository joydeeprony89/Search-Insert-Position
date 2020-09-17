using System;
using System.Linq;

namespace Search_Insert_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the array nos!");
            var input = Console.ReadLine().Split(" ").Select(i=> Convert.ToInt32(i)).ToArray();
            Console.WriteLine("Enter the target !");
            var target = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(SearchInsert(input, target));
        }

        static int SearchInsert(int[] nums, int target)
        {
            if (nums.Length < 1) return 0;
            int low = 0, high = nums.Length - 1;
            while (low <= high)
            {
                int mid = (high - low) / 2 + low;
                if (nums[mid] == target) return mid;
                else if (target < nums[mid]) high = mid - 1;
                else low = mid + 1;
            }

            return low; // why low eg:[1,5] search 0, [1,5] search 6 , [1,5] search 4
        }
    }
}
