public class Solution {
    public int solution(long num) {
        int answer = 0;
        
        while (num != 1) 
        {
    

            if (500 <= answer)
                return -1;

            // 짝수라면
            if (num % 2 == 0)
            {
                num = num / 2;

            }
            // 홀수라면
            else
            {
                num = (num * 3) + 1;
            }

            answer++;
        }

        if (num == 1)
            return answer;
        
        return answer;
    }
}