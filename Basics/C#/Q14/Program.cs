using System;

class Program{

     static double sum (double num1, double num2){
          return num1 + num2;
     }
     static double sub (double num1, double num2){
          return num1 - num2;
     }

     static double mul (double num1, double num2){
          return num1 * num2;
     }

     static double div (double num1, double num2){
          return num1 / num2;
     }
     static void Main(){
          Console.WriteLine("Enter the number: ");
          double num1 = Convert.ToDouble(Console.ReadLine());
          Console.WriteLine("Enter the another number: ");
          double num2 = Convert.ToDouble(Console.ReadLine());

          Console.WriteLine($"Addition: {sum(num1,num2)}");
          Console.WriteLine($"Subtraction: {sub(num1,num2)}");
          Console.WriteLine($"Multiply: {mul(num1,num2)}");
          Console.WriteLine($"Divide: {div(num1,num2)}");
     }
}