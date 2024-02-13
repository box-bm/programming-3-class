namespace OperacionesMatematicas
{
  /// <summary>
  /// Represents the main program class.
  /// </summary>
  internal class Program
  {
    /// <summary>
    /// The entry point for the application.
    /// </summary>
    /// <param name="args">The command-line arguments.</param>
    static void Main(string[] args)
    {
      Console.WriteLine("Ingresa una operacion matemática");
      string input = Console.ReadLine() ?? "";

      if (string.IsNullOrEmpty(input))
      {
        Console.WriteLine("No hay entrada");
        return;
      }

      input = input.Replace(" ", "");

      try
      {
        if (!ValidateAritmethicOperaction(input))
        {
          Console.WriteLine("La entrada no es valida");
          return;
        };

        Console.WriteLine("La entrada es correcta");
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
      }

    }

    /// <summary>
    /// This method validates an arithmetic operation given an input string and returns a boolean value.
    /// </summary>
    /// <param name="input">The input string representing the arithmetic operation.</param>
    /// <returns>True if the arithmetic operation is valid; otherwise, false.</returns>
    static bool ValidateAritmethicOperaction(string input)
    {
      bool validateOpenClosed = ValidateOpenClosed(input);

      return validateOpenClosed;
    }

    /// <summary>
    /// Validates the open and closed characters in the input string and returns a boolean value.
    /// </summary>
    /// <param name="input">The input string to validate.</param>
    /// <returns>True if the open and closed characters are balanced; otherwise, false.</returns>
    static bool ValidateOpenClosed(string input)
    {
      Stack<char> openClosedCharStack = new();

      foreach (char character in input)
      {
        if (openClosedCharStack.Count == 0 && IsClosedChar(character))
        {
          throw new ArgumentException("La entrada no es valida");
        }

        if (IsOpenChar(character))
        {
          openClosedCharStack.Push(character);
          continue;
        }

        if (IsClosedChar(character))
        {
          if (IsOpenClosed(openClosedCharStack.Peek(), character))
          {
            openClosedCharStack.Pop();
            continue;
          }
        }
      }

      return openClosedCharStack.Count == 0;
    }

    /// <summary>
    /// Checks if the character is an open character.
    /// </summary>
    /// <param name="c">the evaluated character</param>
    /// <returns>True if the character is an open character; otherwise, false.</returns>
    static bool IsOpenChar(char c)
    {
      return c == '(' || c == '{' || c == '[';
    }

    /// <summary>
    /// Checks if the character is a closed character.
    /// </summary>
    /// <param name="c"The evaluated character></param>
    /// <returns>True if the character is a closed character; otherwise, false.</returns>
    static bool IsClosedChar(char c)
    {
      return c == ')' || c == '}' || c == ']';
    }


    /// <summary>
    /// Checks if the open and closed characters are balanced.
    /// </summary>
    /// <param name="c1">open character</param>
    /// <param name="c2"closed character></param>
    /// <returns>True if the open and closed characters are balanced; otherwise, false.</returns>
    static bool IsOpenClosed(char c1, char c2)
    {
      if (!((c1 == '(' && c2 == ')') || (c1 == '{' && c2 == '}') || (c1 == '[' && c2 == ']')))
      {
        throw new ArgumentException("No esta balanceado en la apertura: " + c1 + " y el cierre: " + c2);
      }

      return true;
    }
  }
}