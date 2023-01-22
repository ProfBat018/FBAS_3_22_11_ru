# <editor-fold desc="Why we need return statement">
#   pass - это ключевое слово для пустой функции
# import random
import random


# def find_min(nums: list):
#     root = nums[0]
#     for i in range(len(nums)):
#         if root > nums[i]:
#             root = nums[i]
#     return root
#
#
# def find_max(nums: list):
#     pass
#
#
# nums = [random.randint(1, 10) for i in range(10)]
#
# print(nums)

# result = find_min(nums)
# print(result)

# </editor-fold>


# <editor-fold desc="Bubble Sort">


def bubble_sort(nums: list):
    for i in range(len(nums)):
        for j in range(len(nums) - 1):
            if nums[j] > nums[j + 1]:
                a = nums[j]
                nums[j] = nums[j + 1]
                nums[j + 1] = a
    return nums


nums = [random.randint(1, 10) for i in range(10)]

print(bubble_sort(nums))

# </editor-fold>


# Генерируется 10 случайных чисел. Сделайте сортировку этих чисел с помощью функции.

