#include <iostream>
using namespace std;

int main()
{

     int num1, num2;
     char operators;

     cout << "Enter a number: " << endl;
     cin >> num1;
     cout << "Enter a another number: " << endl;
     cin >> num2;
     cout << "Enter an operator: " << endl;
     cin >> operators;

     switch (operators)
     {
     case '+':
          cout << "Sum: " << num1 + num2 << endl;

          break;
     case '-':
          cout << "Sub: " << num1 - num2 << endl;

          break;
     case '*':
          cout << "Multi: " << num1 * num2 << endl;

          break;
     case '/':
          cout << "Div: " << num1 / num2 << endl;

          break;

     default:
          cout << "Invalid operator" << endl;
          break;
     }

     return 0;
}