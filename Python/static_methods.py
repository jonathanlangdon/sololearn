# create a static method that can be called on the class


# your code goes here
class Shape:
    @staticmethod
    def area(w, h):
        return w * h


w = int(input())
h = int(input())

print(Shape.area(w, h))
