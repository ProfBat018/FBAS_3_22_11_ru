# <editor-fold desc="Print function">

# print("Hello World")

# print("Hello")
# print("World")

# print(1, 2, 3, 4, 5, sep=', ')   # sep - separate

# print("Hello", end=' ')     # end - endline
# print("World")

# </editor-fold>

# <editor-fold desc="Escape sequences">

# \n - newline
# \t - TAB
# \a - alert
# \\ - \
# \" - "
# \' - '

# print("Hello\nWorld")
# print("Hello\tWorld")
# print("Hello\\World")
# print("Hello\\\\World")

# print("'Случайности не случайны'")
# print('"Случайности не случайны"')
#
# print("\"Случайности не случайны\"")
# print('\'Случайности не случайны\'')

# </editor-fold>

# <editor-fold desc="Variables">

# Variable - переменная. Переменная - это область в оперативной памяти, которая хранит в себе данные.

# <editor-fold desc="Naming cases">

"""
    1. Snake case - main naming case in Python.
    first_name
    step_academy
    computer_info
    2. Pascal case - First letter of all words is upper case
    FirstName
    StepAcademy
    ComputerInfo

    3. Camel case - has 2 types of naming.
        a. Lower camel case
            firstName
            stepAcademy
            computerInfo
        b. Upper camel case - is them same thing as Pascal case
            FirstName
            StepAcademy
            ComputerInfo
    4. Kebab case
    first-name
    step-academy
    computer-info
"""

# </editor-fold>


# first_num = 1
# second_num = 12
#
# print(first_num, "+", second_num, "=", first_num + second_num)  # долгий
#
# print(f"{first_num} + {second_num} = {first_num + second_num}")  # топовый метод
#
# print("{} + {} = {}".format(first_num, second_num, first_num + second_num))  # тривиальный


# </editor-fold>

# <editor-fold desc="Data types">

'''
    1. String. (str). Any symbol or text
    2. Integer. (int). Any integer value
    3. Float. (float). Any number with floating point.
    4. Bool. (bool). Logical data type. Full name is boolean.
'''
# </editor-fold>

# <editor-fold desc="Input">

# first_number = int(input("Enter your number: "))   # 5
# second_number = int(input("Enter your number: "))  # 6

# first_number = int(first_number)
# second_number = int(second_number)


# print(first_number, "+", second_number, "=", first_number + second_number)

# </editor-fold>


# <editor-fold desc="Arithemic operators">

num1 = 6
num2 = 4

print(num1 + num2)
print(num1 - num2)
print(num1 * num2)
print(num1 / num2)
print(num1 % num2)
print(num1 // num2)
print(num1 ** num2)

# </editor-fold>
