public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> mapDict = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) {
            int complement = target - nums[i];
            if (mapDict.ContainsKey(complement)) {
                return new int[] { mapDict[complement], i };
            }
            if (!mapDict.ContainsKey(nums[i])) {
                mapDict.Add(nums[i], i);
            }
        }
        return Array.Empty<int>();
    }
}
