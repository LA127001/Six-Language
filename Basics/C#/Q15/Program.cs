using System;

class Program{
     static bool isPrime(int num){
          for(int i = 2; i * i <= num; i++){
               if(num % i == 0) return false;
          }
          return true;
     }
     static void Main(){
         Console.WriteLine("Enter the number: ");
         int num = Convert.ToInt32(Console.ReadLine());

         if(isPrime(num))Console.WriteLine("Prime");
         else Console.WriteLine("Not Prime");
         
     }
}