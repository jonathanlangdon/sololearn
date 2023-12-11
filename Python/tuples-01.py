# return contact info given a name

contacts = {"James": 42, "Amy": 24, "John": 31, "Amanda": 63, "Bob": 18}

input_name = input()


def get_age(name):
    age = contacts.get(name, "Not Found")
    if age != "Not Found":
        return f"{name} is {age}"
    else:
        return age


print(get_age(input_name))
