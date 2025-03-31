using System;

class Program
{
     static void Main()
     {
          Console.WriteLine("************** Welcome to the Programmer Journey **************");

          Console.WriteLine("Enter the name: ");
          string name = Console.ReadLine();
          Console.WriteLine("Enter the age: ");
          int age = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Enter the city: ");
          string city = Console.ReadLine();

          Console.WriteLine("\n********** User Details **********\n");

          Console.WriteLine($"Your Name is : {name}");
          Console.WriteLine($"Your Age is  : {age}");
          Console.WriteLine($"Your City is : {city}");


     }
}