using System;

namespace SolutionNamespace{
    class C_102_Binary_Tree_Level_Order_Traversal    {
        public static List<List<int>> LevelOrder(TreeNode root){
            List<List<int>> ans = new List<List<int>>();
            Queue<TreeNode> q = new Queue<TreeNode>();

            if (root != null){
                q.Enqueue(root);
            }

            while (q.Count > 0){
                int size = q.Count;
                List<int> subAns = new List<int>();

                for (int i = 0; i < size; ++i){
                    TreeNode cur = q.Dequeue();
                    subAns.Add(cur.val);

                    if (cur.left != null){
                        q.Enqueue(cur.left);
                    }

                    if (cur.right != null){
                        q.Enqueue(cur.right);
                    }
                }

                ans.Add(subAns);
            }

            return ans;
        }
    }
}
