import 'dart:io';

void main() {
  print("Enter a number: ");
  int nums = int.parse(stdin.readLineSync()!);
  int factorial = 1;

  for (int i = 1; i <= nums; i++) {
    factorial *= i;
  }
  print(factorial);
}
