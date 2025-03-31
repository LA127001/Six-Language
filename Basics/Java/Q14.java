
import java.util.Scanner;

class Q14 {

    public static double sum(double num1, double num2) {
        return num1 + num2;
    }

    public static double sub(double num1, double num2) {
        return num1 - num2;
    }

    public static double mul(double num1, double num2) {
        return num1 * num2;
    }

    public static double div(double num1, double num2) {
        return num1 / num2;
    }

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.println("Enter a number: ");
        double num1 = sc.nextDouble();
        System.out.println("Enter a another number:");
        double num2 = sc.nextDouble();

        System.out.println("Addition: " + sum(num1, num2));
        System.out.println("Subtraction: " + sub(num1, num2));
        System.out.println("Multiply: " + mul(num1, num2));
        System.out.println("Divide: " + div(num1, num2));
    }
}
