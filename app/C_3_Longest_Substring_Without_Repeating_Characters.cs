using System;

namespace SolutionNamespace
{
    class C_3_Longest_Substring_Without_Repeating_Characters{
        public static int LengthOfLongestSubstring(string s){
            HashSet<char> letters = new HashSet<char>();
            int longest = 0;
            int start = 0;
            for(int i = 0; i < s.Length; i++){
                if(!letters.Contains(s[i])){
                    letters.Add(s[i]);
                    longest = Math.Max(longest, i - start + 1);
                }
                else{
                    while(letters.Contains(s[i])){
                        letters.Remove(s[start]);
                        start++;
                    }
                    letters.Add(s[i]);
                }
            }
            return longest;
        }
    }
}
