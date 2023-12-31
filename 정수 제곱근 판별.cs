using System;

public class Solution {
    public long solution(long n) {
        long answer = 0;
        
        double sqrt = Math.Sqrt(n);

        if(sqrt % 1 == 0)
        {
            answer = (long)Math.Pow(sqrt + 1, 2);
        }
        else
        {
            answer = -1;
        }
        
        return answer;
    }
}