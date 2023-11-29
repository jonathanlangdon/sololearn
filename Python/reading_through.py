# read the given number of characters of a file.

file = open("/usercode/files/books.txt")
n = int(input())

chars = file.readline(n * 2)
print(chars)
file.close()
