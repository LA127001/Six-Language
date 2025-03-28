import java.util.Scanner;
class Q15{

     public static boolean isPrime(int nums){
          for(int i = 2; i*i <= nums; i++){
              if(nums % i == 0) return false;
          }
          return true;
     }
     public static void main(String[] args) {
         Scanner sc = new Scanner(System.in);
         System.out.println("Enter a number: ");
         int num = sc.nextInt();

         if(isPrime(num)){
          System.out.println("Prime");
         }
         else System.out.println("Not Prime");
     }
}