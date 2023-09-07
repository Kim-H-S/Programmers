public class Solution {
    public bool solution(int x) {
        bool answer = true;

        char[] charArr = x.ToString().ToCharArray();

        // 자릿수 합
        int sum = 0;

        for (int i = 0; i < charArr.Length; i++)
        {
            sum += charArr[i] - '0';
        }

        int number = int.Parse(charArr);

        if (number % sum == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
        //return answer;
    }
}