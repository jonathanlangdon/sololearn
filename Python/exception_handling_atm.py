# try to withdrawl, exception if wrong input type


def withdraw(amount):
    print(str(amount) + " withdrawn!")


# your code goes here
try:
    withdraw(int(input()))
except:
    print("Please enter a number")
