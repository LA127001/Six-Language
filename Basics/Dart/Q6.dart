import 'dart:io';

void main() {
  print("Enter a age: ");
  int age = int.parse(stdin.readLineSync()!);

  if(age >= 18){
    print("Vote");
  }
  else{
    print("No right");
  }
}
