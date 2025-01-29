public class Solution {

    static int CountWays(int n, int[] mem){
        if(n <= 1){
            return 1;
        }
        if(mem[n] != -1) return mem[n];

        return mem[n] = CountWays(n - 1, mem) + CountWays(n - 2, mem);;
    }
    public int ClimbStairs(int n) {
        //Fibonacci sequence after adding one to input

        int[] mem = new int[n + 1];
        Array.Fill(mem, -1);
        return CountWays(n, mem);
        
    }
}