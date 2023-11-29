# print numbers to a file

n = int(input())

file_handle = open("numbers.txt", "w+")

for i in range(n):
    print(str(i + 1), file=file_handle)


file_handle.close()

f = open("numbers.txt", "r")
print(f.read())
f.close()
