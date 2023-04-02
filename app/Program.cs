using System;
using SolutionNamespace;

namespace MainNamespace
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] nums1 = new int[]{2,7,11,15};
            int[] nums2 = new int[]{2,3,4};
            int[] nums3 = new int[]{-1,0};
            Console.WriteLine("Answer is:" + (PrintArray(C_167_Two_Sum_II.TwoSum(nums1, 9))) + " while expected: " + "1,2");
            Console.WriteLine("Answer is:" + (PrintArray(C_167_Two_Sum_II.TwoSum(nums2, 6))) + " while expected: " + "1,3");
            Console.WriteLine("Answer is:" + (PrintArray(C_167_Two_Sum_II.TwoSum(nums3, -1))) + " while expected: " + "1,2");
        }

         public static string PrintArray(int[] arr){
            string s = "[";
            for(int i = 0; i < arr.Length; i++){
                s+= arr[i];
                if(i < arr.Length - 1)
                    s+=  ", ";
            }
            s+= "]";
            return s;

        }
    }
}
