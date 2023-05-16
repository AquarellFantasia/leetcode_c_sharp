using System;
using SolutionNamespace;

namespace MainNamespace
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            TreeNode root = new TreeNode(3);
            root.left = new TreeNode(9);
            root.right = new TreeNode(20);
            root.right.left = new TreeNode(15);
            root.right.right = new TreeNode(7);
            Console.WriteLine("Answer is:" + C_111_Minimum_Depth_of_Binary_Tree.MinDepth(root) + " while expected: 3");
            // Console.WriteLine("Answer is:" + C_102_Binary_Tree_Level_Order_Traversal.LevelOrder(root) + " while expected: 49");
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
