#include <iostream>
using namespace std;

int main()
{

     int temp;
     cout << "Enter the Temperature: " << endl;
     cin >> temp;

     if (temp > 30)
          cout << "It's very hot! 🥵" << endl;
     else if (temp > 10 && temp < 30)
          cout << "The weather is nice. ☁" << endl;
     else
          cout << "It's very cold! ❄" << endl;

     return 0;
}