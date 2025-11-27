using System;

public class ImplicitExplicitOperatorPart2
{
    public static void Main()
    {
        LinkedList sentence = "The cake is a lie";

        Console.WriteLine(sentence);
    }
}

public class LinkedList
{
    public Node first = null;
    public static int nodecount = 0;

    public static implicit operator LinkedList(string nodesentence)
    {
        LinkedList tempLL = new LinkedList();
        foreach (string word in nodesentence.Split(' '))
        {
            tempLL.AddNode(word);
        }
        return tempLL;
    }

    public void AddNode(string val)
    {
        this.first = new Node(val, this.first);
        nodecount++;
    }

    public override string ToString()
    {
        if (this.first == null)
        {
            return "(empty list)";
        }

        string result = "";
        Node current = this.first;
        while (current != null)
        {
            result = current.value + " " + result;
            current = current.next;
        }
        return result;
    }

    public class Node
    {
        public string value;
        public Node next = null;

        public Node(string val, Node nxt)
        {
            this.value = val;
            this.next = nxt;
        }
    }
}