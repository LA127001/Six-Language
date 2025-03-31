import 'dart:io';

bool isPrime(int nums) {
  for (int i = 2; i * i <= nums; i++) {
    if (nums % i == 0) return false;
  }
  return true;
}

void main() {
  print("Enter a number: ");
  int nums = int.parse(stdin.readLineSync()!);
  if (isPrime(nums)) {
    print("$nums is prime number.");
  } else {
    print("$nums is not prime number.");
  }
}
