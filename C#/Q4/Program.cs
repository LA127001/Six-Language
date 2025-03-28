using System;
class Program
{
     static void Main()
     {
          Console.WriteLine("Enter the number: ");
          int num = Convert.ToInt32(Console.ReadLine());

          if (num > 0) Console.WriteLine("Positive");
          else if (num < 0) Console.WriteLine("Negative");
          else Console.WriteLine("Zero");
     }
}