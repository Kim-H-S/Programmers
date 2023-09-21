using System;

public class Solution {
    public string solution(string s) {
        string answer = "";
        
        int length = 0;

        if (s.Length % 2 == 0) 
        {
            // 가운데 두 글자 반환한다.
            // ex) 길이 4     4/2 = 2       2, 3 반환
            length = s.Length / 2;

            answer += s[length - 1];
            answer += s[length];

            return answer;
        }

        // 올림으로 가운데 글자 판단한다.
        // ex) 길이 5     5/2 = 2.5       2.5 -> 3
        length = (int)Math.Ceiling((double)s.Length / 2);

        answer += s[length - 1];

        return answer;
    }
}