public class Solution {
    public bool IsValid(string s) 
    {
        Stack<char> myStack = new Stack<char>();
        
        for(int i=0; i<s.Length;i++)
        {
            if(s[i]=='(' || s[i]=='[' || s[i]=='{')
            {
                myStack.Push(s[i]);
            }
            else
            {
                if(myStack.Count==0)
                {
                    return false;
                }
                if(s[i]==')' && myStack.Pop()=='(') continue;
                if(s[i]=='}' && myStack.Pop()=='{') continue;
                if(s[i]==']' && myStack.Pop()=='[') continue;
                return false;
            }
        }
        if(myStack.Count!=0)
        {
            return false;
        }
        return true;
    }
}