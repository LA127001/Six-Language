import java.util.Scanner;
class Q6{

     public static void main(String []args){
          Scanner sc = new Scanner(System.in);

          System.out.println("Enter a ager: ");
          int age = sc.nextInt();

          if(age >= 18) System.out.println("Vote");
          else System.out.println("Not Vote");
     }
}