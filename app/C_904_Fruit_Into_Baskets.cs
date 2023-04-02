using System;

namespace SolutionNamespace
{
    class C_904_Fruit_Into_Baskets
    {
        public static int TotalFruit(int[] fruits) {
            if(fruits == null || fruits.Length == 0)
                return 0;

            int left = 0, right = 0, cnt = 0, res = 0;
            Dictionary<int,int> dic = new Dictionary<int,int>();
            while(right < fruits.Length)
            {
                if(dic.ContainsKey(fruits[right]))
                    dic[fruits[right]]++;
                else
                    dic.Add(fruits[right], 1);

                if(dic[fruits[right]]== 1)
                    cnt++;

                right++;

                while(cnt > 2)
                {
                    dic[fruits[left]]--;
                    if(dic[fruits[left]] == 0)
                        cnt--;
                    left++;
                }

                res = Math.Max(res, right - left);
            }
            return res;
        }
    }
}
