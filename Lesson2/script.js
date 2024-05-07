// Области видимости в JavaScript

//#region Part1

// let a = 5; // Глобальная область видимости

// function test() {
//   let b = 10; // Функциональная область видимости

//   if (true) {
//     let с = 10;
//     console.log(`${с} is block scoped`); // 10 is block scoped
//   }

//   function test2() {
//     let d = 15; // Функциональная область видимости
//     console.log(b); // 10
//   }

//   function test3() {
//     console.log(a); // 5
//     test2();
//   }

//   test3();
// }

// test();

//#endregion

//#region Part2

// Встроенные объекты в JavaScript и свойства prototype
// Рассмотрим пример обычного объекта в JavaScript:

// let obj = {
//   name: "John",
//   age: 25,
//   sayHello: function () {
//     console.log(`Hello, my name is ${this.name}`);
//   },
//   sayHello2: () => {
//     console.log(`Hello, my name is ${this.name}`);
//   },
// };

// console.log(obj.name); // John
// console.log(obj.age); // 25

// obj.sayHello(); // Hello, my name is John
// obj.sayHello2(); // Hello, my name is undefined

//#endregion

// console.log(typeof 5); // number
// console.log(typeof "5"); // string
// console.log(typeof true); // boolean

//#region Part3

// свойство prototype

// function User(name, age) {
//   this.name = name;
//   this.age = age;
// }

// User.prototype.sayHello = function () {
//   console.log(`Hello, my name is ${this.name}`);
// };
// // конечно же здесь нельзя использовать стрелочную функцию

// let user1 = new User("John", 25);
// let user2 = new User("Bob", 30);

// user1.sayHello(); // Hello, my name is John
// user2.sayHello(); // Hello, my name is Bob

//#endregion

//#region Part4

// class User {
//     constructor(name, age) {
//         this.name = name;
//         this.age = age;
//     }
// }

// User.prototype.sayHello = function () {
//     console.log(`Hello, my name is ${this.name}`);
// }

// let user1 = new User("John", 25);

// user1.sayHello(); // Hello, my name is John
//#endregion

//#region Part5

// call, apply, bind

// call - вызывает функцию с указанным значением this и аргументами
// apply - вызывает функцию с указанным значением this и аргументами в виде массива
// bind - возвращает новую функцию с указанным значением this и аргументами

// call
// function sayHello() {
//   console.log(`Hello, my name is ${this.name}`);
// }

// let user1 = {
//   name: "John",
// };

// let user2 = {
//   name: "Bob",
// };

// sayHello.call(user1); // Hello, my name is John
// sayHello.call(user2); // Hello, my name is Bob

// apply

// function sayHello() {
//   console.log(`Hello, my name is ${this.name}`);
//   console.log(arguments);
// }

// let user1 = {
//   name: "John",
// };

// let user2 = {
//   name: "Bob",
// };

// sayHello.apply(user1, ["dssdfg", "sdfgsdfg"]); // Hello, my name is John
// sayHello.apply(user2); // Hello, my name is Bob

// bind

// function sayHello() {
//   console.log(`Hello, my name is ${this.name}`);
// }

// let user1 = {
//   name: "John",
// };

// let user2 = {
//   name: "Bob",
// };

// sayHello(); // Hello, my name is undefined
// let f1 = sayHello.bind(user1);
// f1(); // Hello, my name is John

//#endregion

//#region Part6

// Prototypal inheritance

// function Animal(name) {
//   this.name = name;
// }

// Animal.prototype.sayHello = function () {
//   console.log(`Hello, my name is ${this.name}`);
// };

// function Dog(name, breed) {
//   Animal.call(this, name);
//   this.breed = breed;
// }

// Dog.prototype = Object.create(Animal.prototype);

// let dog1 = new Dog("Rex", "Bulldog");
// dog1.sayHello(); // Hello, my name is Rex

//#endregion


(function A() {
    let a = 5;
    console.log(a);
})();


