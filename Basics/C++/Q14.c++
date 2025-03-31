#include <iostream>
using namespace std;

int sum (int num1, int num2){
     return num1 + num2;
}
int sub (int num1, int num2){
     return num1 - num2;
}
int mul (int num1, int num2){
     return num1 * num2;
}
int divide (int num1, int num2){
     return num1 / num2;
}

int main(){
 
     int num1, num2, ans;
     cout << "Enter a number: " ;
     cin >> num1;
     cout << "Enter a another number: " ;
     cin >> num2;

     ans = sum(num1, num2);
     cout << "Sum: "<< ans <<endl;
     
     ans = sub(num1, num2);
     cout << "Sub: "<< ans <<endl;

     ans = mul(num1, num2);
     cout << "Mul: "<< ans <<endl;

     ans = divide(num1, num2);
     cout << "Div: "<< ans <<endl;


     return 0;
}