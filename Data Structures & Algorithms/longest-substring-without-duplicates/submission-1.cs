public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int left = 0;
        int max = 0;
        Dictionary<char, int> map = new Dictionary<char, int>();
        for (int right = 0; right < s.Length; right++)
        {
            char c = s[right];
            if (map.ContainsKey(c) && map[c] >= left)
            {
                left = map[c] + 1;
            }

            map[c] = right;
            max = Math.Max(max, right-left + 1);
        }

        return max;
        
    }
}
