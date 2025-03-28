import 'dart:io';

void main() {
  print("************** Welcome to the Programmer Journey **************");
  print("Enter your name: ");
  String name = stdin.readLineSync()!;
  print("Enter your age: ");
  int age = int.parse(stdin.readLineSync()!);
  print("Enter your city: ");
  String city = stdin.readLineSync()!;

  print("\n********** User Details **********\n");
  print("Your Name is : $name");
  print("Your Age is  : $age");
  print("Your City is : $city");
}
