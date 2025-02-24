public class Solution {
    public void WallsAndGates(int[][] rooms) {
        // -1 = wall or obstacle
        // 0 is gate
        // INF means empty room represented as 2147483647
        int empty = 2147483647;
        int m = rooms.Length;
        if (m == 0) return;
        int n = rooms[0].Length;

        int distance = 0;
        var directions = new (int, int)[] {(1,0), (-1,0), (0,1), (0,-1)};

        var q = new Queue<(int,int)>();

        for(int row = 0; row < m; row++){
            for(int col = 0; col < n; col++){
                if(rooms[row][col] == 0){
                    q.Enqueue((row,col));
                }
            }
        }
        
        while(q.Count > 0){
            distance++;
            var qLen = q.Count;
            for(int level = 0; level < qLen; level++){
                var curNode = q.Dequeue();
                foreach(var dir in directions){
                    var newR = dir.Item1 + curNode.Item1;
                    var newC = dir.Item2 + curNode.Item2;

                    if(newR >= 0 && newR < m && newC >= 0 && newC < n && rooms[newR][newC] != -1 && rooms[newR][newC] == empty) {
                        rooms[newR][newC] = distance;
                        q.Enqueue((newR, newC));
                    }
                }
            }
        }
    }
}