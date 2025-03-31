import 'dart:io';

void main() {
  print("Enter the temperature: ");
  int temp = int.parse(stdin.readLineSync()!);

  if (temp > 30)
    print("It's very hot!");
  else if (temp > 10 && temp < 30)
    print("The weather is pleasant.");
  else
    print("It's very cold!");
}
