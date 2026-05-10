public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            var val = target -  nums[i];
            if (map.ContainsKey(val))
            {
                return new int[] {map[val], i};
            }

            map[nums[i]] = i;
 
        }

        return Array.Empty<int>();
    }
}
