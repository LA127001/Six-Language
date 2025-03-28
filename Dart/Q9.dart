import 'dart:io';

void main() {
  print("Enter a number: ");
  int num1 = int.parse(stdin.readLineSync()!);
  print("Enter a another number: ");
  int num2 = int.parse(stdin.readLineSync()!);
  print("Enter an operator (+, -, *, /): ");
  String operators = stdin.readLineSync()!;

  switch (operators) {
    case "+":
      print("Addition: ${num1 + num2}");
      break;
    case "-":
      print("Subtraction: ${num1 - num2}");
      break;
    case "*":
      print("Multiplication: ${num1 * num2}");
      break;
    case "/":
      print("Division: ${num1 / num2}");
      break;
    default:
      print("Invalid operator");
  }
}
