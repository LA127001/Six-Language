
import java.util.Scanner;

class Q9 {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.println("Enter a number: ");
        double num1 = sc.nextDouble();
        System.out.println("Enter a another number: ");
        double num2 = sc.nextDouble();
        System.out.println("Enter a operator: ");
        char operators = sc.next().charAt(0);

        switch (operators) {
            case '+' ->
                System.out.println("Sum: " + (num1 + num2));
            case '-' ->
                System.out.println("Sub: " + (num1 - num2));
            case '*' ->
                System.out.println("Mul: " + (num1 * num2));
            case '/' ->
                System.out.println("Div: " + (num1 / num2));
            default ->
                System.out.println("Invalid operator");
        }

    }
}
