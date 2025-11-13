using System;

public class LinkedListWithIntegers
{
    public static void Main()
    {
        LinkedList LL = new LinkedList();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("\n---LinkedList Explorer---");
            Console.WriteLine($"Current Number of Nodes : {LinkedList.nodecount}");
            LinkedList.ChoiceBanner(LL);
        }
    }
}

public class LinkedList
{
    public Node first = null;
    public static int nodecount = 0;

    public void AddNode(int val)
    {
        this.first = new Node(val, this.first);
        nodecount++;
    }

    public void GetNode(int index)
    {
        if (index < 0 || index >= nodecount)
        {
            Console.WriteLine("Index out of bounds.\n");
            return;
        }

        Node current = this.first;
        for (int i = 0; i < index; i++)
        {
            current = current.next;
        }
        Console.WriteLine($"Node at index {index} has value: {current.value}\n");
    }

    public void RemoveNode(int val)
    {
        Node current = this.first;
        Node previous = null;

        while (current != null)
        {
            if (current.value == val)
            {
                if (previous == null)
                {
                    this.first = current.next;
                }
                else
                {
                    previous.next = current.next;
                }
                nodecount--;
                Console.WriteLine($"Node with value {val} removed.\n");
                return;
            }
            previous = current;
            current = current.next;
        }
        Console.WriteLine($"Node with value {val} not found.\n");
    }

    public void DisplayList()
    {
        Node current = this.first;
        Console.Write("\nLinkedList Items: ");
        while (current != null)
        {
            Console.Write(current.value + " -> ");
            current = current.next;
        }
        Console.WriteLine("null");
    }

    public class Node
    {
        public int value;
        public Node next = null;

        public Node(int val, Node nxt)
        {
            this.value = val;
            this.next = nxt;
        }
    }

    public static void ChoiceBanner(LinkedList LL)
    {
        Console.WriteLine("\nSelect Your Operation!");
        Console.WriteLine("1. Add Node");
        Console.WriteLine("2. Get Node");
        Console.WriteLine("3. Remove Node");
        Console.WriteLine("4. Display Full List");
        Console.WriteLine("5. Exit");
        Console.Write("\nEnter Choice: ");
        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                Console.Write("Enter value to add: ");
                int valToAdd = int.Parse(Console.ReadLine());
                LL.AddNode(valToAdd);
                Console.WriteLine($"Node with value {valToAdd} added.\n");
                break;
            case "2":
                Console.Write("Enter the index of the node to get : ");
                int indexOfNode = int.Parse(Console.ReadLine());
                LL.GetNode(indexOfNode);
                break;
            case "3":
                Console.Write("Enter the value to remove from the LinkedList : ");
                int valueToRemove = int.Parse(Console.ReadLine());
                LL.RemoveNode(valueToRemove);
                break;
            case "4":
                LL.DisplayList();
                break;
            case "5":
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }
}