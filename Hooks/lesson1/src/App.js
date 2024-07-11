import "./App.css";
import Navbar from "./Navbar";
import ClassClicker from "./ClassClicker";
import FunctionalClicker from "./FunctionalClicker";
import ClassEffect from "./ClassEffect";
import MethodEffect from "./MethodEffect";
import CardsLoader from "./CardsLoader";
import { useState, useEffect, createContext } from "react";
import ContextExample from "./ContextExample";
import StateExample2 from "./StateExample2";
import RefExample2 from "./RefExample2";
import RefExample from "./RefExample";
import StateExample from "./StateExample";
import WithoutMemo from "./withoutMemo";
import MemoExample from "./memoExample";
import CallbackExample from "./CallbackExample";

export const ThemeContext = createContext();

// function App() {
// const [cars, setCars] = useState([]);

// async function fetchCars() {
//   await fetch("http://localhost:5195/getcars", {
//     method: "GET",
//     headers: {
//       "Content-Type": "application/json",
//     },
//   }).then((res) => {
//     res.json().then((data) => {
//       setCars(data);
//     });
//   });
// }

// useEffect(() => {
//   fetchCars();
// }, []);

// return (
// <div className="App">
//   <header className="App-header">
//     <Navbar />
//   </header>

//   <main className="App-main p-5">
//     {/* <ClassClicker /> */}
//     {/* <FunctionalClicker /> */}

//     {/* <ClassEffect /> */}

//     <MethodEffect />
//   </main>
// </div>

// <div className="App">
//   <header>
//     <Navbar />
//   </header>

//   <div className="flex flex-row sm:flex-col">
//     {cars.map((car) => (
//       <CardsLoader
//         key={(Math.random() + 1).toString(36).substring(7)}
//         make={car.make}
//         model={car.model}
//         imagePath={car.imagePath}
//         price={car.price}
//       />
//     ))}
//   </div>
// </div>

// );
// }

// function App() {
//   return (
//     <ThemeContext.Provider value={"black"}>
//       <div className="App">
//         <header>
//           <Navbar />
//         </header>

//         <ContextExample />
//       </div>
//     </ThemeContext.Provider>
//   );
// }

// function App() {
//   let cars = [
//     { make: "Toyota", model: "Corolla", price: 10000 },
//     { make: "Toyota", model: "Camry", price: 15000 },
//     { make: "Toyota", model: "Highlander", price: 20000 },
//     { make: "Toyota", model: "4Runner", price: 25000 },
//     { make: "Toyota", model: "Tacoma", price: 30000 },
//     { make: "Toyota", model: "Tundra", price: 35000 },
//     { make: "Toyota", model: "Sienna", price: 40000 },
//     { make: "Toyota", model: "Avalon", price: 45000 },
//   ];

//   return (
//     <div className="App">
//       {/* <StateExample /> */}

//       {/* <RefExample /> */}

//       {/* <StateExample2 /> */}
//       {/* <RefExample2   /> */}

//       {/* <WithoutMemo data={cars} /> */}

//       <MemoExample data={cars} />
//     </div>
//   );
// }
// export default App;

function App() {
  return (
    <div className="App">
      <header>
        <Navbar />
      </header>

      <CallbackExample />
    </div>
  );
}

export default App;
