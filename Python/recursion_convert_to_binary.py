# take an input from user and convert to binary


def convert(num):
    if num <= 1:
        return 1
    return num % 2 + 10 * convert(num // 2)


print(convert(int(input())))
