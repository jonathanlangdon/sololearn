# create a static method


class Shape:
    @staticmethod
    def area(w, h):
        return w * h


w = int(input())
h = int(input())

print(Shape.area(w, h))
