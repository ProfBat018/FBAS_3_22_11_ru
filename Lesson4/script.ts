// // abstract class Animal {
// //   abstract makeSound(): void;
// //   move(): void {
// //     console.log("roaming the earth...");
// //   }
// // }

// // class Dog extends Animal {
// //   override makeSound() {
// //     console.log("Woof! Woof!");
// //   }
// // }

// // let d1 = new Dog();

// // d1.makeSound();

// function getProperty<T, K extends keyof T>(obj: T, key: K) {
//     return obj[key];
// }

// let x = { a: 1, b: 2, c: 3, d: 4 };

// console.log(getProperty(x, "a")); // okay

// function sealed(constructor: Function) {
//     Object.seal(constructor);
//     Object.seal(constructor.prototype);
// }

// @sealed
// class Greeter {
//     greeting: string;
//     constructor(message: string) {
//         this.greeting = message;
//     }
//     greet() {
//         return "Hello, " + this.greeting;
//     }
// }

// class Test extends Greeter {
//     constructor(message: string) {
//         super(message);
//     }
// }

// let t = new Test("Hello World");

// console.log(t.greet()); // "Hello, World"

function log(
  target: Object,
  propertyKey: string | symbol,
  descriptor: PropertyDescriptor
) {
  const originalMethod = descriptor.value;

  descriptor.value = function (...args: any[]) {
    console.log(`Calling ${this.propertyKey} with arguments: ${args}`);
    return originalMethod.apply(this, args);
  };

  return descriptor;
}
class Calculator {
  @log
  add(a: number, b: number): number {
    return a + b;
  }
}

const calculator = new Calculator();
calculator.add(1, 2);
