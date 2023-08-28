using System;

public class Solution {
    public int solution(int n) {
        
        // 자연수 N을 문자열로 바꾼다.
        string input = n.ToString();

        // 문자열의 처음부터 끝까지 수를 더한다.
        int sum = 0;
    
        for (int i = 0; i < input.Length; i++)
        {
            // '1' -> 49
            // 아스키 코드로 인식한다.
            sum += (input[i] - 48);
        }

        return sum;
        
        
        //int answer = 0;
        //return answer;
    }
}