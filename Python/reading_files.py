# use error handling while reading a file based on user input

file = open("books.txt")
# your code goes here
n = 0
input_invalid = True
while input_invalid:
    try:
        n = int(input("Please enter number of characters to read: "))
    except:
        continue
    else:
        input_invalid = False
print(file.read(n))
