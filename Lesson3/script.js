//#region Type casting and type coercion

// Type casting

// let a = 5;

// let b = String(a); // Explicit type casting

// // Implicit type casting or type coercion(принуждение)

// let c = 5;
// let d = '3';

// let sum = c + d; // 53

//#endregion

//#region Indexed Collection

// Arrays

// let arr = [1, 2, 3, 4, 5];

// Тут все как обычно, методы посмотрите сами по ссылке
// https://developer.mozilla.org/ru/docs/Web/JavaScript/Reference/Global_Objects/Array
// Я вам покажу 3 метода функционльного программирования:
// map, reduce, filter

//// map
// let newArr = arr.map((x) => x * 2);
// console.log(newArr);

//// reduce

// let res = arr.reduce((acc, x) => acc + x, 0);
// console.log(res);

//// filter

// let res = arr.filter((x) => x % 2 === 0);
// console.log(res);

//#endregion

//#region Keyed Collections

//// Map - это Dictionary в C#

// let map = new Map();

// map.set('name', 'John');
// map.set('age', 25);

// console.log(map.get('name'));

// map.forEach((value, key) => {
//     console.log(`${key}: ${value}`);
// });

//// Set - это множество

// let nums = [1, 2, 3, 4, 4, 4, 5];
// let set1 = new Set(nums);
// let set2 = new Set([1, 2, 3, 4, 4, 4, 5, 6, 7]);

// Будет вывод без повторений
// console.log(set1);

// var res = set1.difference(set2);

// console.log(res);

// WeakMap and WeakSet - Отличаются тем, что не хранят в
// памяти ссылки на ключи, если они не используются

// let weakMap = new WeakMap();
// let obj = { name: "John", age: 25 };

// weakMap.set(obj, { salary: 2000, position: "developer" });
// console.log(weakMap.get(obj));

// let weakSet = new WeakSet();
// let obj1 = { name: "John", age: 25 };
// let obj2 = { name: "John", age: 25 };

// weakSet.add(obj1);

// console.log(weakSet.has(obj1));

//#endregion

//#region TypedArrays

// let arr1 = new Float32Array(10);

// console.log(arr1);

//#endregion

//#region Comparison operators

// == - сравнивает значения
// === - сравнивает значения и типы
// Object.is - сравнивает значения и типы
// Разница между === и Object.is в том, что Object.is считает -0 и +0 разными

// console.log(0 === -0); // true
// console.log(Object.is(0, -0)); // false

//#endregion

//#region EqualityAlghorithm

//// IsLooselyEqual

// let a = 5;
// let b = '5';

// console.log(a == b);

// //// IsStrictlyEqual

// console.log(a === b);

// //// SameValueZero

// console.log(0 === -0);

// //// SameValue

// console.log(Object.is(0, -0));

//#endregion

//#region ForIn

// let obj = {
//     name: "John",
//     age: 25,
//     position: "developer"
// };

// for (let key in obj) {
//     console.log(`${key}: ${obj[key]}`);
// }

//#endregion

//#region ForOf

// let arr = [1, 2, 3, 4, 5];

// for (let value of arr) {
//     console.log(value);
// }

//#endregion
