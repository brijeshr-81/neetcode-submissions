public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        var left = 0;
        var right = numbers.Length - 1;
        while (left < right)
        {
            int currentSum = numbers[left] + numbers[right];
            {
                if (currentSum > target)
                {
                    right--;
                }

                else if (currentSum < target)
                {
                    left ++;
                }

                else
                {
                    return new int[] {left+1, right+1};
                }
            }
        }

        return new int[0];
        
    }
}
