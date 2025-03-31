import java.util.Scanner;

class Q17{
     public static void main(String [] args){
          Scanner sc = new Scanner(System.in);

          System.out.println("Enter a Temperature: ");
          int temp = sc.nextInt();

          double fahrenheit = temp * 9.0 / 5 + 32;

          System.out.println(fahrenheit + "F");
     }
}