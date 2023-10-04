public class Solution {
    public bool solution(string s) {
        //bool answer = true;
        //return answer;
        
        char[] chars = s.ToCharArray();
        int numberCount = 0;

        if (! (s.Length == 4 || s.Length == 6) )
        {
            return false;
        }

        for (int i = 0; i < s.Length; i++)
        {
            if ('0' <= chars[i] && chars[i] <= '9')
            {
                numberCount++;
            }
        }

        if ( numberCount == s.Length ) 
        {
            return true;
        }

        return false;
        
    }
}