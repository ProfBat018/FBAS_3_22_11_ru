# State managment в React 

В `react` есть несколько способов управления состоянием компонентов. В этой статье мы рассмотрим все способы управления состоянием в `react` и сравним их между собой.

- Базовые способы
- - `this.state`
- - `useState()`
- - `useReducer()`
- Redux
- Recoil
- MobX

## Базовые способы

Эти способы мы уже достаточно рассматривали. 
`this.state` - это способ управления состоянием в классовых компонентах.
`useState()` - это способ управления состоянием в функциональных компонентах.
`useReducer()` - это способ управления состоянием в функциональных компонентах, который позволяет управлять сложными состояниями. Например если у одного объекта есть 
много разных действий и нам надо управлять ими. 

## Redux

`Redux` или `React-Redux` - это библиотека для управления состоянием в приложении. Она позволяет управлять состоянием приложения в одном месте. Установить его можно с помощью команды `npm install redux react-redux`.

Redux состоит из 3 основных частей:
- `Store` - это объект, который содержит все состояние приложения.
- `Actions` - это объект, который содержит все действия, которые могут произойти в приложении.
- `Reducers` - это функции, которые обрабатывают действия и изменяют состояние приложения.

Пример счетчика на `redux`:

```jsx

import { createStore } from 'redux';

// Actions
const increment = () => {
  return {
    type: 'INCREMENT'
  }
}

const decrement = () => {
  return {
    type: 'DECREMENT'
  }
}

// Reducer

const counter = (state = 0, action) => {
  switch(action.type) {
    case 'INCREMENT':
      return state + 1;
    case 'DECREMENT':
      return state - 1;
    default:
      return state;
  }
}

// Store

let store = createStore(counter);

store.subscribe(() => console.log(store.getState()));

store.dispatch(increment());

store.dispatch(decrement());

```

