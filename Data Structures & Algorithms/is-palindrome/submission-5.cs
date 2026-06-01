public class Solution {
    public bool IsPalindrome(string s) {
        bool result=true;
        s=s.ToLower();
        s = new string(s.Where(char.IsLetterOrDigit).ToArray());
        if(s.Length==1){
            return true;
        }
        char[] charArray = s.ToCharArray();
        for(int i=0; i<s.Length/2;i++){
            if(charArray[i]==charArray[(s.Length-1)-i]){            
             result =true;
            }
            else{
                return false;
            }
        }
        return result;
    }
}
