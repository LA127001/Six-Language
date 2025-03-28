#include <iostream>
using namespace std;

int main()
{

     int num;
     long long facto = 1;

     cout << "Enter a number: " << endl;
     cin >> num;

     for (int i = 1; i <= num; i++)
     {
          facto *= i;
      
     }

     cout << facto << endl;

     return 0;
}