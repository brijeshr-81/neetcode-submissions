public class Solution {

    public string Encode(IList<string> strs) {
        StringBuilder sb = new StringBuilder(); 
        foreach (string str in strs)
        {
            sb.Append(str.Length);
            sb.Append("#");
            sb.Append(str);
        }

        return sb.ToString();
    }

    public List<string> Decode(string s) {
        List<string> list = new List<string>(); 
        int i = 0;
        while (i < s.Length)
        {
            int j = i;
            while (s[j] != '#')
            {
                j++;
            }

            var length = int.Parse(s.Substring(i, j-i));
            j++;

            var word = s.Substring(j, length);
            list.Add(word);
            i = j+ length;
        }

        return list;
   }
}
