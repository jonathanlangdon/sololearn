# return a count of how many words on each line in a file

with open("/usercode/files/books.txt") as f:
    # your code goes here
    lines = f.readlines()
    count = 0
    for line in lines:
        count += 1
        print(f"Line {count}: {len(line.split(' '))} words")
