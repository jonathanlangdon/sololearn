// using if statements for entry into a playground

#include <iostream>
using namespace std;

int main() {
    int age;
    cin >> age;
    if (age < 4) {
        cout << "Free";
    } else if (age < 7) {
        cout << "Discounted";
    } else {
        cout << "Normal";
    }
}

