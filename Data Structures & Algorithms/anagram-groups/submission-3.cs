public class Solution {
public List<List<string>> GroupAnagrams(string[] strs)
{
    var map = new Dictionary<string, List<string>>();

    foreach (string str in strs) 
    {
        var key = new string(str.OrderBy(c => c).ToArray());
        if (!map.TryGetValue(key, out var group))
        {
            group = new List<string>();
            map[key] = group;
        }
        group.Add(str);
    }

    return map.Values.ToList();
}
}
