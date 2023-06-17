word = input()
vowels = {'a','e','i','o','u'}
word_consts = [c for c in word if c not in vowels]
print(word_consts)
