import "dart:io";

int sum(int num1, int num2) => num1 + num2;

int sub(int num1, int num2) => num1 - num2;

int mul(int num1, int num2) => num1 * num2;

double div(int num1, int num2) => num1 / num2;

void main() {
  print("Enter a number: ");
  int nums1 = int.parse(stdin.readLineSync()!);
  print("Enter a another number: ");
  int nums2 = int.parse(stdin.readLineSync()!);

  print("Addition: ${sum(nums1, nums2)}");
  print("Subtraction: ${sub(nums1, nums2)}");
  print("Multiply: ${mul(nums1, nums2)}");
  print("Divide: ${div(nums1, nums2)}");
}
