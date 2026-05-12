public class Solution {
public List<List<string>> GroupAnagrams(string[] strs)
{
    var map = new Dictionary<string, List<string>>();

    foreach (string str in strs) 
    {
        int[] count = new int[26];
        foreach (var c in str)
        {
            count[c - 'a']++;
        }
        var key = string.Join(",", count);
        if (!map.ContainsKey(key))
        {
            map[key] = new List<string>();
        }
        map[key].Add(str);
    }

    return map.Values.ToList();
}
}
