public class Solution {
    public long[] solution(int x, int n) {
        
        long[] answer = new long[n];

        for (int i = 0; i < n; i++)
        {
            //x[i] = x * (i + 1);
           answer[i] = (long)x * (i + 1);
        }

        return answer;
        
        
        //long[] answer = new long[] {};
        //return answer;
    }
}