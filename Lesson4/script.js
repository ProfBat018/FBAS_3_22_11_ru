//#region Exception Handling

/*
    Exception - Искоючения в JS точно такие же как и в других языках программирования
    базвый класс Error, нужен для того чтобы пробрасывать исключения 
    или создавать свои собственные исключения. При этом есть возможность
    пробрасывать сырые ошибки как в С++, например: 
    throw 404;
    throw 'error';

    Так лучше конечно не делать, лучше использовать класс Error
    или бросать готовые исключения, например:
    throw new Error('error message'); - это будет обычное исключение
    throw new SyntaxError('error message'); - это будет исключение синтаксической ошибки
    throw new ReferenceError('error message'); - это будет исключение ссылочной ошибки
    throw new TypeError('error message'); - это будет исключение типов данных
    throw new RangeError('error message'); - это будет исключение выхода за пределы диапазона
    throw new EvalError('error message'); - это будет исключение ошибки в eval
    throw new URIError('error message'); - это буд  ет исключение ошибки в URI
*/

// try {
//   console.log(5 / 0);
// } catch (error) {
//   console.log(error.message);
// }

// try {
//     throw new Error(`ООО Кууууурд хахахахахах`);
// } catch (error) {
//     console.log(error);
//     console.log(error.name);
//     console.log(error.message);
//     // console.log(error);
// }

// class MyError extends Error {
//   constructor(message) {
//     super(message);
//     this.name = "MyError";
//   }

//   showMessage() {
//     console.log(` Message is: ${this.message}`);
//   }
// }

// try {
//   throw new MyError("My custom error");
// } catch (error) {
//   console.log(error);
//   console.log(error.name);
//   console.log(error.message);
//   error.showMessage();
// }

// let i, j;

// loop1: for (i = 0; i < 3; i++) {
//   loop2: for (j = 0; j < 3; j++) {
//     if (i === 1 && j === 1) {
//       break loop1;
//     }
//     console.log(`i = ${i}, j = ${j}`);
//   }
// }

//#endregion

//#region Functions

// normal func
// function sum(a, b) {
//   return a + b;
// }

// arrow func
// let sum2 = (a, b) => a + b;

// difference in this

// let user = {
//   name: "John",
//   sayHi() {
//     console.log(this.name);
//   },
//   sayHi2: () => {
//     console.log(this.name);
//   },
// };

// user.sayHi();
// user.sayHi2();

//// rest params

// function sum(a, b, c, ...rest) {
//   console.log(rest);
//   return a + b + c + rest.reduce((acc, item) => acc + item, 0);
// }

// console.log(sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));

//// spread operator

// let arr = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

// console.log(sum(...arr));

//#endregion

//#region Closures

// function createCounter() {
//   let counter = 0;

//   return function () {
//     return counter++;
//   };
// }

// let counter = createCounter();

// console.log(counter());
// console.log(counter());
// console.log(counter());

//#endregion




