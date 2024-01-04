using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        //Implement the data structure dynamic doubly linked list...
        DoublyLinkedList<int> list = new DoublyLinkedList<int>();
        list.Add(1);
        list.Add(32);
        list.Add(999);
        list.Remove(32);
        list.Insert(1, 7); 
        Print(list);
    }

    static void Print(DoublyLinkedList<int> list)
    {
        if (list.Count == 0)
        {
            Console.WriteLine("List is empty, like the amount of friends you have.");
            return;
        }

        int[] array = list.ToArray();
        for (int i = 0; i < list.Count; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }

}


public class DoubleLinkedListNode<T> //Literally copy and paste from here
{
    public DoubleLinkedListNode<T> Previous { get; set; }
    public DoubleLinkedListNode<T> Next { get; set; }
    public T Value { get; set; }

    public DoubleLinkedListNode(T value)
    {
        Value = value;
    }
}

public class DoublyLinkedList<T>
{
    private DoubleLinkedListNode<T> head;
    private DoubleLinkedListNode<T> tail;

    public int Count { get; private set; }

    public void Add(T value)
    {
        var newNode = new DoubleLinkedListNode<T>(value);

        if (head == null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            tail.Next = newNode;
            newNode.Previous = tail;
            tail = newNode;
        }

        Count++;
    }

    public void Insert(int index, T value)
    {
        if (index < 0 || index > Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        var newNode = new DoubleLinkedListNode<T>(value);

        if (index == 0)
        {
            newNode.Next = head;
            if (head != null)
            {
                head.Previous = newNode;
            }
            head = newNode;
            if (tail == null)
            {
                tail = newNode;
            }
        }
        else if (index == Count)
        {
            tail.Next = newNode;
            newNode.Previous = tail;
            tail = newNode;
        }
        else
        {
            var current = GetNodeAtIndex(index);
            var previous = current.Previous;

            previous.Next = newNode;
            newNode.Previous = previous;

            newNode.Next = current;
            current.Previous = newNode;
        }

        Count++;
    }

    public bool Remove(T value)
    {
        var current = head;
        while (current != null)
        {
            if (EqualityComparer<T>.Default.Equals(current.Value, value))
            {
                RemoveNode(current);
                return true;
            }
            current = current.Next;
        }
        return false;
    }

    public T GetElementAtIndex(int index)
    {
        if (index < 0 || index >= Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        return GetNodeAtIndex(index).Value;
    }

    public T[] ToArray()
    {
        var array = new T[Count];
        var current = head;
        for (int i = 0; i < Count; i++)
        {
            array[i] = current.Value;
            current = current.Next;
        }
        return array;
    }

    private DoubleLinkedListNode<T> GetNodeAtIndex(int index)
    {
        var current = head;
        for (int i = 0; i < index; i++)
        {
            current = current.Next;
        }
        return current;
    }

    private void RemoveNode(DoubleLinkedListNode<T> node)
    {
        if (node.Previous == null)
        {
            head = node.Next;
        }
        else
        {
            node.Previous.Next = node.Next;
        }

        if (node.Next == null)
        {
            tail = node.Previous;
        }
        else
        {
            node.Next.Previous = node.Previous;
        }

        Count--;
    }
}
