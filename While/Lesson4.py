# Написать программу угадай число.

# <editor-fold desc="Example 1">

# import random
#
# number = random.randint(1, 100)
# count = 1
# res = int(input("Enter your number: "))
#
# while res != number:
#     if res < number:
#         print(f"Your number is lower")
#     elif res > number:
#         print(f"Your number is bigger")
#     res = int(input("Enter your number: "))
#
# print("You win")

# </editor-fold>

# <editor-fold desc="Example 2">

# import random
# import time
#
# number = random.randint(1, 100)
# print(number)
# count = 0
# start_time = time.time()
#
# while True:
#     res = int(input("Enter your number: "))
#     count += 1
#     if res < number:
#         print(f"Your number is lower")
#     elif res > number:
#         print(f"Your number is bigger")
#     else:
#         print(f"You win with turns: {count}")
#         break
#
# end_time = time.time()
# print("Elapsed time: {:.2f}".format(end_time - start_time))


# </editor-fold>


# Написать программу, которая генерирует пароль

# <editor-fold desc="Password">

# import string
# from random import choice
# from pyperclip import copy
# import pyttsx3
#
# MIN_LENGTH = 8
# password = str()
#
# lower_letters = string.ascii_lowercase
# upper_letters = string.ascii_uppercase
# digits = string.digits
# punctuation = string.punctuation
#
# length = int(input("Enter length of your password: "))
#
# if length < MIN_LENGTH:
#     length = MIN_LENGTH
#
# i = 0
#
# while i < length:
#     tmp = choice(lower_letters) + choice(upper_letters) + choice(digits) + choice(punctuation)
    # password += choice(lower_letters + upper_letters + digits + punctuation)
    # i += 1
#
# print(password)
#
#
# while True:
#     choice = int(input("Enter choice:\n"
#                        "1. Copy to clipboard\n"
#                        "2. Exit\n"))
#     if choice == 1:
#         copy(password)
#         break
#     elif choice == 2:
#         break
#     else:
#         pyttsx3.speak("Are you stupid ?")
#
#
# </editor-fold>

number = int(input("Enter your number: "))  # 1234

division = 1
odd_sum = 0
even_sum = 0

while (number // division) > 0:
    digit = (number // division) % 10
    division *= 10
    if digit % 2 == 0:
        even_sum += digit
    else:
        odd_sum += digit






