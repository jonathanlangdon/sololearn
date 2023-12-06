// example of a constructor when creating a class

#include <iostream>
#include <string>
using namespace std;

class Painting {
    public:
        Painting(string name) {
            cout << name;
        }
        
};
int main() {
    string name;
    cin >> name;

    Painting painting(name);

    return 0;
}