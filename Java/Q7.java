import java.util.Scanner;

class Q7{
     public static void main(String[] args) {
         Scanner sc = new Scanner(System.in);
           System.out.println("Enter a temperature: ");
           int temp =sc.nextInt();

           if(temp > 30)System.out.println("It's very hot!");
           else if(temp > 10 && temp < 30) System.out.println("The weather is pleasant.");
           else System.out.println("It's very cold!");
     }
}