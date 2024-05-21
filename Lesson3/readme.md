# Функции в Typescript

Функции тут работают так же как и в других языках программирования. Они могут принимать аргументы и возвращать значения. Вот пример функции, которая принимает два аргумента и возвращает их сумму:

```typescript
function add(x: number, y: number): number {
  return x + y;
}
```

Как вы можете заметить тут есть возвращаемый тип `number`. Это означает, что функция `add` возвращает число. Если мы попробуем вернуть строку, то компилятор выдаст ошибку:

```typescript
function add(x: number, y: number): number {
  return "Hello";
}
```

# Functions overloading

`Function overloading` - это процесс, который позволяет создавать несколько функций с одинаковым именем, но разными параметрами. Вот пример:

```typescript
function add(a: number, b: number): number;
function add(a: string, b: string): string;

function add(a: any, b: any): any {
  return a + b;
}

console.log(add(1, 2)); // 3
console.log(add("Hello", " World")); // "Hello World"
```

# Types vs interfaces

`Types` и `interfaces` - это два способа определения типов в `typescript`. Они похожи, но есть некоторые различия. Вот пример:

Тут интерфейсы, не совсем то же самое, что и в C# или Java.

В TypeScript интерфейсы используются для описания формы объекта.
Интерфейсы создают новый тип данных, который описывает форму объекта.

В отличии от типов, от интерфейсов можно наследоваться.

```typescript
interface IPoint3D extends IPoint {
  z: number;
}

class Point3D implements IPoint3D {
  x: number;
  y: number;
  z: number;

  constructor(x: number, y: number, z: number) {
    this.x = x;
    this.y = y;
    this.z = z;
  }
}
```

# Hybrid types not a prius ;)

`Hybrid types` - это типы, которые могут быть использованы как объекты и функции одновременно. Вот пример:

```typescript
type Education = {
  degree: string;
  school: string;
  year: number;
};

type User = {
  name: string;
  age: number;
  email: string;
  education: Education;
};
```
