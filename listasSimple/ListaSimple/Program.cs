namespace ListaSimple
{
  class Program
  {
    public static void Main(string[] args)
    {
      SimpleNodeList list = new();

      list.AddToStart(3);
      list.AddToStart(5);
      list.AddToStart(7);

      list.ShowList();
    }
  }

  public class Node
  {
    public int Value;
    public Node? NextNode;

    public Node(int value)
    {
      Value = value;
      NextNode = null;
    }
  }

  public class SimpleNodeList
  {
    public Node? Head = null;

    // Add new node at the start of the list
    public void AddToStart(int value)
    {
      Node newNode = new(value)
      {
        NextNode = Head
      };
      Head = newNode;

    }

    public void ShowList()
    {
      Node? current = Head;

      Console.WriteLine("List: ");

      while (current != null)
      {
        Console.WriteLine(current.Value);
        current = current.NextNode;
      }

      Console.WriteLine("-------");
    }
  }
}

