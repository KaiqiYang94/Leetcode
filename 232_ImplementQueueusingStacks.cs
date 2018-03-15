// ToOffer_7

// Implement the following operations of a queue using stacks.

// push(x) -- Push element x to the back of queue.
// pop() -- Removes the element from in front of queue.
// peek() -- Get the front element.
// empty() -- Return whether the queue is empty.
// Notes:
// You must use only standard operations of a stack -- which means only push to top, peek/pop from top, size, and is empty operations are valid.
// Depending on your language, stack may not be supported natively. You may simulate a stack by using a list or deque (double-ended queue), as long as you use only standard operations of a stack.
// You may assume that all operations are valid (for example, no pop or peek operations will be called on an empty queue).

public class MyQueue {

    private Stack<int> stack1;
    private Stack<int> stack2;
    
    /** Initialize your data structure here. */
    public MyQueue() {
        stack1 = new Stack<int>();
        stack2 = new Stack<int>();
    }
    
    /** Push element x to the back of queue. */
    public void Push(int x) {
        Stack2ToStack1();
        stack1.Push(x);
    }
    
    /** Removes the element from in front of queue and returns that element. */
    public int Pop() {
        Stack1ToStack2();
        return stack2.Pop();
    }
    
    /** Get the front element. */
    public int Peek() {
        Stack1ToStack2();
        return stack2.Peek();
    }
    
    /** Returns whether the queue is empty. */
    public bool Empty() {
        return stack1.Count == 0 && stack2.Count == 0;
    }
    
    private void Stack1ToStack2(){
        StackToStack(stack1, stack2);
    }
    
    private void Stack2ToStack1(){
        StackToStack(stack2, stack1);
    }
    
    private void StackToStack(Stack<int> first, Stack<int> second)
    {
        while(first.Count != 0)
        {
            second.Push(first.Pop());
        }
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