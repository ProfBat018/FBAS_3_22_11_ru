"""
Функция - это вызываемый блок кода.
Функция может, а Иса получает один балл (👉ﾟヮﾟ)👉
Функция должна быть lowercase.
До и после функции нужно оставить две пустые строки.


1. Зачем нужна функция и когда её создавать ?
"""


# Функция вывода Hello World

# <editor-fold desc="Part 1">


# def say_hello():
#     print("Hello World")


# def find_even():
#     number = int(input("Enter number: "))
#     if number % 2 == 0:
#         print("Even")
#     else:
#         print("Odd")

#
# def find_even(number):
#     if number % 2 == 0:
#         print("Even")
#     else:
#         print("Odd")

#
# def find_even(number):
#     if number % 2 == 0:
#         return True
#     else:
#         return False


# def find_even(number):
#     return number % 2 == 0


# nums = [1, 2, 3, 4, 5]
# #print(find_even(nums[3]))
# res = find_even(nums[3])
# print(res)

# </editor-fold>

# <editor-fold desc="Part 2">


def my_index(num, numbers):
    for i in range(len(numbers)):
        if numbers[i] == num:
            return i


a = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
print(my_index(5, a))

# </editor-fold>
