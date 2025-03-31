#include <iostream>
using namespace std;

int main()
{

     double celsius, fahrenheit;
     cout << "Enter the Temperature in celsius: ";
     cin >> celsius;

     fahrenheit = celsius * 9.0 / 5 + 32;

     cout << fahrenheit << " F" << endl;

     return 0;
}