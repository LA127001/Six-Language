using System;

class Program{
     static void Main (){

      Console.WriteLine("Enter the number: ");
      int num = Convert.ToInt32(Console.ReadLine());
      int factorial = 1;

      for(int i = 1; i <= num; i++){
        factorial *= i;
      }
      Console.WriteLine(factorial);
     }
}
