import 'dart:io';

void main() {
  print("Enter the celsius: ");
  int celsius = int.parse(stdin.readLineSync()!);
  num fahrenheit = celsius * 9.0 / 5 + 32;

  print("$fahrenheit F");
}
