import java.util.Scanner;
class Q13 {

    public static void main(String[] args) {
        System.out.println("Enter a number: ");
        Scanner sc = new Scanner(System.in);
        int nums = sc.nextInt();
        int num1 = 0, num2 = 1, ans;

        for (int i = 2; i < nums; i++) {
            ans = num1 + num2;
            System.out.print(ans + " ");
            num1 = num2;
            num2 = ans;
        }
    }
}
