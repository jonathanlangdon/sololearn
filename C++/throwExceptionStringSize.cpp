// throw an exception if a string is the wrong size

#include <iostream>
using namespace std;

int main() {
   string name;
   cin >> name;
   try {
      if(name.size() < 4 || name.size() > 20) {
         throw 9;
      }
      cout << "Valid" << endl;
   }
   catch(int x) {
      cout << "Invalid" << endl;
   }
   
   return 0;
}