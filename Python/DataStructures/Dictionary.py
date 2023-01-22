"""
Dictionary - Словарь
Работает по приинципу hash table, где первый параметр это ключ.
Ключевое слово dict
В словаре нет индексации, то есть вы не можете написать users[0]
"""

"""
    clear()	        Removes all the elements from the dictionary
    copy()	        Returns a copy of the dictionary
    fromkeys()	    Returns a dictionary with the specified keys and value
    get()	        Returns the value of the specified key
    items()	        Returns a list containing a tuple for each key value pair
    keys()	        Returns a list containing the dictionary's keys
    pop()	        Removes the element with the specified key
    popitem()	    Removes the last inserted key-value pair
    setdefault()	Returns the value of the specified key. If the key does not exist: insert the key, with the specified value
    update()	    Updates the dictionary with the specified key-value pairs
    values()	    Returns a list of all the values in the dictionary
"""

empty = dict()

users = {
    "elvin": "Elvin_018",
    "yusif": "Yusif_123",
    "vaqif": "Vaqif_456"
}

# print(users)
# print(users.keys())
# print(users.values())

# res = users.fromkeys(["elvin", "yusif"])
# print(res)
# res['elvin'] = 'dgdsdf'
# print(res)


# print(users['elvin'])
# print(users.get("elvin"))   # the same

# print(users.items())

# res = users.items()
# print(res)
# print(list(res))
# print(list(res)[0])


# print(users)
# users.pop("elvin")
# print(users)


# users["isa"] = "Isaqwerty"
#
# print(users)
# users.popitem()
# print(users)


# print(users.get("dfgdfg"))
#
# print(users.setdefault("dfgdfg"))
# print(users)


# print(users)
# users["elvin"] = "Hello"
# print(users)

# print(users)
# users.update({"bbxcvnb": "Hello World"})
# print(users)




