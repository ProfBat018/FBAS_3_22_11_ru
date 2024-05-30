// type MyReadonly<T> = {
//   readonly [P in keyof T]: T[P]; // Mapped Type
// };

// let obj = { x: 10, y: 20 };

// let readonlyObj: MyReadonly<typeof obj> = obj;

// console.log(readonlyObj);

// class Transport {}
// class Car extends Transport {}

// type Extends<T, U> = T extends U ? T : U;

// type A = Extends<Car, Transport>; // Car
// type B = Extends<Transport, Car>; // Car
// type C = Extends<number, Transport>; // Transport

import * as myModule from "my-module";


import { doSomething } from "my-module";

doSomething();