start = int(input("Enter start: "))
end = int(input("Enter end: "))

# <editor-fold desc="Task 1">

# while start <= end:
#     print(start)
#     start += 1

# </editor-fold>

# <editor-fold desc="Task 2">

# addition_res = 0
#
# while start <= end:
#     addition_res += start
#     start += 1
#
# print(addition_res)

# </editor-fold>

# <editor-fold desc="Task 3">

# multiplication_res = 1
#
# while start <= end:
#     multiplication_res *= start
#     start += 1
# print(multiplication_res)

# </editor-fold>

# <editor-fold desc="Task 4">
#
# number = int(input("Enter number: "))
# factorial_res = 1
# # 5! = 1 * 2 * 3 * 4 * 5 = 120
#
# while number >= 1:
#     factorial_res *= number
#     number -= 1
#
# print(factorial_res)

# </editor-fold>

# <editor-fold desc="Task 5">

factorial_res = 1
number = 0

while start <= end:
    number = start
    while number >= 1:
        factorial_res *= number
        number -= 1
    print(f"Factorial of: {start}! = {factorial_res}")
    start += 1
    factorial_res = 1


# </editor-fold>

# <editor-fold desc="Task 6">

# new_start = start
# new_end = end
#
# while new_start <= new_end:
#     print(new_start)
#     new_start += 1
#
# new_start = start
# new_end = end
# print(' ')
#
# while new_start <= new_end:
#     if new_start % 2 == 0:
#         print(new_start)
#     new_start += 1
#
# </editor-fold>

# <editor-fold desc="Task 7">

# number = int(input("Enter number: "))   # 2
# power = int(input("Enter power: "))     # 3
#
# i = 0       # i - iterator(счетчик)
# res = 1
#
# if power > 0:
#     while i < power:
#         res *= number
#         i += 1
# elif power < 0:
#     while i >= power:
#         res /= number
#         i -= number
# else:
#     res = 1
#
# print(res)

# </editor-fold>
