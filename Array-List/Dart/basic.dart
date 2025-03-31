import 'dart:io';

void main() {
  /* 
  ? Create a print 
  List<int> arr = [5, 10, 15, 20, 25];
  print(arr);
  print(arr.length);
  */

  /*
  ?Input of list
  */

  print("Enter size of list: ");
  int n = int.parse(stdin.readLineSync()!);

  List<int> arr = [];
  print("Enter $n numbers: ");

  for (int i = 0; i < n; i++) {
    arr.add(int.parse(stdin.readLineSync()!));
  }
  print(arr);

  print(arr.length);
}
