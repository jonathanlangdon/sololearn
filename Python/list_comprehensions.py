word = input()
vowels = {"a", "e", "i", "o", "u"}
# list comprehensions use the following format to loop through the list
word_consts = [c for c in word if c not in vowels]
print(word_consts)
