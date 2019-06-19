public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> map = new Dictionary<int, int>();
        for(int i=0; i<nums.Length; i++){
            if(map.TryGetValue(target-nums[i], out int idx)) return new [] {idx, i};
            map[nums[i]] = i; 
        }
        return new [] {0, 0};
    }
}