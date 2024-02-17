using System.Collections;
using System.ComponentModel.DataAnnotations.Schema;

namespace Impresora
{
  class Program
  {
    static void Main(string[] args)
    {
      Impresora impresora = new();
      impresora.AgregarDocumento("Documento1");
      impresora.AgregarDocumento("Documento2");
      impresora.AgregarDocumento("Documento3");

      impresora.ImprimirDocumento();

      impresora.AgregarDocumento("Documento4");
      impresora.AgregarDocumento("Documento5");

      impresora.ImprimirDocumento();
      impresora.ImprimirDocumento();
      impresora.ImprimirDocumento();
      impresora.ImprimirDocumento();

      impresora.MostrarCola();
    }
  }

  class Impresora
  {
    private readonly Queue<string> cola = new();

    public void AgregarDocumento(string documento)
    {
      Console.WriteLine("Agregando documento: {0}", documento);
      cola.Enqueue(documento);
    }

    public void ImprimirDocumento()
    {
      string primerDocumento = cola.Dequeue();
      Console.WriteLine($"Imprimiendo: {primerDocumento}");
      Thread.Sleep(2000);

      Console.WriteLine($"Impreso: {primerDocumento}");
    }

    public void MostrarCola()
    {
      Console.WriteLine("Cola de impresion: ");
      int posicion = 0;
      if (cola.Count == 0)
      {
        Console.WriteLine("Cola vacia");
        return;
      }

      foreach (string documento in cola)
      {
        posicion++;
        Console.WriteLine("{0}. {1}", posicion, documento);
      }
    }
  }
}