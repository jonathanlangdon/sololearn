def calc(x):
    return [4 * x, x * x]
    

side = int(input())
p, a = calc(side)

print("Perimeter: " + str(p))
print("Area: " + str(a))
