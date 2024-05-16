/* 
Strict mode - строгий режим

По умолчанию, она включена во всех скриптах в модулях ES6.
Она нужна для того, чтобы мы не могли создавать переменные без объявления. 

Если этот режим выключен, то переменные можно создавать без объявления, что может привести к ошибкам.

*/

/*
JS - это язык преднозначенный для рабоыты в браузере. 

Теперь мы с вами разберемся с тем, как работать с DOM-деревом.

DOM - Document Object Model - это объектная модель документа.

По сути это дерево, root которого - это наша страница.

в JS есть два главных понятия, которые нам нужно знать - это DOM и BOM. 


Разберемся для начала с DOM.

Давайте заберем какой-то элемент на странице.
Для этого есть четыре варианта - это getElementById, getElementsByClassName, getElementsByTagName, querySelector.
*/

// Напоминаю что ID должен быть уникальным на странице.

// let heading1 = document.getElementById("heading1");
// console.log(heading1);
// console.log(heading1.innerText);
// console.log(heading1.innerHTML);

// let heading2 = document.getElementsByTagName("h1");
// console.log(heading2);

// let heading3 = document.getElementsByClassName('heading1');
// console.log(heading3);

//// Делает тоже самое, но по CSS селекторам. И всегда берет первый элемент.
// let heading4 = document.querySelector('.heading1');
// let heading5 = document.querySelector('#heading1');
// let heading6 = document.querySelector('h1');

// console.log(heading4);
// console.log(heading5);
// console.log(heading6);

// InnerText vs InnerHTML

// let heading1 = document.querySelector("h1");

// console.log(heading1.innerText);
// console.log(heading1.innerHTML);

// setTimeout(() => {
//   heading1.innerHTML = "<span>Привет</span>";
// }, 2000);

// let i = 0;
// setInterval(() => {
//   heading1.innerHTML = ++i;
// }, 200);

// events

// let heading = document.querySelector("h1");

// heading.onclick = () => {
//   console.log("click");
// };

// heading.addEventListener("click", () => {
//   console.log("click");
// });

// callback - это функция, которая передается в качестве аргумента в другую функцию.

// function mathOperation(a, b, operation) {
//   return operation(a, b);
// }

// function sum(a, b) {
//   return a + b;
// }

// let res = mathOperation(2, 3, sum);

// console.log(res);

// Давайте разберем callback на примере событий.

// let heading = document.querySelector("h1");

// function clickHandler() {
//   console.log("click");
// }

// heading.addEventListener("click", clickHandler);

// Если разбирать на примере promise, то получается вообще понятно.

// let promise = new Promise((resolve, reject) => {
//   setTimeout(() => {
//     resolve("done");
//   }, 2000);
// });

// promise.then((data) => {
//   console.log(data);
// });

// Для вас сейчас этот код может быть не понятен, для этого сделаем пример fetch запроса.

// let url = "https://jsonplaceholder.typicode.com/posts";

// let res = fetch(url); // возвращает промис

// res
//   .then((response) => {
//     return response.json();
//   })
//   .then((data) => {
//     console.log(data);
//   })
//   .catch((error) => {
//     console.log(error);
//   });
