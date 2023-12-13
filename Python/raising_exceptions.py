# raise exception when over 42 tweets

tweet = input()

try:
    # your code goes here
    if len(tweet) > 42:
        raise exception

except:
    print("Error")
else:
    print("Posted")
