public class Solution {
    public int solution(int n) {

        int divisorSum = 0;

        for(int divisor = 1; divisor <= n; divisor++)
        {
            if (n % divisor == 0)
            {
                divisorSum += divisor;
            }
        }

        return divisorSum;
        
        
        //int answer = 0;
        //return answer;
    }
}