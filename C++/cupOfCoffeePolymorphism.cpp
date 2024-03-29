// fixing some bugs with inheritance and pointers

#include <iostream>
using namespace std;

class Drink {
    protected: 
        int price;
    public:
        void setPrice(int a){
            price = a;
        }
};

class Coffee: public Drink {
    public:
        void make() {
            cout << "Coffee: "<<price<<endl;
        }
};

class Tea: public Drink {
    public:
        void make() {
            cout << "Tea: "<<price<<endl;
        }
};

int main() {
    Coffee c;
    Tea t;
    Drink *e1 = &c;
    Drink *e2 = &t;

    e1->setPrice(5);
    e2->setPrice(6);

    c.make();
    t.make();
}