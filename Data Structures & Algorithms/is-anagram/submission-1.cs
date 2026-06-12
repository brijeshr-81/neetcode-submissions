public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> dic = new Dictionary<char, int>();
        if (s.Length != t.Length)
        {
            return false;
        }

        foreach (char c in s)
        {
            dic[c] = dic.GetValueOrDefault(c) + 1;
        }

        foreach (char c in t)
        {
            if (!dic.ContainsKey(c))
            {
                return false;
            }
            dic[c] --;
            if (dic[c] < 0)
            {
                return false;
            }
        }

        return true;
    }
}
