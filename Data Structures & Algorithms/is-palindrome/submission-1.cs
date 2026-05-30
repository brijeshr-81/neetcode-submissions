public class Solution {
    public bool IsPalindrome(string s) {
        var strArray = s.ToLower().ToCharArray();

        var left = 0;
        var right = strArray.Length - 1;

        while (left < right)
        {
            while (left < right && !char.IsLetterOrDigit(s[left]))
            {
                left++;
            }

            while (left < right &&!char.IsLetterOrDigit(s[right]))
            {
                right--;
            }

            if (strArray[left] != strArray[right])
            {
                return false;
            }
            

            left++;
            right--;
        }

        return true;

    }
}
