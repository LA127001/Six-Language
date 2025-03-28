
import java.util.Scanner;

class Q16 {

    public static void main(String[] args) {
        System.out.println("************** Welcome to the Programmer Journey **************");
        Scanner sc = new Scanner(System.in);

        System.out.println("Enter your name: ");
        String name = sc.nextLine();

        System.out.println("Enter your age: ");
        int age = sc.nextInt();
        sc.nextLine(); //? Going for another input

        System.out.println("Enter your city: ");
        String city = sc.nextLine();

        System.out.println("\n********** User Details **********\n");

        System.out.println("Your Name is : " + name);
        System.out.println("Your Age is  : " + age);
        System.out.println("Your City is : " + city);
    }
}
