using System;

public class Solution {
    public int solution(int n) {
        
        int x;

        int min = int.MaxValue;

        for (x = 1; x <= n; x++)
        {

            if (n % x == 1)
            {

                if (x < min)
                {
                    min = x;
                }

            }

        }


        return min;
        
        
        
        //int answer = 0;
        //return answer;
    }
}