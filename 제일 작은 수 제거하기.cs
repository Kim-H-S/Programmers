using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr) {
        int[] answer = new int[] {};
        
        if (arr.Length <= 1)
        {
            answer = new int[arr.Length];

            answer[0] = -1;

            return answer;
        }

        int min = int.MaxValue;

        // 가장 작은 수를 찾는다.
        for (int i = 0; i < arr.Length; i++)
        {
            if(min >= arr[i])
            {
                min = arr[i];
            }
        }

        // 가장 작은 수를 제거한다.
        answer = Array.FindAll(arr, num => num != min).ToArray();
        
        return answer;
    }
}