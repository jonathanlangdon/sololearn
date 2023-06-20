price = int(input())
perc = int(input())

# one line anonymous lambda function
res = lambda: price * perc * 0.01

print(res())
