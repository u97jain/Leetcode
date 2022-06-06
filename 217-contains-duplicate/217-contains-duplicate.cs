public class Solution {
    public bool ContainsDuplicate(int[] nums) 
    {
        var hSet = nums.ToHashSet();
        
		return hSet.Count != nums.Length; 
    }
}