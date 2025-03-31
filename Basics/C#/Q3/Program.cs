using System;

class Program{
     static void Main(){
          int num = 2323;
          bool isEven = num%2 == 0;

          Console.WriteLine($"The number is {num} it is {(isEven ? "Even" : "Odd")}");
     }
}