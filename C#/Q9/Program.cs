using System;

class Program
{
     static void Main()
     {

          Console.WriteLine("Enter the number: ");
          int num1 = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Enter the another number: ");
          int num2 = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Enter the operator: ");
          string opert = Console.ReadLine();


          switch (opert)
          {
               case "+": Console.WriteLine($"Addition: {num1 + num2}"); break;
               case "-": Console.WriteLine($"Subtraction: {num1 - num2}"); break;
               case "*": Console.WriteLine($"Multiply: {num1 * num2}"); break;
               case "/": Console.WriteLine($"Divide: {num1 / num2}"); break;
               default:
                    Console.WriteLine("Invalid");
                    break;
          }
     }
}
