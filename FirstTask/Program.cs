using System;
using System.Security.Cryptography;
using System.Threading.Tasks;

class Program
{ 
   public static int[] TwoSum(int[] nums, int target)
   {
       int[] resultIndex= new int[2];
       for (int i = 0; i < nums.Length-1; i++)
       {
           int a = target - nums[i];
           for (int j = 0; j < nums.Length; j++)
           {
               if (nums[j] == a && j!=i)
               {
                   resultIndex[0] = i;
                   resultIndex[1] = j;
                   i = nums.Length;
                   j = nums.Length;
               }
           }
       }

       return resultIndex;
   }
    
    static async Task Main(string[] args)
    { 
        int[] nums={2,7,11,15,4,5,0 };
        int target = 15;
        int[] result= TwoSum(nums, target);
        Console.WriteLine(result[0]);
        Console.WriteLine(result[1]);

    }
}