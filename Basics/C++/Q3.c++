#include <iostream>
using namespace std;

int main(){

     int num = 10;
     bool isEven = num % 2 == 0; // Boolean variable is check even number
     cout << "The number is " << num << (isEven ? " Even" : "No Even") << endl;

     return 0;
}