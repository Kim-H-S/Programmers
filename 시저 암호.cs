using System;

public class Solution {
    public string solution(string s, int n) {
        string answer = "";
        
        foreach (char c in s)
        {
            if (c != ' ')
            {
                int temp = 0;

                // 아스키 코드
                // A = 65, Z = 90   a = 97, z = 122

                if ((int)c < 91)
                {
                    temp = (int)c + n;

                    if (90 < temp)
                    {
                        temp = 64 + (temp - 90);
                    }
                }
                else
                {
                    temp = (int)c + n;

                    if (122 < temp)
                    {
                        temp = 96 + (temp - 122);
                    }
                }

                answer += Convert.ToChar(temp);
            }
            else
            {
                answer += ' ';
            }
        }
        
        return answer;
    }
}