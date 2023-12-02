using System;

public class Program
{
    public static void Main()
    {
        DynamicLinkedList list = new DynamicLinkedList();
        list.Add(3);
        list.Add(77);
        list.Add(55);
        list.BubbleSort();
    }
}
public class Node
{
    public int Value { get; set; }
    public Node Next { get; set; }

    public Node(int value)
    {
        Value = value;
        Next = null;
    }
}

public class DynamicLinkedList
{
    private Node head;

    public DynamicLinkedList()
    {
        head = null;
    }

    public void Add(int value)
    {
        Node newNode = new Node(value);

        if (head == null)
        {
            head = newNode;
        }
        else
        {
            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = newNode;
        }
    }

    public void BubbleSort()
    {
        if (head == null)
        {
            return;
        }

        bool swapped;
        Node current;
        Node lastNode = null;

        do
        {
            swapped = false;
            current = head;

            while (current.Next != lastNode)
            {
                if (current.Value > current.Next.Value)
                {
                    Swap(current, current.Next);
                    swapped = true;
                }

                current = current.Next;
            }

            lastNode = current;
        } while (swapped);
    }

    private void Swap(Node node1, Node node2)
    {
        int temp = node1.Value;
        node1.Value = node2.Value;
        node2.Value = temp;
    }

    public void PrintList()
    {
        Node current = head;

        while (current != null)
        {
            Console.Write(current.Value + " ");
            current = current.Next;
        }

        Console.WriteLine();
    }
}
