using System;
using SolutionNamespace;

namespace MainNamespace
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] nums1 = new int[]{1,8,6,2,5,4,8,3,7};
            int[] nums2 = new int[]{1,1};
            Console.WriteLine("Answer is:" + C_11_Container_With_Most_Water.MaxArea(nums1) + " while expected: 49");
            Console.WriteLine("Answer is:" + C_11_Container_With_Most_Water.MaxArea(nums2) + " while expected: 1");
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
