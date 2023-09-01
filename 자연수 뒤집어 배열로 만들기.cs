using System;

public class Solution {
    public int[] solution(long n) {
        
    // long -> str -> str[i]
    // 문자열 하나씩 배열 원소로 넣는다.

    string str = n.ToString();

    int[] arr = new int[str.Length];

    for (int i = 0; i < str.Length; i++)
    {
        arr[i] = Int32.Parse(str[i].ToString());
    }

    Array.Reverse(arr);

    return arr;
        
    //int[] answer = new int[] {};
    //return answer;
    }
}