#include <iostream>
using namespace std;

int main()
{

     int age;
     cout << "Enter your age: " << endl;
     cin >> age;

     if (age >= 18)
          cout << "Vote" << endl;
     else
          cout << "Don't vote" << endl;

     return 0;
}