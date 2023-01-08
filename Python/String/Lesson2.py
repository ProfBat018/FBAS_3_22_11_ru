# """
#
# string - строка. Символьный тип данных
#
# """
#
# # name = "Elvin"        # неявное создание переменной типа данных string.
#
# # name: str = "Elvin"     # явное создание переменной типа данных string.
#
#
# # name = "!"
# #
# # res = name.join(["Elvin", "Azimov", "Rasul"])
# # print(res)
#
#
# # print(name.index("k"))
# # print(name.find("k"))
#
# # print(name[name.find("k")])
#
#
# # text = "Hello World?? How are you ?!?"
# # operators = [".", "?", "!"]
# # i = 11
# #
# # while text[i] in operators:
# #     print("Yes")
# #     i += 1
#

text = "Hello World?? How are you !?! Aloha! Hakuna Matata. Xelil:) ."
operators = [".", "?", "!"]
length = 0
check = True

i = 0
j = 0
while i < len(text) and check:
    j = 0
    while j < len(operators) and check:
        if text[i] == operators[j]:
            length += 1
            while (text[i] in operators) and i < (len(text) - 1):
                i += 1
            if i == len(text):
                check = False
        j += 1
    i += 1

if text[-1] not in operators:
    length += 1

print(length)

