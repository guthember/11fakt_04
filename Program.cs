using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
  class Program
  {
    static void Main(string[] args)
    {
      int a;
      int b;

      Console.Write("First number: ");
      a = Convert.ToInt32( Console.ReadLine());

      Console.Write("Second number: ");
      b = Convert.ToInt32(Console.ReadLine());
      
      Console.WriteLine(a + "+" + b + "=" + (a + b));
      Console.WriteLine(a + "-" + b + "=" + (a - b));
      Console.WriteLine(a + "*" + b + "=" + (a * b));

      Console.ReadKey();
    }
  }
}
