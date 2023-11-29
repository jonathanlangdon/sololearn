# count how many words on each line in file

with open("/usercode/files/books.txt") as f:
    line_num = 1
    for line in f.readlines():
        word_list = line.split()
        print(f"Line {line_num}: {len(word_list)} words")
        line_num += 1
