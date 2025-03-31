#include <iostream>
using namespace std;

int main()
{

     int num, fab1 = 0, fab2 = 1, nexts;
     cout << "Enter a number: " << endl;
     cin >> num;
     cout << "Fibonacci Series: " << fab1 << " " << fab2 << " ";
     for (int i = 2; i < num; i++)
     {
          nexts = fab1 + fab2;
          cout << nexts << " ";
          fab1 = fab2;
          fab2 = nexts;
     }

     return 0;
}