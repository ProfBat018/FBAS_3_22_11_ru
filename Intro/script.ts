// let num1: number = 10;
// let num2: number = 2;
// let num3: any = num1 + num2;

// console.log(num3); // Output: 12
// console.log(typeof num3); // Output: number

// never

// function throwError(errorMsg: string): never {
//   throw new Error(errorMsg);
// }

// function endlessLoop(): never {
//   while (true) {
//     console.log("Hello, world");
//   }
// }

// any vs unknown

// let value1: any;
// let value2: unknown;

// value1 = "Hello, world";
// value2 = "Hello, world";

// console.log(typeof value1); // Output: string
// console.log(typeof value2); // Output: string

// value1 = 100;
// value2 = 100;

// console.log(typeof value1); // Output: number
// console.log(typeof value2); // Output: number

// let str1: string = value1;
// let str2: string = value2; // Error: Type 'unknown' is not assignable to type 'string'.

// console.log("Hello, world");

// Assertion as Type
let heading1: any = document.getElementById(`heading1`) as HTMLHeadingElement;

// Assertion as const

let num2 = 10 as const;
const colors = ["red", "green", "blue"] as const;
