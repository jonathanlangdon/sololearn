# overload the + and > operators


class Shape:
    def __init__(self, w, h):
        self.width = w
        self.height = h

    def area(self):
        return self.width * self.height

    # your code goes here
    def __add__(self, s2):
        width = self.width + s2.width
        height = self.height + s2.height
        return Shape(width, height)

    def __gt__(self, s2):
        return self.area() > s2.area()


w1 = int(input())
h1 = int(input())
w2 = int(input())
h2 = int(input())

s1 = Shape(w1, h1)
s2 = Shape(w2, h2)
result = s1 + s2

print(result.area())
print(s1 > s2)
