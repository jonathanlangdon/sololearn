#your code goes here
def decor(fxn):
    def wrap(num):
        print("***")
        fxn(num)
        print("***")
        print("END OF PAGE")
    return wrap

@decor
def invoice(num):
    print("INVOICE #" +num)

invoice(input());
