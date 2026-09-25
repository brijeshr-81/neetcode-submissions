public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char,int> map = new Dictionary<char,int>();
        if (s.Length != t.Length)
        {
            return false;
        }

        foreach(char c in s)
        {
            map[c] = map.GetValueOrDefault(c) + 1;
        }

        foreach (char c in t)
        {
            if (!map.ContainsKey(c))
            {
                return false;
            }

            map[c] --;
            if (map[c] < 0)
            {
                return false;
            }
        }
        return true;
    }
}
