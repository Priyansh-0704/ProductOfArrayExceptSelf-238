public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] ans = new int[nums.Length];
        ans[0] = 1;
        for(int i = 1; i < nums.Length; i++)
        {
            // prefix of each no. = product of all nos before it
            ans[i] = ans[i-1] * nums[i - 1];
        }
        int suffix = 1;
        for(int i = nums.Length - 2; i >= 0; i--)
        {
            // suffix of each no. = product of all nos after it
            suffix *= nums[i+1];
            ans[i] *= suffix;
        }
        return ans;
    }
}

// Here in this question we are using the prefix and suffix to calculate the product
// prefix are the elements before the current element
