`readme` для каждого урока будет в соответствующей папке.

# Components

В `react` есть дыв типа компонентов: `class` и `function`.

Между ними нет по сути никакой разницы, в итоге все зависит от вашего собственного выбора. Между ними разница только в синтаксисе и удобстве.

Для меня более удобными являются `function` компоненты, так как они более легковесные и проще в использовании.

Так же в `react` есть `hooks`, которые позволяют использовать `state` и другие возможности в `function` компонентах. Эти механизмы в классовых компонентах реализуются по другому. Вот пример разницы этих двух компонентов.

Покажу пример на простом компоненте кликере.

Небольшое отступление на стили. Здесь используется все тот же самый `.css`, но есть один важный момент. Во время этого курса я не буду использовать чистый `css`, а буду использовать `tailwindcss`. Это библиотека, которая позволяет писать стили в `js` файле. Это удобно, так как не нужно создавать отдельные файлы для стилей.

Я могу сказать вам что это как `bootstrap`, только лучше.

Для его подключения нужно установить его через `npm`.

```bash

npm install tailwindcss

```

Следующим шагом нужно создать файл `tailwind.config.js` и в нем прописать следующее:

```js
module.exports = {
  purge: [],
  theme: {
    extend: {},
  },
  variants: {
    extend: {},
  },
  plugins: [],
};
```

Далее мы вставляем в `app.css` следующее:

```css
@tailwind base;
@tailwind components;
@tailwind utilities;
```

На этом моменте запомните важную деталь, он должен скомпилировать `css` файл. Тут есть два варианта:

- Написать команду `npx tailwindcss build app.css -o output.css` и подключать уже `output.css` в файлах компонентов.
- Использовать `autoprefixer` и `postcss` для автоматической компиляции.

Хороший вариант использовать второй вариант, так как он автоматически компилирует файлы.

```bash
npm i autoprefixer
```

Затем мы создаем файл `postcss.config.js` и `tailwind.config.js`

# Часть 2 по Hooks

Вопросы по `hooks` от Бахтияра:

- Что такое hooks ?
- useEffect(побочки), useState
- JS & JSX
- StrictMode

`Hooks` - это элементы функиональных компонентов, которые позволяют
работать с состоянием и другими возможностями `react` компонентов. Если перевести это слово, то мы получаем слово `крючки`. Это означает, что мы можем зацепиться за компонент и работать с ним.

При чем их особенность в том, что они доступны лишь в функциональных компонентах. В классовых же компонентах они не работают и заменяются встроенными методами и объектами. Покажу пример на useState и useEffect.

## useState & useEffect

`useState` - это хук, который позволяет добавить состояние в функциональный компонент. При изменении переменных или свойтсв внктри компонента мы доолжны уведомлять `Shadow DOM` об этом. По факту это как `INotifyPropertyChanged` в `C#`.

Вот пример использования `useState`:

Функциональный компонент:

```jsx
import React, { useState } from "react";

export default function Counter() {
  const [count, setCount] = useState(0);

  return (
    <div>
      <p>{count}</p>
      <button onClick={() => setCount(count + 1)}>Increment</button>
    </div>
  );
}
```

`export default` надо писать для того чтобы другие компоненты могли использовать этот компонент. При чем ключевое слово `default` означает, что это главный компонент в файле. В одном файле мы можем прописывать несколько компонентов, вот пример с компонентами `user` и `profile`

```jsx

import React from 'react';

function User(props) {
return (
  <div>
    <h1>{props.username}</h1>
  </div>
);
}

function Profile() {
return (
  <div>
    <User username={"nightcall018"}>
  </div>
);
}


export default Profile;

```

`useState` в классовых компонентах работает по другому. В классовых компонентах мы должны использовать `this.state` и `this.setState` для изменения состояния компонента.

```jsx
import React from "react";

export default class Counter extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
      count: 0,
    };
  }

  render() {
    return (
      <div>
        <p>{this.state.count}</p>
        <button onClick={() => (this.state.count += 1)}>Increment</button>
      </div>
    );
  }
}
```

