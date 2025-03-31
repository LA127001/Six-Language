using System;

class Program
{
     static void Main()
     {
          Console.WriteLine("Enter the number: ");
          int num = Convert.ToInt32(Console.ReadLine());

          int zero = 0, one = 1, next;

          for (int i = 2; i <= num; i++)
          {
               next = zero + one;
               Console.Write($"{next} ");
          one = zero;
          zero = next;
     }
}
}