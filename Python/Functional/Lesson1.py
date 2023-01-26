import random
import functools    # для функции reduce
"""
    Functional programming - функциональное программирование.
    Применение к элементам какой-то коллекции какую-то функцию
    
    Map, Reduce, Filter
"""

# <editor-fold desc="Map">

# <editor-fold desc="My map">


# def find_even(num):
#     return num % 2 == 0
#
#
# def my_map(function, collection):
#     res = []
#     for i in collection:
#         res.append(function(i))
#     return iter(res)
#
#
# nums = [i for i in range(10)]
# res = list(my_map(find_even, nums))
# print(res)

# </editor-fold>

# <editor-fold desc="Built-in Map">

# nums = [i for i in range(10)]
# res = list(map(lambda x: x % 2 == 0, nums))
# print(res)

# </editor-fold>

# </editor-fold>

# <editor-fold desc="Reduce">

# <editor-fold desc="My reduce">

# def my_reduce(function, collection):
#     it = iter(collection)
#     value = next(it)
#     for i in it:
#         value = function(i, value)
#     return value
#
#
# nums = [i for i in range(1, 5)]
# res = my_reduce(lambda x, y: x + y, nums)
# print(res)

# names = ["Elvin", "Isa", "Xelil", "Magomed"]
# res = my_reduce(lambda x, y: x if len(x) > len(y) else y, names)
# print(res)
# </editor-fold>

# <editor-fold desc="Built-in-reduce">

# nums = [i for i in range(10)]
# res = functools.reduce(lambda x, y: x + y, nums)
# print(res)

# </editor-fold>


# </editor-fold>

# <editor-fold desc="Filter">

# <editor-fold desc="My filter">

# def my_filter(function, collection):
#     res = []
#     for i in collection:
#         if function(i):
#             res.append(i)
#     return iter(res)
#
#
# nums = [i for i in range(10)]
# res = my_filter(lambda num: num % 2 == 0, nums)
# print(list(res))

# </editor-fold>


# <editor-fold desc="Built-in-Filter">

# nums = [i for i in range(10)]
# res = list(filter(lambda num: num % 2 == 0, nums))
# print(res)


# </editor-fold>


# </editor-fold>

# <editor-fold desc="Iter">

# nums = [i for i in range(5)]
#
# nums_iterator = iter(nums)
# print(nums_iterator)
#
# print(next(nums_iterator))
# print(next(nums_iterator))
# print(next(nums_iterator))
# print(next(nums_iterator))
# print(next(nums_iterator))

# for i in nums:  # foreach
#     print(i)

# </editor-fold>