Я например люблю использовать `function` компоненты, так как они более легковесные и проще в использовании. Но есть исклюения, когда нужно использовать `class` компоненты. Например, если вам нужно использовать `lifecycle` методы, то вам нужно использовать `class` компоненты. Есть методы которые не доступны в `function` компонентах, например `componentDidMount`, `componentDidUpdate`, `componentWillUnmount`. В `function` компонентах есть аналог `useEffect`, но он не полностью заменяет эти методы.

`useEffect` - это хук, который позволяет добавить побочные эффекты в функциональный компонент. Побочные эффекты это действия, которые происходят после отрисовки компонента. Например, если вам нужно отправить запрос на сервер, то это нужно делать в `useEffect`.

Давайте рассмотрим пример на классовом и функциональном компоненте.

Смотреть файлы `classEffect.js` и `functionEffect.js`

## Ответы на вопросы

#### `npm vs npx`

`npm` - это node package manager, который устанавливает пакеты в ваш проект.
`npx` - это node package executor, который позволяет запускать пакеты без их установки.

Например если вы не можете написать просто npm create react-app. Вам сначала надо установить `create-react-app` через `npm`.

`npx` может сразу запустить пакет без его установки, то есть `npx create-react-app`.

## useContext

`useContext` - это хук для передачи гланым компонентам каких-то данных. Предположим у нас есть жва варианта с темой для нашей программы. light & dark

В обычном случае мы из `App.js` можем передать в главные компоненты с помощью `props`. Но если внутри этих компонентов будут другие, а в них другие и так далее, то это будет неудобно. Такой вариант называется `prop drilling`. Показываю плохой пример:

```jsx
import React from "react";

function App() {
  return (
    <div>
      <Header theme="dark" />
      <Content theme="dark" />
      <Footer theme="dark" />
    </div>
  );
}

function Header(props) {
  return (
    <div className={props.theme}>
      <h1>Header</h1>
    </div>
  );
}

function Content(props) {
  return (
    <div className={props.theme}>
      <h1>Content</h1>
    </div>
  );
}

function Footer(props) {
  return (
    <div className={props.theme}>
      <h1>Footer</h1>
    </div>
  );
}
```

Вместо этого мы можем использовать `useContext` и `createContext`.
Пример будет в файле `ContextExample.js`

## useRef

`useRef` - это как `useState`, только наоборот. Все мы знаем что хук `useState` следит за состоянием объекта и при изменении его перерисовывает. `useRef` не перерисовывает компонент, а только следит за изменениями объекта. Сейчас вы скажите, это же классно, давайте тогда использовать только `useRef`. Не все так просто

Обычно `useRef` используется для ссылки с `DOM` на ваш код, а `useState` для состояния компонента. Например, если вам нужно изменить `input` поле, то вам нужно использовать `useRef`. Покажу пример в файле `RefExample.js` и `StateExample.js`

## useMemo

`useMemo` - это хук, который является неотъемлемой частью оптимизации в `react`. Он позволяет кэшировать результаты вычислений и использовать их в дальнейшем. Покажу пример в файле `MemoExample.js`

Принцип его работы досаточно прост, пока ваши вводные данные не изменятся, результаты вычислений будут кэшироваться. Как только ваши вводные данные изменятся, результаты вычислений будут пересчитаны.

`useMemo` принимает два параметра: функцию и массив зависимостей. Если массив зависимостей пустой, то результаты вычислений будут кэшироваться всегда. Если массив зависимостей не пустой, то результаты вычислений будут кэшироваться до тех пор, пока зависимости не изменятся.

То есть вы можете во второй параметр ничего не передавать. В таком случае результаты вычислений будут кэшироваться всегда. Но это не рекомендуется, так как это может привести к утечкам памяти.

САМЫЙ ГЛАВНЫЙ ВОПРОС - КАК ПОНЯТЬ КОГДА ИСПОЛЬЗОВАТЬ `useMemo` ?

1. Сложные постоянные вычисления
2. Вычисления, которые зависят от вводных данных
3. Запрос на сервер

Первые два пункта не такие интересные как 3. Тут сейчас приведу иаксимально реальный пример для оптизации.

## useCallback

`useCallback` - это хук, который позволяет кэшировать колбэк функции.

Давайте сразу же рассмотрим разницу между `useMemo` и `useCallback`.

На самом деле все очень просто. Оба этих хука нужны для кеширования, но `useMemo` кеширует результаты вычислений, а `useCallback` кеширует колбэк функции.

