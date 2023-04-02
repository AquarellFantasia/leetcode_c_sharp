using System;

namespace SolutionNamespace{
    class C_167_Two_Sum_II{
        public static int[] TwoSum(int[] numbers, int target) {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for(int i = 0; i < numbers.Length; i++){
                if(dict.ContainsKey(numbers[i]))
                    return new int[]{dict[numbers[i]] + 1, i + 1};
                else if(!dict.ContainsKey(target - numbers[i]))
                    dict.Add(target - numbers[i], i);
            }
            return new int[]{};
        }
    }
}
