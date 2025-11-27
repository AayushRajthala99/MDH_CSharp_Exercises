using System;

public class LinkedListWithStrings
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

    public void AddNode(string val)
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

    public void RemoveNode(string val)
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

    public void ReplaceWord(string oldWord, string newWord)
    {
        Node current = this.first;
        while (current != null)
        {
            if (current.value == oldWord)
            {
                current.value = newWord;
                Console.WriteLine($"Word '{oldWord}' replaced with '{newWord}'.\n");
                return;
            }
            current = current.next;
        }
        Console.WriteLine($"Word '{oldWord}' not found.\n");
    }

    public void AddLast(string val)
    {
        if (this.first == null)
        {
            this.first = new Node(val, null);
        }
        else
        {
            Node current = this.first;
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = new Node(val, null);
        }
        nodecount++;
        Console.WriteLine($"Word '{val}' added to the end.\n");
    }

    public void AddAfter(string targetWord, string newWord)
    {
        Node current = this.first;
        while (current != null)
        {
            if (current.value == targetWord)
            {
                current.next = new Node(newWord, current.next);
                nodecount++;
                Console.WriteLine($"Word '{newWord}' added after '{targetWord}'.\n");
                return;
            }
            current = current.next;
        }
        Console.WriteLine($"Word '{targetWord}' not found.\n");
    }

    public void AddBefore(string targetWord, string newWord)
    {
        if (this.first == null)
        {
            Console.WriteLine("List is empty.\n");
            return;
        }

        if (this.first.value == targetWord)
        {
            this.first = new Node(newWord, this.first);
            nodecount++;
            Console.WriteLine($"Word '{newWord}' added before '{targetWord}'.\n");
            return;
        }

        Node current = this.first;
        while (current.next != null)
        {
            if (current.next.value == targetWord)
            {
                current.next = new Node(newWord, current.next);
                nodecount++;
                Console.WriteLine($"Word '{newWord}' added before '{targetWord}'.\n");
                return;
            }
            current = current.next;
        }
        Console.WriteLine($"Word '{targetWord}' not found.\n");
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
            result += current.value;
            if (current.next != null)
            {
                result += " ";
            }
            current = current.next;
        }
        return result;
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
        public string value;
        public Node next = null;

        public Node(string val, Node nxt)
        {
            this.value = val;
            this.next = nxt;
        }
    }

    public static void ChoiceBanner(LinkedList LL)
    {
        Console.WriteLine("\nSelect Your Operation!");
        Console.WriteLine("1. Add Word (to beginning)");
        Console.WriteLine("2. Add Word (to end)");
        Console.WriteLine("3. Get Word by Index");
        Console.WriteLine("4. Replace Word");
        Console.WriteLine("5. Remove Word");
        Console.WriteLine("6. Add Word After Another");
        Console.WriteLine("7. Add Word Before Another");
        Console.WriteLine("8. Display Full List");
        Console.WriteLine("9. Display as Sentence");
        Console.WriteLine("10. Exit");
        Console.Write("\nEnter Choice: ");
        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                Console.Write("Enter word to add: ");
                string valToAdd = Console.ReadLine();
                LL.AddNode(valToAdd);
                Console.WriteLine($"Word '{valToAdd}' added to the beginning.\n");
                break;
            case "2":
                Console.Write("Enter word to add: ");
                string valToAddLast = Console.ReadLine();
                LL.AddLast(valToAddLast);
                break;
            case "3":
                Console.Write("Enter the index of the word to get: ");
                int indexOfNode = int.Parse(Console.ReadLine());
                LL.GetNode(indexOfNode);
                break;
            case "4":
                Console.Write("Enter the word to replace: ");
                string oldWord = Console.ReadLine();
                Console.Write("Enter the new word: ");
                string newWord = Console.ReadLine();
                LL.ReplaceWord(oldWord, newWord);
                break;
            case "5":
                Console.Write("Enter the word to remove: ");
                string valueToRemove = Console.ReadLine();
                LL.RemoveNode(valueToRemove);
                break;
            case "6":
                Console.Write("Enter the word to add after: ");
                string afterWord = Console.ReadLine();
                Console.Write("Enter the new word: ");
                string wordToAddAfter = Console.ReadLine();
                LL.AddAfter(afterWord, wordToAddAfter);
                break;
            case "7":
                Console.Write("Enter the word to add before: ");
                string beforeWord = Console.ReadLine();
                Console.Write("Enter the new word: ");
                string wordToAddBefore = Console.ReadLine();
                LL.AddBefore(beforeWord, wordToAddBefore);
                break;
            case "8":
                LL.DisplayList();
                break;
            case "9":
                Console.WriteLine($"\nSentence: {LL.ToString()}\n");
                break;
            case "10":
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;
        }
    }
}