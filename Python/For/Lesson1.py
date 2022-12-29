
"""

Цикл - это выражение, для повторение какого-то блока кода

Есть 3 вида циклов:
    1. While - цикл с условием. Работает пока условие истинно.
    2. For - цикл с диапазоном. Работает столько раз, стколько мы скажем.
    3. Foreach - цикл с итератором. Перебирает элементы коллекции.
"""

# <editor-fold desc="Виды многострочных комментариев">

# print('''
# fg sdfgsdfg s df
# dsf gdsf
#             dgh;d fgh
#             fgdh
#             dfg
# ''')
#
#
# print("""
# fg sdfgsdfg s df
# dsf gdsf
#             dgh;d fgh
#             fgdh
#             dfg
# """)

# </editor-fold>


# <editor-fold desc="While">

# start = int(input("Enter start: "))
# end = int(input("Enter end: "))


# while start <= end:
#     print(start)
#     start += 1


# </editor-fold>

# <editor-fold desc="For part 1">

# i - iterator (счетчик)
# iteration - один шаг цикла
# range - диапазон

# for i in range(10):
#     print(i, end=' ')

# </editor-fold>

# <editor-fold desc="For part 2">

"""
    range - диапазон 
    Есть 3 варианта функции range. Точнее 3 перегрузки.
    1. range с параметром end
    2. range с параметрами start, end
    3. range с параметрами start, end, step
"""

# for i in range(1, 10, 2):
#     print(i)

# </editor-fold>

"""
Вопрос: Когда нам нужно использовать for ? 
Ответ: Когда мы точно знаем сколько раз блок кода должен повториться
"""

# start = int(input("Enter start: "))
# end = int(input("Enter end: "))


# for i in range(start, end):
#     print(i, end=' ')

# for i in range(4):
#     for j in range(4):
#         print(i, j)
#     print()

# i = 0
# j = 4
#
# while i < 4:
#     j = 0
#     while j < 4:
#         print(i, j)
#         j += 1
#     print()
#     i += 1


# name = "Elvin"
#
# for i in range(len(name)):
#     print(name)

# name = "Elvin"

# print(name[0])
# print(name[1])
# print(name[2])
# print(name[3])
# print(name[4])

# for i in range(len(name)):
#     print(name[i])

# print(name[-3])

name = "Elvin"

# print(name[1:3])
# print(name[1::2])
# print(name[:3])
# print(name[::2])
# print(name[::-1])
