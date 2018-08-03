import random
import math
import string

class Password_Generator():

    def __init__(object):

        word_dict = open('words_alpha.txt', 'r').readlines()

        first_half = str(random.choice(word_dict))

        if len(first_half) < 4:
            pass

        else:
            first_half = first_half[0:4]

        char = string.ascii_letters + string.digits + string.punctuation

        size = int(raw_input("What would you like your password length to be? "))
        size = size - 5

        second_half =  ''.join(random.choice(char) for _ in range(size))

        print 'Your password is: %s-%s' % (first_half, second_half)

Password_Generator()
