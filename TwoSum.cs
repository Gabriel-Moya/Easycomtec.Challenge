public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] output = [];
        for (int i = 0; i < nums.Length; i++) {
            for (int j = 0; j < nums.Length; j++) {
                if (i == j) {
                    j++;
                }
                if (nums[i] + nums[j] == target) {
                    output = [i, j];
                    break;
                }
            }
            if (output.Length == 2) {
                break;
            }
        }
        return output;
    }
}
