public class Solution {
    public bool IsAnagram(string s, string t) 
    {
        var sA = s.ToCharArray();
        var tA = t.ToCharArray();
        Array.Sort(sA);
        Array.Sort(tA);
        return new string(sA) == new string(tA);
    }
}