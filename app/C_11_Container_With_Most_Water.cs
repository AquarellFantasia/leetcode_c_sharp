using System;

namespace SolutionNamespace{
    class C_11_Container_With_Most_Water{
        public static int MaxArea(int[] height) {
            int MaxArea = 0;
            int leftPointer = 0;
            int rightPointer = height.Length - 1;

            while(leftPointer < rightPointer){
                int area = Math.Min(height[leftPointer], height[rightPointer]) * (rightPointer - leftPointer);
                MaxArea = Math.Max(MaxArea, area);
                if(height[leftPointer] < height[rightPointer])
                    leftPointer++;
                else
                    rightPointer--;
            }



            return MaxArea;
        }
    }
}
