public class Solution {
    public int HIndex(int[] citations) {
        Array.Sort(citations);
        Array.Reverse(citations);

        for(int i = 0; i < citations.Length; i++){
            if(citations[i] <= i) return i;
        }

        return citations.Length;
    }
}