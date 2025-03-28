using System;

class Program{
     static void Main(){
          Console.WriteLine("Enter the Temperature: ");
          int temp = Convert.ToInt32(Console.ReadLine());

          double Fahrenheit = temp * 9.0 / 5 + 32;

          Console.WriteLine($"{Fahrenheit} F");
     }
}