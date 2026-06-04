public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();
        Dictionary<char,char> closeOpen = new Dictionary<char,char>{
            {')','('},
            {']','['},
            {'}','{'}
        };
        foreach(char c in s){
            if(closeOpen.ContainsKey(c)){
                if(stack.Count>0 && stack.Peek()==closeOpen[c]){
                    stack.Pop();
                }
                else return false;
            }
            else{
                stack.Push(c);
            }
        }
        return stack.Count==0;
    }
}
