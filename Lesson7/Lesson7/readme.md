# Темы урока: 
1. switch
2. decimal
3. nullable types
4. null-coalescing operator
5. null-condition operator
6. Некоторые моменты с наследованием

## decimal  

```csharp
float ft = 1.0f; // 4 byte
double dl = 1.0d; // 8 byte
decimal dm = 1.0m; // 16 byte
```

decimal нужен для финансовых расчетов, где нужна высокая точность.


## Nullable типы и зачем они нужны.
Мы знаем, что в C# есть два типа данных.
1. Value type
2. Reference type

При этом у нас есть литерал `null`, 
который мы можем присвоить только ссылочному типу.

По факту `null` - это `nullptr` в C++.

Но что если мы хотим присвоить `null` переменной типа `int` ?
В таком случае у нас неявно произойдет `boxing`

По умолчанию мы можем написать так.

```csharp
string name = null;
```

и это даже будет работать,
но было бы лучше, если бы мы могли написать так.
Если мы не пишем `?` после типа, то компилятор сам сделает его `nullable`.

```csharp
string? name = null;
```
Таким образом мы сможем понять, что переменная может быть `null`.

и `intelisense` сможет подсказать нам, что в этой переменной может быть null.

```csharp
string name = Console.ReadLine();
```

В данном случве `intelisense` будет подчеркивать `Console.ReadLine()`,
и говорить о том, что в этой переменной может быть `null`.

или как вариант может быть такое, что мы пытаемся 
использовать ключевое `as` для приведения типа.

```csharp
FileStream fs = new();

List<int> nums = fs as List<int>;
```
То в таком случае в `nums` будет `null`, но мы не сказали ему что он 
`nullable`

# ВАЖНО

ЕСЛИ ВЫ ПИШИТЕ `?`, ТО ВЫ ОБЯЗУЕТЕСЬ В БУДУЩЕМ ПРОВРЕЯТЬ ЕГО НА 
`null` ПРИ ИСПОЛЬЗОВАНИИ.

Для облегчения использования `nullable` типов,
придумали оператор `null-coalescing operator` и 
`null-condition operator`.


## null-coalescing operator

```csharp

string? name = null;
name ??= "default name";
string name2 = name ?? "default name";

```

## null-condition operator

```csharp

string? name = null;
string name2 = name?.ToString() ?? "default name";
```


