// function marry(man, woman) {
//     woman.husband = man;
//     man.wife = woman;

//     return {
//       father: man,
//       mother: woman,
//     };
//   }

//   let john = { name: "John" };
//   let ann = { name: "Ann" };

//   let family = marry(john, ann);

//   console.log(family);



// class Person {
//   constructor(name, age) {
//     this._name = name;
//     this._age = age;
//   }
//   get name() {
//     // Можно использовать как свойство, а не как метод
//     console.log(`getter`);
//     return this._name;
//   }
//   set name(value) {
//     console.log(`setter`);
//     this._name = value;
//   }
// }

// let a = new Person("John", 30);

// console.log(a.name); // John

// a.name = "Peter";

// console.log(a.name); // Peter
