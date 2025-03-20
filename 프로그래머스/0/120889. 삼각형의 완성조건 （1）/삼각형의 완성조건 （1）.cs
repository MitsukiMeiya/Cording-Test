using System;

public class Solution {
    public int solution(int[] sides) {
        int max=int.MinValue;
        int sum=0;
        int answer = 0;
        
        for (int i=0;i<sides.Length;i++){
            sum+=sides[i];
        }
        
        for (int i=0;i<sides.Length;i++){
            if(sides[i]>max){
                max=sides[i];
            }
        }
        
        if(max<(sum-max)){
            answer=1;
        }else{
            answer=2;
        }
        return answer;
    }
}