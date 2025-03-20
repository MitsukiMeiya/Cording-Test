using System;

public class Solution {
    public int solution(int[] array) {
        Array.Sort(array);
        int centerIndex=array.Length/2;
        return array[centerIndex];
    }
}