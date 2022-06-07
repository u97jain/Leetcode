public class Solution {
    public int[] TwoSum(int[] nums, int target) 
    {
        /*
         prevMap = {} # val -> index
        
        for i, n in enumerate(nums):
            diff = target - n
            if diff in prevMap:
                return [prevMap[diff], i]
            prevMap[n] = i
        */
        
        Dictionary<int,int> prevMap = new Dictionary<int,int>();
        int[] result = new int[2];
        
        for(int i=0; i<nums.Length; i++)
        {
            if(prevMap.ContainsKey(target-nums[i]))
            {
                result[0] = prevMap[target-nums[i]];
                result[1] = i;
                return result;
            }
            else if(!prevMap.ContainsKey(nums[i]))
                prevMap.Add(nums[i],i);
        }
        
        return result;
        
        /*
        Dictionary<int,int> dict = new Dictionary<int,int>();
        int[] result=new int[2];
        
        for(int i=0;i<nums.Length;i++)
        {
            if(dict.ContainsKey(target - nums[i]) )
            {
                result[0]=dict[target-nums[i]];
                result[1]=i;
                return result;
            }
            else if(!dict.ContainsKey(nums[i]))
                dict.Add(nums[i],i);
        }
        return result;
    }
        */
    }
}