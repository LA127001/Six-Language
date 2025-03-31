#include <iostream>
using namespace std;

int main()
{

     /*
     ? Create a print 
     int arr[5] = {1,2,3,4,5};
      for(int i= 0; i < n; i++){
      cout << arr[i] << " ";
 }
      */

     /*

     ? Input of Arrays
     */
     int n;
     cout << "Enter the size of arrays: " ;
     cin >> n;
     int arr[n];

     cout << "Enter the element: ";
     for(int i = 0; i < n; i++){
      cin >> arr[i];
 }


 cout << "Show the element you enter: ";
 for(int i= 0; i < n; i++){
      cout << arr[i] << " ";
 }
 cout << endl;


 cout << "Size of Arrays: "<< sizeof(arr);
 

     return 0;
}