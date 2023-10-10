public class Solution {
    
   
    
    public int[] solution(int n, int m) {
        //int[] answer = new int[] {};
        int[] answer = new int[2];

        int min = n;
        int max = m;

        int a = min;

        while(true)
        {
            a = max % min;
            max = min;

            if(a == 0) 
            {
                break;
            }

            min = a;
        }

        answer = new int[] { min, n * m / min };
        
        return answer;
    }
}