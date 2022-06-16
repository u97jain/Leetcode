class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        count = {}
        for i in range(len(nums)):
            count[nums[i]] = 1 + count.get(nums[i], 0)
        countDict = {k: v for k, v in sorted(count.items(), key=lambda item: item[1])}
        #print(countDict)
        countList = list(countDict.keys())
        result = countList[-k:]
        return(result)