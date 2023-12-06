// using member initializers

#include <iostream>
using namespace std;

class TV {
    public:
        TV(int h, int w): height(h), width(w) {};
        void area() {
            cout <<height*width;
        }
    private:
        int height;
        int width;
};

int main() {
   int height;
   int width;
   cin >> height;
   cin >> width;
   TV tv(height, width);
   tv.area();
}

