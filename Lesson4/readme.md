# Classes in Typescript

Для начала хочу поговорить с вами о разнице между интерфейсами, классами и типами в TypeScript.

От класса наследуются(extends), от интерфейса реализуются(implements), а типы используются для описания структуры данных.

Тип не может иметь конструктора или метода.
Интерфейс не может иметь реализации, но может иметь декларацию метода.

# Classes

Классы в TypeScript похожи на классы в других языках программирования, таких как Java или C#. Они позволяют использовать принципы ООП, такие как наследование, инкапсуляция и полиморфизм.

```typescript
class Animal {
  name: string;
  constructor(theName: string) {
    this.name = theName;
  }
  move(distanceInMeters: number = 0) {
    console.log(`${this.name} moved ${distanceInMeters}m.`);
  }
}
```

Перегрузка конструктора в TypeScript не поддерживается, но можно использовать параметры по умолчанию.

```typescript
class Animal {
  name: string;
  constructor(theName: string = 'Animal') {
    this.name = theName;
  }
  move(distanceInMeters: number = 0) {
    console.log(`${this.name} moved ${distanceInMeters}m.`);
  }
}
```

# Inheritance

```typescript
class Snake extends Animal {
  constructor(name: string) {
    super(name);
  }
  move(distanceInMeters = 5) {
    console.log('Slithering...');
    super.move(distanceInMeters);
  }
}
```

# Implementing 

```typescript

interface IAnimal {
    name: string;
    move(distanceInMeters: number): void;
  }
  

class Cat implements IAnimal {
    name: string;
    constructor(name: string) {
        this.name = name;
    }
    move(distanceInMeters: number) {
        console.log(`${this.name} moved ${distanceInMeters}m.`);
    }
}

```

# Access Modifiers

В TypeScript доступны три модификатора доступа: public, private и protected.

```typescript

class Animal {
    private name: string;
    constructor(theName: string) {
        this.name = theName;
    }
}

```

## Abstract Classes

Абстрактные классы - это классы, которые не могут быть созданы напрямую. Они используются как шаблоны для других классов, которые наследуются от них.

```typescript

abstract class Animal {
    abstract makeSound(): void;
    move(): void {
        console.log('roaming the earth...');
    }
}


class Dog extends Animal {
    makeSound() {
        console.log('Woof! Woof!');
    }
}
```

# Static Properties

```typescript

class Grid {
    static origin = { x: 0, y: 0 };
    calculateDistanceFromOrigin(point: { x: number; y: number }) {
        let xDist = point.x - Grid.origin.x;
        let yDist = point.y - Grid.origin.y;
        return Math.sqrt(xDist * xDist + yDist * yDist) / this.scale;
    }
    constructor(public scale: number) { 

    }
}

```


# Generic Classes

```typescript

class GenericNumber<T> {
    zeroValue: T;
    add: (x: T, y: T) => T;
}

let myGenericNumber = new GenericNumber<number>();

myGenericNumber.zeroValue = 0;

myGenericNumber.add = function(x, y) { return x + y; };

```

Обобщения работают и с классами, так же как и с функциями. Все работает ровно также как и в C#.


## Generic Constraints 

```typescript

interface Lengthwise {
    length: number;
}

function loggingIdentity<T extends Lengthwise>(arg: T): T {
    console.log(arg.length);
    return arg;
}

```


или так

```typescript

function getProperty<T, K extends keyof T>(obj: T, key: K) {
    return obj[key];
}

let x = { a: 1, b: 2, c: 3, d: 4 };

getProperty(x, "a"); // okay

```

# Decorators

Декораторы - это специальные объявления, которые могут быть присоединены к объявлению класса, метода, аксессора, свойства или параметра. Декораторы используются для расширения возможностей или изменения поведения объектов, функций или классов.

```typescript

function sealed(constructor: Function) {
    Object.seal(constructor);
    Object.seal(constructor.prototype);
}

@sealed
class Greeter {
    greeting: string;
    constructor(message: string) {
        this.greeting = message;
    }
    greet() {
        return "Hello, " + this.greeting;
    }
}


class Test extends Greeter {
    constructor(message: string) {
        super(message);
    }
}

```


