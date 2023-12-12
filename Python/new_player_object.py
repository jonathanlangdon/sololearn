# instantiate a new Player object and call a method on it


class Player:
    def __init__(self, name, level):
        self.name = name
        self.level = level

    def intro(self):
        print(self.name + " (Level " + self.level + ")")


# your code goes here
def create_player():
    name = input()
    level = input()
    new_player = Player(name, level)
    return new_player


player = create_player()
player.intro()
