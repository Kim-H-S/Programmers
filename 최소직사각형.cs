using System;

public class Solution {
    public int solution(int[,] sizes) {
        int answer = 0;
        
        for (int i = 0; i < sizes.GetLength(0); i++)
        {
            int temp = 0;

            if (sizes[i, 0] < sizes[i, 1])
            {
                temp = sizes[i, 0];
                sizes[i, 0] = sizes[i, 1];
                sizes[i, 1] = temp;
            }
        }

        int max1 = 0;
        int max2 = 0;

        for (int i = 0; i < sizes.GetLength(0); i++)
        {
            if (max1 < sizes[i, 0]) max1 = sizes[i, 0];
            if (max2 < sizes[i, 1]) max2 = sizes[i, 1];
        }

        answer = max1 * max2;
        
        return answer;
    }
}