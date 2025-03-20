using System;

public class Solution {
    public int solution(int num1, int num2) {
        float result=(float)num1/(float)num2;
        float answer = result*1000;
        return (int)answer;
    }
}