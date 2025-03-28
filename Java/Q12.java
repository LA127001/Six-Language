
import java.util.Scanner;

class Q12 {

    public static void main(String[] args) {
        System.out.println("Enter a number: ");
        Scanner sc = new Scanner(System.in);
        int nums = sc.nextInt();
        int factorial = 1;
        for (int i = 1; i <= nums; i++) {
            factorial *= i;
        }
        System.out.println(factorial);
    }
}
