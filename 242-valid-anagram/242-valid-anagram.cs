public class Solution {
    public bool IsAnagram(string s, string t) 
    {
        /*
        if len(s) != len(t):
            return False
        
        countS, countT = {}, {}
        
        for i in range(len(s)):
            countS[s[i]] = 1 + countS.get(s[i], 0)
            countT[t[i]] = 1 + countT.get(t[i], 0)
        for c in countS:
            if countS[c] != countT.get(c, 0):
                return False
        return True
        */
        
        if (s.Length != t.Length) return false;
        var dict = new Dictionary<char, int>();
        
        for(int i=0; i<s.Length; i++)
        {
            if(dict.ContainsKey(s[i]))
            {
                dict[s[i]]++;
            }
            else
            {
                dict.Add(s[i], 1);
            }
        }
        
        for(int j=0; j<t.Length; j++)
        {
            if(dict.ContainsKey(t[j]) && dict[t[j]]>0)
            {
                dict[t[j]]--;
            }
            else
            {
                return false;
            }
        }
        
        return true;
    }
}