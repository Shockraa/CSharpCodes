using System;

public class Program
{
    public static void Main()
    {
        CircularQueue<int> queue = new CircularQueue<int>();

        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);

        int removedItem = queue.Dequeue();
        Console.WriteLine(removedItem); 
    }
}

public class CircularQueue<T>
{
    private const int DefaultCapacity = 4;

    private T[] array;
    private int front;
    private int rear;
    private int count;

    public CircularQueue()
    {
        array = new T[DefaultCapacity];
        front = 0;
        rear = -1;
        count = 0;
    }

    public int Count
    {
        get { return count; }
    }

    public void Enqueue(T item)
    {
        if (count == array.Length)
        {
            ResizeArray();
        }

        rear = (rear + 1) % array.Length;
        array[rear] = item;
        count++;
    }

    public T Dequeue()
    {
        if (count == 0)
        {
            throw new InvalidOperationException("Queue is empty.");
        }

        T item = array[front];
        front = (front + 1) % array.Length;
        count--;

        return item;
    }

    public T Peek()
    {
        if (count == 0)
        {
            throw new InvalidOperationException("Queue is empty.");
        }

        return array[front];
    }

    private void ResizeArray()
    {
        int newCapacity = array.Length * 2;
        T[] newArray = new T[newCapacity];

        for (int i = 0; i < count; i++)
        {
            newArray[i] = array[(front + i) % array.Length];
        }

        front = 0;
        rear = count - 1;
        array = newArray;
    }
}
