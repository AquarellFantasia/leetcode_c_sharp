using System;
using SolutionNamespace;

namespace MainNamespace
{
    class Examples
    {
        public static void Main(string[] args)
        {

            char[][] grid2 = new char[][]
            {
                new char[] { '1', '1', '0', '0', '0' },
                new char[] { '1', '1', '0', '0', '0' },
                new char[] { '0', '0', '1', '0', '0' },
                new char[] { '0', '0', '0', '1', '1' }
            };

            Console.WriteLine("Answer is:" + C_200_Number_of_Islands.NumIslands(grid2) + " while expected: 1");
            // Console.WriteLine("Answer is:" + C_102_Binary_Tree_Level_Order_Traversal.LevelOrder(root) + " while expected: 49");
        }
    }
}