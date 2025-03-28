using System;
class Program
{
     static void Main()
     {
          Console.WriteLine("Enter the temperature: ");
          int temp = Convert.ToInt32(Console.ReadLine());

          if (temp > 30) Console.WriteLine("It's very hot!");
          else if (temp > 10 && temp < 30) Console.WriteLine("The Weather is pleasant");
          else Console.WriteLine("It's very cold!");
     }
}