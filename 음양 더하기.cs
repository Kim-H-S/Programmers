using System;

public class Solution {
    public int solution(int[] absolutes, bool[] signs) {
        
        int sum = 0;

        for (int i = 0; i < absolutes.Length; i++)
        {
            if (signs[i] == false)
            {
                sum += absolutes[i] * -1;
            }
            else
            {
                sum += absolutes[i];
            }
        }

        return sum;
        
        //int answer = 123456789;
        //return answer;
    }
}