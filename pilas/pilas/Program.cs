namespace pilas
{
  internal class Program
  {

    static void Main(string[] args)
    {
      Console.WriteLine("Ingrese una cadena con parentesis, corchetes y llaves:");
      string input = Console.ReadLine() ?? "";

      if (VerificateBalance(input) && input.Count() > 0)
      {
        Console.WriteLine("Cadena aceptada");
        return;
      }

      Console.WriteLine("Cadena rechazada");
    }

    static bool VerificateBalance(string input)
    {
      Stack<char> stack = new Stack<char>();

      foreach (char c in input)
      {
        if (IsOpenChar(c))
        {
          stack.Push(c);
        }
        else if (IsClosedChar(c))
        {
          if (IsEqualChar(stack.Peek(), c) || !(stack.Count == 0))
          {
            stack.Pop();
          }
        }
      }

      return stack.Count == 0;
    }

    static bool IsOpenChar(char c)
    {
      return c == '(' || c == '[' || c == '{';
    }

    static bool IsClosedChar(char c)
    {
      return c == ')' || c == ']' || c == '}';
    }

    static bool IsEqualChar(char first, char second)
    {
      return (first == '(' && second == ')') || (first == '[' && second == ']') || (first == '{' && second == '}');
    }
  }


}