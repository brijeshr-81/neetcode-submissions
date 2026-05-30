public class Solution {
    public int MaxArea(int[] heights) {
        var left = 0;
        var right = heights.Length - 1;
        var maxArea = 0;

        while (left < right)
        {
            var width = right - left;
            int currentHeight = Math.Min(heights[left], heights[right]);
            var area = width * currentHeight;
            maxArea = Math.Max(maxArea, area);
            if (heights[left] < heights[right])
            {
                left ++;
            }
            else 
            {
                right --;
            }
        }

        return maxArea;
    }
}
