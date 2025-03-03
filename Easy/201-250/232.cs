public class MyQueue {

    private readonly Stack<int> s1;
    private readonly Stack<int> s2;
    private int s1Front;

    public MyQueue() {
        s1 = new Stack<int>();
        s2 = new Stack<int>();
    }
    
    public void Push(int x) {
        if(s1.Count == 0) s1Front = x;
        s1.Push(x);
    }
    
    public int Pop() {
        if(s2.Count == 0){
            while(s1.Count > 0){
                s2.Push(s1.Pop());
            }
        }

        return s2.Pop();
    }
    
    public int Peek() {
        if(s2.Count > 0) return s2.Peek();

        return s1Front;
    }
    
    public bool Empty() {
        return s1.Count == 0 && s2.Count == 0;
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */