using System;

public class Solution {
    public int solution(int[] numbers) {
        //int answer = -1;
        //return answer;
        
        int sum = 0;

        for (int i = 0; i <= 9; i++)
        {
            sum += i;
        }




        for (int i = 0; i < numbers.Length; i++)
        {
            sum -= numbers[i];
        }

        return sum;
    }
}