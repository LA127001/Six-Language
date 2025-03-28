#include <iostream>
#include <string>

using namespace std;

int main()
{

     string name, city;
     int age;

     cout << "************** Welcome to the Programmer Journey **************" << endl;
     cout << "Enter your name: ";     
     getline(cin, name);

     cout << "Enter your city: ";     
     getline(cin, city);

     cout << "Enter you age: ";
     cin >> age;

     cout << "\n********** User Details **********\n";
     cout << "Your name is : " << name << endl
          << "Your age is  : " << age << " years" << endl
          << "Your city is : " << city << endl;

     return 0;
}