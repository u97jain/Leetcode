public class Solution {
    public bool IsPalindrome(string s) 
    {
        for(int i=0, j=s.Length-1; i<j;)
        {
            var left = s[i];
            var right = s[j];
            if(!Char.IsLetterOrDigit(left))
            {
                i++;
                continue;
            }
            if(!Char.IsLetterOrDigit(right))
            {
                j--;
                continue;
            }
            if(Char.ToLower(left) != Char.ToLower(right))
            {
                return false;
            }
            
            i++;
            j--;
            
        }
        return true;
    }
}