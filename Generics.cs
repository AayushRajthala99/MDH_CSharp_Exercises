using System;

public class Generics
{
    public static void Main()
    {
        // Example with strings (original use case)
        LinkedList<string> stringList = new LinkedList<string>();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("\n---Generic LinkedList Explorer (String Mode)---");
            Console.WriteLine($"Current Number of Nodes : {stringList.Count}");
            ChoiceBanner(stringList);
        }
    }

    public static void ChoiceBanner(LinkedList<string> LL)
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
                LL.AddFirst(valToAdd);
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
                LL.Replace(oldWord, newWord);
                break;
            case "5":
                Console.Write("Enter the word to remove: ");
                string valueToRemove = Console.ReadLine();
                LL.Remove(valueToRemove);
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
        Console.Write("\nPress any key to continue...");
        Console.ReadKey();
    }
}

public class LinkedList<T>
{
    public Node<T> first = null;
    public int Count { get; private set; } = 0;

    public int Count { get; private set; } = 0;

    public void AddFirst(T val)
    {
        this.first = new Node<T>(val, this.first);
        Count++;
    }

    public void GetNode(int index)
    {
        if (index < 0 || index >= Count)
        {
            Console.WriteLine("Index out of bounds.\n");
            return;
        }

        Node<T> current = this.first;
        for (int i = 0; i < index; i++)
        {
            current = current.next;
        }
        Console.WriteLine($"Node at index {index} has value: {current.value}\n");
    }

    public void Remove(T val)
    {
        Node<T> current = this.first;
        Node<T> previous = null;

        while (current != null)
        {
            if (current.value.Equals(val))
            {
                if (previous == null)
                {
                    this.first = current.next;
                }
                else
                {
                    previous.next = current.next;
                }
                Count--;
                Console.WriteLine($"Node with value {val} removed.\n");
                return;
            }
            previous = current;
            current = current.next;
        }
        Console.WriteLine($"Node with value {val} not found.\n");
    }

    public void Replace(T oldValue, T newValue)
    {
        Node<T> current = this.first;
        while (current != null)
        {
            if (current.value.Equals(oldValue))
            {
                current.value = newValue;
                Console.WriteLine($"Value '{oldValue}' replaced with '{newValue}'.\n");
                return;
            }
            current = current.next;
        }
        Console.WriteLine($"Value '{oldValue}' not found.\n");
    }

    public void AddLast(T val)
    {
        if (this.first == null)
        {
            this.first = new Node<T>(val, null);
        }
        else
        {
            Node<T> current = this.first;
            while (current.next != null)
            {
                current = current.next;
            }
            current.next = new Node<T>(val, null);
        }
        Count++;
        Console.WriteLine($"Value '{val}' added to the end.\n");
    }

    public void AddAfter(T targetValue, T newValue)
    {
        Node<T> current = this.first;
        while (current != null)
        {
            if (current.value.Equals(targetValue))
            {
                current.next = new Node<T>(newValue, current.next);
                Count++;
                Console.WriteLine($"Value '{newValue}' added after '{targetValue}'.\n");
                return;
            }
            current = current.next;
        }
        Console.WriteLine($"Value '{targetValue}' not found.\n");
    }

    public void AddBefore(T targetValue, T newValue)
    {
        if (this.first == null)
        {
            Console.WriteLine("List is empty.\n");
            return;
        }

        if (this.first.value.Equals(targetValue))
        {
            this.first = new Node<T>(newValue, this.first);
            Count++;
            Console.WriteLine($"Value '{newValue}' added before '{targetValue}'.\n");
            return;
        }

        Node<T> current = this.first;
        while (current.next != null)
        {
            if (current.next.value.Equals(targetValue))
            {
                current.next = new Node<T>(newValue, current.next);
                Count++;
                Console.WriteLine($"Value '{newValue}' added before '{targetValue}'.\n");
                return;
            }
            current = current.next;
        }
        Console.WriteLine($"Value '{targetValue}' not found.\n");
    }

    public override string ToString()
    {
        if (this.first == null)
        {
            return "(empty list)";
        }

        string result = "";
        Node<T> current = this.first;
        while (current != null)
        {
            result += current.value.ToString();
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
        Node<T> current = this.first;
        Console.Write("\nLinkedList Items: ");
        while (current != null)
        {
            Console.Write(current.value + " -> ");
            current = current.next;
        }
        Console.WriteLine("null");
    }
}

public class Node<T>
{
    public T value;
    public Node<T> next = null;

    public Node(T val, Node<T> nxt)
    {
        this.value = val;
        this.next = nxt;
    }
}