// use a function template to accept any parameter type

#include <iostream>
using namespace std;

//your code goes here
template <typename T>
T myMax(T num1, T num2) {
    if (num1 > num2) {
        return num1;
    } else {
        return num2;
    }
}


int main () {
    double x, y;
    cin>>x>>y;
    int a, b;
    cin>>a>>b;
    cout << myMax(x, y) << endl;
    cout << myMax(a, b) << endl;
}