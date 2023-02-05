import random

level = {
    1: "Hard",
    2: "Extreme",
    3: "Ne nado Elvin mellim😭"
}

students = {
    1: "Vaqif",
    2: "Yusif",
    3: "Isa",
    4: "Xelil",
    5: "Maqomed",
    6: "Amalya"
}

number = random.randint(1, 6)
lvl = random.randint(1, 3)

print(f"Purge for: {students[number]}")
print(f"Purge level is: {level[lvl]}")


"""
def foo(a,b=1,v):
    pass 


foo()
"""


#   LIFO - Last in first out

def foo(num):
    if num == 1:
        return num
    return num * foo(num - 1)


print(foo(3))


