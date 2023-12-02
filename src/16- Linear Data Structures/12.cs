using System;

public class Program
{
    public static void Main()
    {
        DynamicStack<int> stack = new DynamicStack<int>();

        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Pop();
        Console.WriteLine(stack.Count);
        stack.Clear();
        stack.Peek();
    }
}

public class StackNode<T>
{
    public T Value { get; set; }
    public StackNode<T> Previous { get; set; }

    public StackNode(T value)
    {
        Value = value;
    }
}

public class DynamicStack<T>
{
    private StackNode<T> top;

    public int Count { get; private set; }

    public void Push(T value)
    {
        var newNode = new StackNode<T>(value);
        newNode.Previous = top;
        top = newNode;
        Count++;
    }

    public T Pop()
    {
        if (top == null)
        {
            throw new InvalidOperationException("Stack is empty.");
        }

        var value = top.Value;
        top = top.Previous;
        Count--;
        return value;
    }

    public T Peek()
    {
        if (top == null)
        {
            throw new InvalidOperationException("Stack is empty.");
        }

        return top.Value;
    }

    public void Clear()
    {
        top = null;
        Count = 0;
    }
}
