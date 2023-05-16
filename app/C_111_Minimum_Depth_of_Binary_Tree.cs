using System;

namespace SolutionNamespace
{
    class C_111_Minimum_Depth_of_Binary_Tree
    {
        public static int MinDepth(TreeNode root)
        {
            Queue<TreeNode> q = new Queue<TreeNode>();

            int count = 0;
            if (root != null)
            {
                q.Enqueue(root);
            }
            else
            {
                return 0;
            }
            while (q.Count > 0)
            {
                count++;
                int size = q.Count;

                for (int i = 0; i < size; ++i)
                {
                    TreeNode cur = q.Dequeue();

                    if (cur.left == null && cur.right == null)
                    {
                        return count;
                    }

                    if (cur.left != null)
                    {
                        q.Enqueue(cur.left);
                    }

                    if (cur.right != null)
                    {
                        q.Enqueue(cur.right);
                    }
                }
            }

            return count;
        }
    }
}
