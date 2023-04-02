using System;

namespace SolutionNamespace{
    class C_209_Minimum_Size_Subarray_Sum{
        public static int MinSubArrayLen(int target, int[] nums) {
            if(nums.Length == 0)
                return 0;

            bool found = false;
            int rear = 0;
            int front = -1;
            int sum = 0;
            int min = nums.Length;

            while(++front < nums.Length){
              sum += nums[front];
              if(sum>=target)
                found = true;
                while(sum >= target && rear <= front){
                    min = Math.Min(min, front - rear + 1);
                    sum -= nums[rear++];
                }
            }

            if(!found)
                return 0;
            return min;
        }
    }
}
