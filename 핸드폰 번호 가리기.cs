public class Solution {
    public string solution(string phone_number) {
        string answer = "";
        
        int strLength = phone_number.Length;

        for (int i = 1; i <= phone_number.Length; i++)
        {
            if (strLength - i >= 4)
            {
                answer += '*';
            }
            else
            {
                answer += phone_number[i - 1];
            }
        }
        
        return answer;
    }
}