// throw an exception if an inputed number is out of range

#include <iostream>
using namespace std;

int main() {
    string menu[] = {"fruits", "chicken", "fish", "cake"};
    try {
        int x;
        cin >> x;
        //your code goes here
        if (x < 0 or x > 3) {
            throw 404;
        }
        cout << menu[x];
    }
    catch(...) {
        //and here
        cout << "404 - not found";
    }
}