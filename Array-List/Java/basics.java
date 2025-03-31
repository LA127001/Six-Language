
import java.util.Scanner;

class basics {

    public static void main(String[] args) {
        /*
           ?Create a print 
           int []arr = {10,20,30,40,50};
           for(int i = 0; i < arr.length; i++){
               System.out.print(arr[i]+" ");
          }
          for(int i : arr){  //? for each loop
          System.out.println(i + " ");
         */


 /* 
 ?Input a array 
 */
        Scanner sc = new Scanner(System.in);
        System.out.println("Enter size of array: ");
        int n = sc.nextInt();

        int[] arr = new int[n];

        System.out.println("Enter " + n + "elments: ");

        for (int i = 0; i < n; i++) {
            arr[i] = sc.nextInt();
        }

        System.out.print("Array elements:");
        for (int i = 0; i < n; i++) {
            System.out.print(arr[i] + " ");
        }

        System.out.println("\n Size of arrays is: " + arr.length);
    }
}
