#include <iostream>
using namespace std;

int main() {
    int num = 42;

    int *p = &num; // set p to memory address of num

    cout << p;
}
