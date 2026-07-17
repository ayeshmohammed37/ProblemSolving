public partial class Solution {
    public bool ContainsDuplicate(int[] nums) {
        Dictionary<int, bool> dict = new Dictionary<int, bool>();

        for (int i = 0; i < nums.Length; i++) {
            if (dict.ContainsKey(nums[i])) {
                return true;
            }
            else {
                dict[nums[i]] = true;
            }
        }

        return false;
    }
}