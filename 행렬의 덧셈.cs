public class Solution {
    public int[,] solution(int[,] arr1, int[,] arr2) {
        
        for (int count1 = 0; count1 < arr1.GetLength(0); count1++)
        {
            for (int count2 = 0; count2 < arr1.GetLength(1); count2++)
            {
                arr1[count1, count2] += arr2[count1, count2];
            }
        }

        return arr1;
        
        //int[,] answer = new int[,] {{}};
        //return answer;
    }
}