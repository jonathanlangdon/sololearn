contacts = [
    ('James', 42),
    ('Amy', 24),
    ('John', 31),
    ('Amanda', 63),
    ('Bob', 18)
]

name = input()

found = False

for contact in contacts:
  if name == contact[0]:
    found = True
    print(f'{name} is {contact[1]}')
    break
if not found:
  print('Not Found')