Давайте расмотрим пример в файле `CallbackExample.js`

```jsx
import { useRef, useCallback } from "react";

import Card from "./Card";

export default function CallbackExample() {
  console.log("### Refreshing");

  const fullNameInputElement = useRef();
  const emailInputElement = useRef();
  const passwordInputElement = useRef();
  const passwordConfirmationInputElement = useRef();

  const formHandler = useCallback(
    () => (event) => {
      event.preventDefault(); // не дает странице перезагружаться

      const data = {
        fullName: fullNameInputElement.current.value,
        email: emailInputElement.current.value,
        password: passwordInputElement.current.value,
        passwordConfirmation: passwordConfirmationInputElement.current.value,
      };

      console.log(data);
    },
    []
  );

  return (
    <div className="flex h-screen bg-gray-500 w-screen items-center justify-center">
      <Card>
        <h1 className="text-3xl">Signup</h1>
        <form className="mt-4" onSubmit={formHandler()}>
          <div className="flex flex-col mb-4">
            <label
              className="text-gray-700 text-sm font-bold mb-2"
              htmlFor="full_name"
            >
              Full name
            </label>
            <input
              ref={fullNameInputElement}
              id="full_name"
              placeholder="Full name"
              type="text"
              className="shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:shadow-outline"
            />
          </div>
          <div className="flex flex-col mb-4">
            <label
              className="text-gray-700 text-sm font-bold mb-2"
              htmlFor="email"
            >
              Email
            </label>
            <input
              ref={emailInputElement}
              id="email"
              placeholder="Email"
              type="email"
              className="shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:shadow-outline"
            />
          </div>
          <div className="flex flex-col mb-4">
            <label
              className="text-gray-700 text-sm font-bold mb-2"
              htmlFor="password"
            >
              Password
            </label>
            <input
              ref={passwordInputElement}
              id="password"
              placeholder="Password"
              type="password"
              className="shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:shadow-outline"
            />
          </div>
          <div className="flex flex-col mb-4">
            <label
              className="text-gray-700 text-sm font-bold mb-2"
              htmlFor="password_confirmation"
            >
              Password Confirmation
            </label>
            <input
              ref={passwordConfirmationInputElement}
              id="password_confirmation"
              placeholder="Password Confirmation"
              type="password"
              className="shadow appearance-none border rounded w-full py-2 px-3 text-gray-700 leading-tight focus:outline-none focus:shadow-outline"
            />
          </div>
          <button
            className="bg-blue-500 hover:bg-blue-700 text-white font-bold py-2 px-4 rounded focus:outline-none focus:shadow-outline"
            type="submit"
          >
            Submit
          </button>
        </form>
      </Card>
    </div>
  );
}
```

В данном примере мы используем `useRef` для ссылки на `input` поля. После этого мы используем `useCallback` для кеширования функции `formHandler`. Но в чем смысл этого ?

Если бы в моей программе использовался бы `useState` на какой-то компонент, то при это весь компонент заново бы перерисовывался. И функция `formHandler` тоже была бы заново создана. Но благодаря `useCallback` функция `formHandler` кешируется и не пересоздается.

По идее `useCallback` и `useMemo` взаимозаменяемы. Из моего личного опыта `useCallback` надо использовать в паре с событиями, а `useMemo` с вычислениями.

Такого рода код например полностью переписывается на `useCallback`:

```jsx
const handler = useCallback(foo(), []);
const handler = useMemo(() => foo(), []);
```

Код написанный выше в принципе делает одно и то же.

## useReducer

`useReducer` - это хук, который позволяет управлять состоянием компонента. Он похож на `useState`, но вместо одного значения он принимает функцию редюсера.

Сразу объясню разницу между `useState` и `useReducer`. `useState` принимает одно значение, а `useReducer` принимает два значения: текущее состояние и действие.

Давайте рассмотрим пример в файле `ReducerExample.js`

Из личного опыта могу сказать, что `useReducer` очень хорошо когда с одним объектом можно производить много действий. Например, если у вас есть объект `user` и вы хотите изменить его имя, фамилию, возраст и так далее. То вам лучше использовать `useReducer` вместо `useState`.

