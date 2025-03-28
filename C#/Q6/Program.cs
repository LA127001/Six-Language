using System;
class Program
{
     static void Main()
     {
          Console.WriteLine("Enter the age: ");
          int age = Convert.ToInt32(Console.ReadLine());

          if (age >= 18) Console.WriteLine("Vote");
          else Console.WriteLine("No Vote");
     }
}