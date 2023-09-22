public class Solution {
    public string solution(int n) {
        string answer = "";


        for (int i = 1; i <= n; i++)
        {
            // 홀수이면 문자열 뒤에 '수'를 붙인다.
            if (i % 2 == 1)
            {
                answer += '수';
            }
            // 짝수이면 문자열 뒤에 '박'를 붙인다.
            else if (i % 2 == 0)
            {
                answer += '박';
            }
    
        }
        
        return answer;
    }
}