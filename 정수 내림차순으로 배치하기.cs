using System;

public class Solution {
    public long solution(long n) {
        long answer = 0;
        
        char[] charArr = n.ToString().ToCharArray();

        Array.Sort(charArr);
        Array.Reverse(charArr);

        answer = long.Parse(charArr);
        
        return answer;
    }
}