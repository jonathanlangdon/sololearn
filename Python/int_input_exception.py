# use exception handling of user inputed number
def withdraw(amount):
    print(str(amount) + " withdrawn!")


try:
    withdraw(int(input()))
except:
    print("Please enter a number")
