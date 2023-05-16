using System;
using SolutionNamespace;

namespace MainNamespace
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] arr1 = new int[] {0, 1, 2, 3, 4, 5, 6, 7 };
            int[] arr2 = new int[] {4,5,6,7,0,1,2 };
            int[] arr3 = new int[] {1};
            int[] arr4 = new int[] {};
            int[] arr5 = new int[] {4,5,6,7,8,1,2,3};
            Console.WriteLine("Answer is:" + C_33_Search_in_Rotated_Sorted_Array.Search(arr1, 1) + " while expected: 1");
            Console.WriteLine("Answer is:" + C_33_Search_in_Rotated_Sorted_Array.Search(arr2, 0) + " while expected: 4");
            Console.WriteLine("Answer is:" + C_33_Search_in_Rotated_Sorted_Array.Search(arr3, 1) + " while expected: 0");
            Console.WriteLine("Answer is:" + C_33_Search_in_Rotated_Sorted_Array.Search(arr4, 1) + " while expected: -1");
            Console.WriteLine("Answer is:" + C_33_Search_in_Rotated_Sorted_Array.Search(arr2, 5) + " while expected: 1");
            Console.WriteLine("Answer is:" + C_33_Search_in_Rotated_Sorted_Array.Search(arr5, 8) + " while expected: 4");
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
