
namespace Colas
{
  class Program
  {
    static void Main(string[] args)
    {
      // Crea la cola
      Queue<int> cola = new Queue<int>();

      cola.Enqueue(1);

      AtrasarProcesos();

      cola.Enqueue(2);

      AtrasarProcesos();

      while (cola.Count > 0)
      {
        int elemento = cola.Dequeue();
        Console.WriteLine(elemento);
      }

    }


    /// <summary>
    /// Atrasa los procesos
    /// </summary>
    private static void AtrasarProcesos()
    {
      // Atrasa los procesos de 2 segunos.
      Console.WriteLine("Realizando procesos");
      Thread.Sleep(10000);
      Console.WriteLine("Realizando procesos");
    }
  }
}