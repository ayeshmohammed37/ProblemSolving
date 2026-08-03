namespace LeetCode;

public partial class Solution
{
    public int[] GetConcatenation(int[] nums)
    {
        int n = nums.Length;
        int[] ans = new int[n * 2];

        for (int i = 0; i < n * 2; i++)
        {
            ans[i] = i >= n ? nums[i - n] : nums[i];
        }
        return ans;
    }
}