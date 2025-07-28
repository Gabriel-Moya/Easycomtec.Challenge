public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var arr = new (int Value, int Index)[nums.Length];
        for (int i = 0; i < nums.Length; i++) {
            arr[i] = (nums[i], i);
        }

        Array.Sort(arr, (a, b) => a.Value.CompareTo(b.Value));

        int left = 0, right = nums.Length - 1;
        while (left < right) {
            int sum = arr[left].Value + arr[right].Value;
            if (sum == target) {
                return new int[] { arr[left].Index, arr[right].Index };
            }
            if (sum < target) left++;
            else right--;
        }

        return Array.Empty<int>();
    }
}
