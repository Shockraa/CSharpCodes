using System;

public class Program
{
    public static void Main()
    {
        Deque<int> deque = new Deque<int>();
        
        deque.AddFront(1);
        deque.AddFront(3);
        deque.AddBack(2);
        deque.RemoveFront();
        deque.RemoveBack();
        deque.Clear();
    }
}

public class DequeNode<T>
{
    public T Value { get; set; }
    public DequeNode<T> Previous { get; set; }
    public DequeNode<T> Next { get; set; }

    public DequeNode(T value)
    {
        Value = value;
    }
}

public class Deque<T>
{
    private DequeNode<T> head;
    private DequeNode<T> tail;

    public int Count { get; private set; }

    public void AddFront(T value)
    {
        var newNode = new DequeNode<T>(value);

        if (head == null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            newNode.Next = head;
            head.Previous = newNode;
            head = newNode;
        }

        Count++;
    }

    public void AddBack(T value)
    {
        var newNode = new DequeNode<T>(value);

        if (tail == null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            newNode.Previous = tail;
            tail.Next = newNode;
            tail = newNode;
        }

        Count++;
    }

    public T RemoveFront()
    {
        if (head == null)
        {
            throw new InvalidOperationException("Deque is empty.");
        }

        var value = head.Value;
        head = head.Next;

        if (head != null)
        {
            head.Previous = null;
        }
        else
        {
            tail = null;
        }

        Count--;
        return value;
    }

    public T RemoveBack()
    {
        if (tail == null)
        {
            throw new InvalidOperationException("Deque is empty.");
        }

        var value = tail.Value;
        tail = tail.Previous;

        if (tail != null)
        {
            tail.Next = null;
        }
        else
        {
            head = null;
        }

        Count--;
        return value;
    }

    public T PeekFront()
    {
        if (head == null)
        {
            throw new InvalidOperationException("Deque is empty.");
        }

        return head.Value;
    }

    public T PeekBack()
    {
        if (tail == null)
        {
            throw new InvalidOperationException("Deque is empty.");
        }

        return tail.Value;
    }

    public void Clear()
    {
        head = null;
        tail = null;
        Count = 0;
    }
}
