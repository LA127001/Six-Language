using System;

class program
{

     static void Main()
     {

          /*
          ?Create a print 
          int[] arr = {10, 20, 30, 40,50};
          for(int i = 0; i < arr.Length; i++){
            Console.Write(arr[i] + " ");
          */

          Console.WriteLine("Enter the size of arrays: ");
          int n = Convert.ToInt32(Console.ReadLine());

          int[] arr = new int[n]; // dynamic arrays

          for (int i = 0; i < n; i++)
          {
               Console.Write($"Element {i + 1}: ");
               arr[i] = Convert.ToInt32(Console.ReadLine());
          }

          foreach (int num in arr)
          {
               Console.Write($"{num} ");
          }

          Console.Write($"\nSize of: "+ arr.Length);
     }
}

