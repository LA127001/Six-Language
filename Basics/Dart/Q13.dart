import 'dart:io';

void main() {
  print("Enter a number: ");
  int nums = int.parse(stdin.readLineSync()!);

  int zero = 0, one = 1;
  int? next;

  for (int i = 2; i <= nums; i++) {
    next = zero + one;
    stdout.write("$next "); //! this way for horizontal
    //? print("$next "); this way for veritcal
    one = zero;
    zero = next;
  }
}
