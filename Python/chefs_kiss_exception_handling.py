# use exception handling for user input for menu selection

menu = ["Fries", "Sandwich", "Cheeseburger", "Coffee", "Soda"]
try:
    print(menu[int(input())])
    print("Thanks for your order")
except:
    print("Item not found")
